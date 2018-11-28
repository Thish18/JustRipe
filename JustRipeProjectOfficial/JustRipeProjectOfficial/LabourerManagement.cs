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
        private string connStr;
        SqlConnection connToDB;
        private SqlDataAdapter dataAdap;
        private SqlDataReader dataRead;
        SqlCommand comm;

        private int userID;
        private int tempID;

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

        public LabourerManagement(int ID)
        {
            InitializeComponent();
            userID = ID;

            dbconn.getLabourersList();
            lBLabourerList.DataSource = dbconn.labourerList;
            lBLabourerList.DisplayMember = "fullname";
            lBLabourerList.ValueMember = "users_ID";

            dbconn.getCropsData();
            cbCrops.DataSource = dbconn.cropsList;
            cbCrops.DisplayMember = "cropstype";
            cbCrops.ValueMember = "crops_ID";

            dbconn.getfertilizerData();
            cbFertilizer.DataSource = dbconn.fertilizersList;
            cbFertilizer.DisplayMember = "fertilizertype";
            cbFertilizer.ValueMember = "fertilizer_ID";

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
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///

        private void lBLabourerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbconn.getLabourerData(tempID);
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            using (SqlConnection Conn = new SqlConnection(connStr))
            {
                Initialize();
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lBLabourerList.SelectedValue.ToString());
            dbconn.getLabourerData(id);

            txtLabID.Text = dbconn.labourerInfo.Rows[0]["users_ID"].ToString();
            txtLabFirstName.Text = dbconn.labourerInfo.Rows[0]["firstname"].ToString();
            txtLabLastName.Text = dbconn.labourerInfo.Rows[0]["lastname"].ToString();
            txtLabUsername.Text = dbconn.labourerInfo.Rows[0]["username"].ToString();
            txtLabDoB.Text = dbconn.labourerInfo.Rows[0]["DateOfBirth"].ToString();
            txtLabGender.Text = dbconn.labourerInfo.Rows[0]["Gender"].ToString();
            txtLabAddress.Text = dbconn.labourerInfo.Rows[0]["address1"].ToString();
            txtLabAddress1.Text = dbconn.labourerInfo.Rows[0]["address2"].ToString();
            txtLabContactNum.Text = dbconn.labourerInfo.Rows[0]["ContactNum"].ToString();
            
        }
    }
}