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
using System.Data;
using System.IO;

namespace JustRipeProjectOfficial
{
    public partial class ManagerHarvestTimetable : Form
    {
        DBConnect dbconn = new DBConnect();
        private string connStr;
        SqlConnection connToDB;
        private SqlDataAdapter dataAdap;
        private SqlDataReader dataRead;
        SqlCommand comm;

        SqlCommand comm1;
        private SqlDataAdapter dataAdap1;



        public ManagerHarvestTimetable()
        {
            InitializeComponent();
        }

        //once MYSQL Connected. I believe this will actually try to connect to the database server.
        public void OpenConn()
        {
            connToDB = new SqlConnection(connStr);
            connToDB.Open();
        }

        //this will close the connection to the database server once the program closed.
        public void CloseConn()
        {
            connToDB.Close();
        }
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHarvTimetbale_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
                if (f is Crops)
                {

                    f.Show();
                    break;

                }

            Close();
        }

        private void btnHarvTimetable_Click(object sender, EventArgs e)
        {

            dbconn.getHarvestData();
            dgvHarvestMethod.DataSource = dbconn.harvestTypeList;

            using (SqlConnection Conn = new SqlConnection(connStr))
            {

                InitializeComponent();
                //connection query for SQL for the types of crops.
                OpenConn();
                string query1 = "SELECT * FROM Harvest";

                comm1 = new SqlCommand(query1, connToDB);
                dataAdap1 = new SqlDataAdapter(comm1);

                
                DataTable dt1 = new DataTable();
                // use adapter to flood above table
                dataAdap1.Fill(dt1);

                dgvHarvest.DataSource = dt1;

                CloseConn();
            }

          
        }
    }
}
