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

        void FillCombo()
        {
            /*InitializeComponent();
            //connection query for SQL for the types of crops.
            OpenConn();
            string query = "SELECT * FROM Users";


            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);
            SqlDataReader dataReader;
            try
            {
                OpenConn();
                dataReader = comm.ExecuteReader();

                while (dataReader.Read())
                {
                    //  string sfirstname = dataReader.GetString("firstname");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CloseConn();*/

            

        }




    }
}
