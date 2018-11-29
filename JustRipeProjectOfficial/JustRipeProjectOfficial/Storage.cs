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
            lBStorageList.DisplayMember = "storageGroup";
            lBStorageList.ValueMember = "storagesID";

            dbconn.getCropsData();
            cbCropsList.DataSource = dbconn.cropsList;
            cbCropsList.DisplayMember = "cropsType";
            cbCropsList.ValueMember = "crops_ID";

            

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            foreach (Form f in Application.OpenForms)
                if (f is MainMenu)
                {

                    f.Show();
                    break;

                }

            Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Container ctner = new Container(userID);
            ctner.Show();
            Hide();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(lBStorageList.SelectedValue.ToString());
            
            dbconn.getStorageDetail(id);

            txtStorageID.Text = dbconn.storageDetail.Rows[0]["storagesID"].ToString();

            /*For some reason this one doesnt work*/

            lbContainersList.DataSource = dbconn.storageDetail;
            lbContainersList.DisplayMember = "containersID";
            lbContainersList.ValueMember = "containersID";

            cbCropsList.Text = dbconn.storageDetail.Rows[0]["cropsType"].ToString();

        }

    }
}
