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

        private int userID;

        public LabourerManagement(int ID)
        {
            InitializeComponent();
            userID = ID;



            lBLabourerList.Text = "";

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
        private string connStr;
        SqlConnection connToDB;
        private SqlDataAdapter dataAdap;
        private SqlDataReader dataRead;
        SqlCommand comm;
        public void OpenConn()
        {
            connToDB = new SqlConnection(connStr);        
            connToDB.Open();
        }
        //this will close the connection to the database server once the program closed
        public void CloseConn()
        {
            connToDB.Close();
        }
        public void Initialize()
        {

            string mdfPath = Path.Combine(Application.StartupPath, "DBJustRipe.mdf");

            connStr = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + mdfPath + ";Integrated Security=True;Connect Timeout=30");

        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        static BindingSource bs;
        private DataTable datatable = new DataTable();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboLabRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            Initialize();
            OpenConn();
            DBConnect dbconn = new DBConnect(); 

            string query;
            query = "SELECT * " +
                    "FROM Users";
            comm = new SqlCommand(query, connToDB);
           
            dataAdap = new SqlDataAdapter(query, connToDB);
            DataTable dt = new DataTable();
            dataAdap.Fill(dt);
            bs = new BindingSource(dt, null);
            dataRead = comm.ExecuteReader();
            comm.ExecuteNonQuery();

            txtLabFirstName.DataBindings.Add("Text", bs, "firstname");
            txtLabLastName.DataBindings.Add("Text", bs, "lastname");
            txtLabUsername.DataBindings.Add("Text", bs, "username");
            txtLabDoB.DataBindings.Add("Text", bs, "DateOfBirth");
            txtLabGender.DataBindings.Add("Text", bs, "Gender");
            txtLabAddress.DataBindings.Add("Text", bs, "address1");
            txtLabAddress1.DataBindings.Add("Text", bs, "address2");
            txtLabContactNum.DataBindings.Add("Text", bs, "ContactNum");

            CloseConn();
        }
    }
}
