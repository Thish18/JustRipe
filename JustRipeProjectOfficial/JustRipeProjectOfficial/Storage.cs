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
    public partial class Storage : Form
    {

        DBConnect dbconn = new DBConnect();

        private int userID;

        public Storage(int id)
        {
            InitializeComponent();

            userID = id;

            dbconn.getStorageData();
            lBStorageList.DataSource = dbconn.storageList;
            lBStorageList.DisplayMember = "storagesID";
            lBStorageList.ValueMember = "storagesID";

            dbconn.getCropsData();
            cbCropsList.DataSource = dbconn.cropsList;
            cbCropsList.DisplayMember = "cropsType";
            cbCropsList.ValueMember = "crops_ID";
            cbCropsList.Text = null;

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            foreach (Form f in Application.OpenForms)
                if (f is LabourerManagement)
                {

                    f.Show();
                    break;

                }
                else if (f is MainMenu){

                    f.Show();
                    break;

                }

            Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            AccessEnable();

            int id = Convert.ToInt32(lBStorageList.SelectedValue.ToString());
            
            dbconn.getStorageDetail(id);

            if (dbconn.storageDetail.Rows.Count != 0)
            {

                txtStorageID.Text = dbconn.storageDetail.Rows[0]["storagesID"].ToString();

                cbCropsList.Text = dbconn.storageDetail.Rows[0]["cropsType"].ToString();

            }
            else {

                txtStorageID.Text = id.ToString();
                
                MessageBox.Show("This Storage is Empty.");
                

            }

            /*For some reason this one doesnt work*/

        }

        private string DefUpdateText = "Update Information";
        private string DefCreateText = "Create New";

        private string newUpdateText = "Create New";
        private string newCreateText = "select existed storage to exit";

        private bool createEnable;

        private void AccessEnable()
        {
            //when create button not pressed
            createEnable = false;
            btnCreate.Enabled = true;
            btnCreate.Text = DefCreateText;
            btnUpdate.Text = DefUpdateText;


        }

        private void AccessDisable()
        {
            //when create button pressed
            createEnable = true;
            btnCreate.Enabled = false;
            btnUpdate.Text = newUpdateText;
            btnCreate.Text = newCreateText;


        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            AccessDisable();

            dbconn.getStorageLastID();

            int newID = Convert.ToInt32(dbconn.storageLastID.Rows[0]["storage_ID"].ToString());

            txtStorageID.Text = (newID + 1).ToString();

        }
    }
}
