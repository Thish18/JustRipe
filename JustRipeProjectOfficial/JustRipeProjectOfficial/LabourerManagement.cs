﻿using System;
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
        private int tempID;

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
            /*place holder*/

            

        }

        private void lBLabourerList_SelectedIndexChanged(object sender, EventArgs e)
        {

            dbconn.getLabourerData(tempID);


        }

        private void cbCrops_SelectedIndexChanged(object sender, EventArgs e)
        {

            Initialize();
            OpenConn();
            DBConnect dbconn = new DBConnect();

            string query;
            query = "SELECT Crops*, FROM Crops*";

            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);

        }

        private void cbFertilizer_SelectedIndexChanged(object sender, EventArgs e)
        {

            Initialize();
            OpenConn();
            DBConnect dbconn = new DBConnect();

            string query;
            query = "SELECT Crops*, FROM Fertlizer*";

            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);

        }
    }
}
