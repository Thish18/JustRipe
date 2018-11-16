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

        public LabourerManagement(int ID)
        {
            InitializeComponent();
            userID = ID;

            

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
        /// ////////////////////////////////////////////////////////////////////////

        //this will close the connection to the database server once the program closed

        private void cboLabRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*not finished*/
            

        }

        private void lBLabourerList_SelectedIndexChanged(object sender, EventArgs e)
        {

            int id = userID;
            /*
            dbconn.getLabourerData(id);
            txtLabFirstName.Text = dbconn.tempLabourerInfo[0].ToString();
            txtLabLastName.Text = dbconn.tempLabourerInfo[1].ToString();
            txtLabUsername.Text = dbconn.tempLabourerInfo[2].ToString();
            txtLabDoB.Text = dbconn.tempLabourerInfo[3].ToString();
            txtLabGender.Text = dbconn.tempLabourerInfo[4].ToString();
            txtLabAddress.Text = dbconn.tempLabourerInfo[5].ToString();
            txtLabAddress1.Text = dbconn.tempLabourerInfo[6].ToString();
            txtLabContactNum.Text = dbconn.tempLabourerInfo[7].ToString();
            */

        }
    }
}
