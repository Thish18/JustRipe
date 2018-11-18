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
    public partial class Crops : Form
    {

        DBConnect dbconn = new DBConnect();
        
        private int userID;
        private int rankID;

        public Crops(int ID)
        {
            InitializeComponent();
            userID = ID;

            dbconn.userInfoExport(userID);

            rankID = Convert.ToInt32(dbconn.tempUserInfo[6]);

            if ( rankID == 1) {

                btnCreate.Enabled = false;
                btnUpdate.Enabled = false;

            }

            dbconn.getCropsData();
            lBCropsList.DataSource = dbconn.cropsList;
            lBCropsList.DisplayMember = "type";
            lBCropsList.ValueMember = "crops_ID";


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Crops_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
                if (f is MainMenu)
                {

                    f.Show();
                    break;

                }

            Close();
        }

        private void lBCropsList_SelectedIndexChanged(object sender, EventArgs e)
        {

            /*import data get from the getcropsdetails with cropsDetails*/


        }
    }
}
