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
            int id = 0;

            dbconn.getLabourerData(id);
            txtLabFirstName.Text = dbconn.tempLabourerInfo[0].ToString();

        }
    }
}
