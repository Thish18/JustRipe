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

            dbconn.getCropsData();
            lBCropsList.DataSource = dbconn.cropsList;
            lBCropsList.DisplayMember = "cropsType";
            lBCropsList.ValueMember = "crops_ID";

            userID = ID;

            dbconn.userInfoExport(userID);

            rankID = Convert.ToInt32(dbconn.tempUserInfo.Rows[0]["rankID"].ToString());

            //if rank is 1 (staff) they are not allow to access to these area.
            if ( rankID == 1) {

                btnCreate.Enabled = false;
                btnUpdate.Enabled = false;
                btnAssignedList.Enabled = false;
                btnVehicle.Enabled = false;
                btnFertilizer.Enabled = false;

            }

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

            int id = Convert.ToInt32(lBCropsList.SelectedValue.ToString());
            dbconn.getCropsDetails(id);

            txtName.Text = dbconn.cropsDetail.Rows[0]["cropsType"].ToString();
            txtQuantity.Text = dbconn.cropsDetail.Rows[0]["Quantity"].ToString();
            txtTimeNeeded.Text = dbconn.cropsDetail.Rows[0]["PeriodNeeded"].ToString();
            txtMini.Text = dbconn.cropsDetail.Rows[0]["miniTemp"].ToString();
            txtMax.Text = dbconn.cropsDetail.Rows[0]["maxTemp"].ToString();
            txtFertilizer.Text = dbconn.cropsDetail.Rows[0]["fertilizerType"].ToString();
            txtSowingType.Text = dbconn.cropsDetail.Rows[0]["sowingType"].ToString();
            txtHarvestType.Text = dbconn.cropsDetail.Rows[0]["harvestType"].ToString();
            txtPlateNo.Text = dbconn.cropsDetail.Rows[0]["plateNum"].ToString();
            txtTreatmentType.Text = dbconn.cropsDetail.Rows[0]["specialType"].ToString();
            txtTreatmentExtra.Text = dbconn.cropsDetail.Rows[0]["Description"].ToString();
            txtFuel.Text = dbconn.cropsDetail.Rows[0]["fuelType"].ToString();
            txtVehicleType.Text = dbconn.cropsDetail.Rows[0]["vehicleType"].ToString();

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
    }
}
