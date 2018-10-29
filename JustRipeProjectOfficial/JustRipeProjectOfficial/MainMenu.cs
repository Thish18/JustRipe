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
    public partial class MainMenu : Form
    {

        private int userID;

        public MainMenu(int ID)
        {
            InitializeComponent();
            //[SQL]
            
            DBConnect DBConn = new DBConnect();
            userID = ID;
            DBConn.userInfoExport(userID);
            lbName.Text = DBConn.tempUserInfo[1].ToString() + " " + DBConn.tempUserInfo[2].ToString();
            lbRank.Text = DBConn.tempUserInfo[6].ToString();

        }

        public MainMenu()
        {
        }

        private void btnLabourManagement_Click(object sender, EventArgs e)
        {

            /*show the labourer management window and close the main menu window.*/
            LabourerManagement LM = new LabourerManagement(userID);
            LM.Show();
            this.Hide();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            /*Logout, leave the main menu and back to the log in screen*/
            foreach (Form f in Application.OpenForms)
                if (f is login)
                {

                    f.Show();
                    break;

                }

            Close();

            /*disconnect from the database server
             leave it commented unless you are connected to the database.*/

            //DBConnect DBConn = new DBConnect();
            //DBConn.CloseConn();


        }
        private void btnCrops_Click(object sender, EventArgs e)
        {

            Crops cps = new Crops(userID);
            cps.Show();
            Hide();

        }

        private void btnHarvestTimetable_Click(object sender, EventArgs e)
        {
            HarvestTimetable ht = new HarvestTimetable(userID);
            ht.Show();
            Hide();

        }

        private void btnFertilizer_Click_1(object sender, EventArgs e)
        {
            Fertiliser ftr = new Fertiliser(userID);
            ftr.Show();
            Hide();

        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            Vehicles vhc = new Vehicles(userID);
            vhc.Show();
            Hide();
        }

        private void tBName_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnWorkSchedule_Click(object sender, EventArgs e)
        {
            WorkSchedule ws = new WorkSchedule(userID);
            ws.Show();
            Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
              
        }
    }
}
