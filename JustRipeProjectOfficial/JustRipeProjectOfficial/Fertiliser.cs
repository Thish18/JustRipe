using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustRipeProjectOfficial
{
    public partial class Fertiliser : Form
    {

        DBConnect dbconn = new DBConnect();

        private int userID;
        private int rankID;
        private bool createEnable;

        public Fertiliser(int ID)
        {
            InitializeComponent();

            btnCreate.Enabled = true;
            createEnable = false;
            
            userID = ID;

            dbconn.userInfoExport(userID);

            rankID = Convert.ToInt32(dbconn.tempUserInfo.Rows[0]["rankID"].ToString());

            if (rankID == 1)
            {

                btnCreate.Enabled = false;
                btnUpdate.Enabled = false;

            }

            /*More Code here*/
            dbconn.getfertilizerData();
            lBFertilizersList.DataSource = dbconn.fertilizersList;
            lBFertilizersList.DisplayMember = "fertilizerType";
            lBFertilizersList.ValueMember = "fertilizer_ID";

        }

        private void Fertiliser_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {

            foreach (Form f in Application.OpenForms)
                if (f is Crops)
                {

                    f.Show();
                    break;

                }

            Close();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(lBFertilizersList.SelectedValue.ToString());
            dbconn.getfertilizerDetails(id);

            typeTextBox.Text = dbconn.fertilizerDetail.Rows[0]["fertilizerType"].ToString();
            quantityTextBox.Text = dbconn.fertilizerDetail.Rows[0]["quantity"].ToString();
            maxQuantityTextBox.Text = dbconn.fertilizerDetail.Rows[0][""].ToString();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            createEnable = true;

            typeTextBox.Text = null;
            quantityTextBox = null;
            maxQuantityTextBox = null;

            btnCreate.Enabled = false;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            btnCreate.Enabled = true;

            string type = typeTextBox.Text;
            int quantity = Convert.ToInt32(quantityTextBox);
            int maxQuantity = Convert.ToInt32(maxQuantityTextBox);

            
            if(createEnable)
            {
                dbconn.createfertilizer(type, quantity);
            }
            else
            {

            }
        }
    }
}
