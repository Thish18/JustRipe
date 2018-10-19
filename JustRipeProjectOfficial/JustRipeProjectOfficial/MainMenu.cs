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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnLabourManagement_Click(object sender, EventArgs e)
        {

            /*show the labourer management window and close the main menu window.*/
            LabourerManagement LM = new LabourerManagement();
            LM.Show();
            this.Hide();


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            /*Logout, leave the main menu and back to the log in screen*/
            login lgin = new login();
            lgin.Show();
            this.Close();

            /*disconnect from the database server
             leave it commented unless you are connected to the database.*/
            
            //DBConnect DBConn = new DBConnect();
            //DBConn.CloseConn();
            

        }
    }
}
