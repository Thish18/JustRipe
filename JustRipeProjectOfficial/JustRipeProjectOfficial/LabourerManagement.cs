using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace JustRipeProjectOfficial
{
    public partial class LabourerManagement : Form
    {


        DBConnect dbconn = new DBConnect();

        private int userID;
        private int tempID;

        public LabourerManagement(int ID)
        {
            InitializeComponent();
            userID = ID;

            dbconn.getLabourersList();
            lBLabourerList.DataSource = dbconn.labourerList;
            lBLabourerList.DisplayMember = "fullname";
            lBLabourerList.ValueMember = "users_ID";

            dbconn.getCropsData();
            cbCrops.DataSource = dbconn.cropsList;
            cbCrops.DisplayMember = "cropstype";
            cbCrops.ValueMember = "crops_ID";

            dbconn.getEmptyStorageData();
            cbStorage.DataSource = dbconn.storageList;
            cbStorage.DisplayMember = "storage_ID";
            cbStorage.ValueMember = "storage_ID";

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
                if (f is MainMenu)
                {

                    f.Show();
                    break;

                }

            Close();
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///

        private void lBLabourerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbconn.getLabourerData(tempID);
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            LabourManagementTimetable frm = new LabourManagementTimetable();
            frm.ShowDialog();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lBLabourerList.SelectedValue.ToString());
            dbconn.getLabourerData(id);

            txtLabID.Text = dbconn.labourerInfo.Rows[0]["users_ID"].ToString();
            txtLabFirstName.Text = dbconn.labourerInfo.Rows[0]["firstname"].ToString();
            txtLabLastName.Text = dbconn.labourerInfo.Rows[0]["lastname"].ToString();
            txtLabUsername.Text = dbconn.labourerInfo.Rows[0]["username"].ToString();
            //txtLabDoB.Text = dbconn.labourerInfo.Rows[0]["DateOfBirth"].ToString();
           // txtLabGender.Text = dbconn.labourerInfo.Rows[0]["Gender"].ToString();
            txtLabAddress.Text = dbconn.labourerInfo.Rows[0]["address1"].ToString();
            txtLabAddress1.Text = dbconn.labourerInfo.Rows[0]["address2"].ToString();
            txtLabContactNum.Text = dbconn.labourerInfo.Rows[0]["ContactNum"].ToString();
            
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {

            Storage strg = new Storage(userID);
            strg.Show();
            Hide();
        }

       

        private void btnLoadComments_Click(object sender, EventArgs e)
        {
            string ft = "Users_ID: " + txtLabID.Text + "\r\n";
            ft = ft + "Firstname: " + txtLabFirstName.Text + "\r\n";
            ft = ft + "Rank: " + txtLabRankID.Text + "\r\n";
            ft = ft + "Crops: " + cbCrops.Text + "\r\n";
            ft = ft + "Storage: " + cbStorage.Text + "\r\n";
            ft = ft + "Date: " + dtpDate.Text;
            txtinfo.Text = ft;
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {

            if (txtLabID.Text == null)
            {

                MessageBox.Show("Please select a user first.");

            }
            else {

                int userID = Convert.ToInt32(txtLabID.Text);
                int cropID = Convert.ToInt32(cbCrops.SelectedValue.ToString());
                int storageID = Convert.ToInt32(cbStorage.SelectedValue.ToString());

                dbconn.createWorkSchedule(userID, cropID, storageID, dtpDate.Value);

            }
            
        }

        
    }
}