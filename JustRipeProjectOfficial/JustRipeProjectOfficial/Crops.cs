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
        private bool createEnable;

        private string DefUpdateText = "Update Information";
        private string DefCreateText = "Create New Crops";
        private string DefSelectText = "Select";

        private string newUpdateText = "Create New";
        private string newCreateText = "select existed crops to exit";

        public Crops(int ID)
        {

            InitializeComponent();

            AccessEnable();

            dbconn.getCropsData();
            lBCropsList.DataSource = dbconn.cropsList;
            lBCropsList.DisplayMember = "cropsType";
            lBCropsList.ValueMember = "crops_ID";

            //cbSowingType.DataSource = *PlaceHolder *;
            //cbSowingType.DisplayMember = "sowingType";
            //cbSowingType.ValueMember = "sowingM_ID";

            //cbHarvestType.DataSource = *PlaceHolder *;
            //cbHarvestType.DisplayMember = "harvestType";
            //cbHarvestType.ValueMember = "harvestM_ID";

            //cBSpecial.DataSource = *PlaceHolder *;
            //cBSpecial.DisplayMember = "specialType";
            //cBSpecial.ValueMember = "specialT_ID";

            dbconn.getfertilizerData();
            cbFertilizer.DataSource = dbconn.fertilizersList;
            cbFertilizer.DisplayMember = "fertilizerType";
            cbFertilizer.ValueMember = "fertilizer_ID";
            cbFertilizer.Text = null;

            dbconn.getVehicleTypeData();
            cbVehicle.DataSource = dbconn.vehicleTypeList;
            cbVehicle.DisplayMember = "vehicleType";
            cbVehicle.ValueMember = "vehiclesT_ID";
            cbVehicle.Text = null;

            userID = ID;

            dbconn.userInfoExport(userID);
            rankID = Convert.ToInt32(dbconn.tempUserInfo.Rows[0]["rankID"]);

            //if rank is 1 (staff) they are not allow to access to these area.
            if ( rankID == 1) {

                rankAccessDisable();

            }

        }

        private void rankAccessDisable() {

            btnCreate.Enabled = false;
            btnUpdate.Enabled = false;
            btnAssignedList.Enabled = false;
            btnVehicle.Enabled = false;
            btnFertilizer.Enabled = false;

            txtName.Enabled = false;
            txtQuantity.Enabled = false;
            txtMini.Enabled = false;
            txtMax.Enabled = false;
            cbFertilizer.Enabled = false;
            cbSowingType.Enabled = false;
            cbHarvestType.Enabled = false;
            cbVehicle.Enabled = false;
            cBSpecial.Enabled = false;

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

        private void btnSelect_Click(object sender, EventArgs e)
        {

            AccessEnable();

            int id = Convert.ToInt32(lBCropsList.SelectedValue.ToString());
            dbconn.getCropsDetails(id);

            txtName.Text = dbconn.cropsDetail.Rows[0]["cropsType"].ToString();
            txtQuantity.Text = dbconn.cropsDetail.Rows[0]["Quantity"].ToString();
            txtTimeNeeded.Text = dbconn.cropsDetail.Rows[0]["PeriodNeeded"].ToString();
            txtMini.Text = dbconn.cropsDetail.Rows[0]["miniTemp"].ToString();
            txtMax.Text = dbconn.cropsDetail.Rows[0]["maxTemp"].ToString();
            cbFertilizer.Text = dbconn.cropsDetail.Rows[0]["fertilizerType"].ToString();
            cbSowingType.Text = dbconn.cropsDetail.Rows[0]["sowingType"].ToString();
            cbHarvestType.Text = dbconn.cropsDetail.Rows[0]["harvestType"].ToString();
            txtPlateNo.Text = dbconn.cropsDetail.Rows[0]["plateNum"].ToString();
            cBSpecial.Text = dbconn.cropsDetail.Rows[0]["specialType"].ToString();
            txtTreatmentExtra.Text = dbconn.cropsDetail.Rows[0]["Description"].ToString();
            txtFuel.Text = dbconn.cropsDetail.Rows[0]["fuelType"].ToString();
            cbVehicle.Text = dbconn.cropsDetail.Rows[0]["vehicleType"].ToString();

        }

        private void btnAssignedList_Click(object sender, EventArgs e)
        {

            LabourersList ll = new LabourersList();
            ll.Show();
            Hide();

        }

        private void cBVehicleEnable_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        private void btnVehicle_Click(object sender, EventArgs e)
        {
            Vehicles vhc = new Vehicles(userID);
            vhc.Show();
            Hide();
        }

        private void btnFertilizer_Click(object sender, EventArgs e)
        {
            Fertiliser ftr = new Fertiliser(userID);
            ftr.Show();
            Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            AccessDisable();

            txtName.Text = null;
            txtQuantity.Text = null;
            txtTimeNeeded.Text = null;
            txtMini.Text = null;
            txtMax.Text = null;

            cbFertilizer.Text = null;
            cbSowingType.Text = null;
            cbHarvestType.Text = null;

            cBSpecial.Text = null;
            txtTreatmentExtra.Text = null;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            AccessEnable();

            string name = txtName.Text;
            int quantity = Convert.ToInt32(txtQuantity.Text);
            int mini = Convert.ToInt32(txtMini.Text);
            int max = Convert.ToInt32(txtMax.Text);
            
            //placeHolder
            int veh = 1;
            //int special = Convert.ToInt32(cBSpecial.SelectedValue);
            int special = 1;
            int fer = Convert.ToInt32(cbFertilizer.SelectedValue);
            //int sowing = Convert.ToInt32(cbSowingType.SelectedValue);
            int sowing = 1;
            //int harvest = Convert.ToInt32(cbHarvestType.SelectedValue);
            int harvest = 1;


            if (createEnable)
            {

                //use insert cmd.
                dbconn.createCrop(name, quantity, mini, max, fer, sowing, harvest, veh, special);

            }
            else {

                //use update cmd.

            }

            btnUpdate.Text = "Update Information";

            dbconn.getCropsData();
            lBCropsList.DataSource = dbconn.cropsList;
            lBCropsList.DisplayMember = "cropsType";
            lBCropsList.ValueMember = "crops_ID";

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Crops cps = new Crops(userID);
            cps.Show();
            Close();
        }

        private void AccessEnable() {

            createEnable = false;
            btnCreate.Enabled = true;
            btnCreate.Text = DefCreateText;
            btnUpdate.Text = DefUpdateText;


        }

        private void AccessDisable() {

            createEnable = true;
            btnCreate.Enabled = false;
            btnUpdate.Text = newUpdateText;
            btnCreate.Text = newCreateText;


        }

    }
}
