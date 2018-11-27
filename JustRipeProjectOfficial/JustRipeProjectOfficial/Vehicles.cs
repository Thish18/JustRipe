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
    public partial class Vehicles : Form
    {

        DBConnect dbconn = new DBConnect();

        private int userID;
        private int rankID;
        private bool createEnable;

        public Vehicles(int ID)
        {

            InitializeComponent();

            dbconn.getVehicleData();
            lBVehiclesList.DataSource = dbconn.vehicleList;
            lBVehiclesList.DisplayMember = "typePlate";
            lBVehiclesList.ValueMember = "vehicles_ID";

            dbconn.getVehicleTypeData();
            cbVehicleType.DataSource = dbconn.vehicleTypeList;
            cbVehicleType.DisplayMember = "vehicleType";
            cbVehicleType.ValueMember = "vehiclesT_ID";

            userID = ID;

            dbconn.userInfoExport(userID);

            rankID = Convert.ToInt32(dbconn.tempUserInfo.Rows[0]["rankID"].ToString());

            if (rankID == 1)
            {

                btnCreate.Enabled = false;
                btnUpdate.Enabled = false;

            }

            /*More Code here*/

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Vehicles_Load(object sender, EventArgs e)
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
            int id = Convert.ToInt32(lBVehiclesList.SelectedValue.ToString());
            dbconn.getVehicleDetails(id);

            cbVehicleType.Text = dbconn.vehicleDetail.Rows[0]["vehicleType"].ToString();
            txtPlateNumber.Text = dbconn.vehicleDetail.Rows[0]["plateNum"].ToString();
            txtFuelType.Text = dbconn.vehicleDetail.Rows[0]["fuelType"].ToString();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            createEnable = true;

            cbVehicleType.Text = null;
            txtPlateNumber.Text = null;
            txtFuelType.Text = null;

            btnCreate.Enabled = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            btnCreate.Enabled = true;

            string name = cbVehicleType.Text;
            int plateNumber = Convert.ToInt32(txtPlateNumber.Text);
            string fuelType = txtFuelType.Text;


            if(createEnable)
            {
                //dbconn.createVehicle(name, plateNumber, fuelType);
            }
            else
            {

            }

            //auto updates list after creating vehicle
            dbconn.getVehicleData();
            lBVehiclesList.DataSource = dbconn.vehicleList;
            lBVehiclesList.DisplayMember = "plateNum";
            lBVehiclesList.ValueMember = "vehicles_ID";

        }
    }
}
