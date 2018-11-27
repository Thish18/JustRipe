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

        public ManagerHarvestTimetable()
        {
            InitializeComponent();
        }

        public void Initialize()
        {      
            string mdfPath = Path.Combine(Application.StartupPath, "DBJustRipe.mdf");
            connStr = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + mdfPath + ";Integrated Security=True;Connect Timeout=30");
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
            Initialize();
            //connection query for SQL for the types of crops.
            OpenConn();
            string query = "SELECT * FROM HarvestMethod";
            string query2 = "SELECT * FROM Harvest";

            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);
            CloseConn();
            DataTable dt = new DataTable();
            // use adapter to flood above table
            dataAdap.Fill(dt);
            // create binding source object to manipulate data
            BindingSource bs = new BindingSource(dt, null);
        }

        private void dgvManagerHavTime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Initialize();
            //connection query for SQL for the types of crops.
            OpenConn();
            string query = "SELECT * FROM HarvestMethod"; 

            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);
            CloseConn();
            DataTable dt = new DataTable();
            // use adapter to flood above table
            dataAdap.Fill(dt);
            // create binding source object to manipulate data
            BindingSource bs = new BindingSource(dt, null);

        }

        private void dgvHarvest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Initialize();
            //connection query for SQL for the types of crops.
            OpenConn();
            string query = "SELECT * FROM Harvest";

            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);
            CloseConn();
            DataTable dt = new DataTable();
            // use adapter to flood above table
            dataAdap.Fill(dt);
            // create binding source object to manipulate data
            BindingSource bs = new BindingSource(dt, null);
        }
    }
}
