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
        //storing temp users info
        private int users_ID;
        private int rank_ID;

        public MainMenu()
        {
            InitializeComponent();
            //[SQL]
            /*
            DBConnect DBConn = new DBConnect();
            DBConn.userInfoImport();
            
            //firstname lastname combined
            tBName.Text = DBConn.temp[1].ToString() + " " + DBConn.temp[2].ToString();
            users_ID = (int)DBConn.temp[0];
            rank_ID = (int)DBConn.temp[6];
            */

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

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
