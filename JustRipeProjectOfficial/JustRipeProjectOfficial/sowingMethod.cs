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
    public partial class sowingMethod : Form
    {

        DBConnect dbconn = new DBConnect();

        private int userID;
        private int rankID;
        private bool createEnable;

        public sowingMethod(int id)
        {
            InitializeComponent();

            btnCreate.Enabled = true;
            createEnable = false;

            userID = id;

            dbconn.userInfoExport(userID);

            rankID = Convert.ToInt32(dbconn.tempUserInfo.Rows[0]["rankID"].ToString());

            if(rankID == 1)
            {

                btnCreate.Enabled = false;
                btnUpdate.Enabled = false;

            }

            dbconn.getSowingData();
            lBSowingList.DataSource = dbconn.fertilizersList;
            lBSowingList.DisplayMember = "sowingType";
            lBSowingList.ValueMember = "sowingM_ID";

        }

        private void btnMenu_Click(object sender, EventArgs e)
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
            int id = Convert.ToInt32(lBSowingList.SelectedValue.ToString());
            dbconn.getSowingDetails(id);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            createEnable = true;

            typeTextBox.Text = null;
            quantityTextBox.Text = null;
            maxQuantityTextBox.Text = null;

            btnCreate.Enabled = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            btnCreate.Enabled = true;

            string type = typeTextBox.Text;
            //int quantity = Convert.ToInt32(quantityTextBox.Text);
            //int maxQuantity = Convert.ToInt32(maxQuantityTextBox.Text);

            if(createEnable)
            {
                //dbconn.createSowingMethod(type, quantity);
            }
            else
            {

            }

            //auto updates list after creating a fertiliser
            dbconn.getSowingData();
            lBSowingList.DataSource = dbconn.fertilizersList;
            lBSowingList.DisplayMember = "sowingType";
            lBSowingList.ValueMember = "sowingM_ID";

        }

    }
}
