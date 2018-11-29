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
    public partial class LabourManagementTimetable : Form
    {
        DBConnect dbconn = new DBConnect();
        private string connStr;
        SqlConnection connToDB;
        private SqlDataAdapter dataAdap;
        private SqlDataReader dataRead;
        SqlCommand comm;

        public LabourManagementTimetable()
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

        private void btnHarvTimetable_Click(object sender, EventArgs e)
        {
            using (SqlConnection Conn = new SqlConnection(connStr))
            {
                InitializeComponent();
                //connection query for SQL for the types of crops.
                OpenConn();
                string query = "SELECT * FROM WorkSchedule";

                comm = new SqlCommand(query, connToDB);
                dataAdap = new SqlDataAdapter(comm);


                DataTable dt = new DataTable();
                // use adapter to flood above table
                dataAdap.Fill(dt);

                dgvTimeTable.DataSource = dt;
                CloseConn();
            }
        }
    }
}
