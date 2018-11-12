using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*addition namespace needed.*/
//use for messagebox in this case.
using System.Windows.Forms;
//use for sql commands and functions.
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace JustRipeProjectOfficial
{
    class DBConnect
    {

        /*===============================================================[Database Connection Setup]===============================================================================================*/

        //setup logged in info.
        private int userID;
        
        private string connStr;
        SqlConnection connToDB;
        private SqlDataAdapter dataAdap;
        private SqlDataReader dataRead;
        SqlCommand comm;

        //Initialize (Probably)
        public DBConnect(/*string connStr*/)
        {
            Initialize();
        }

        public void Initialize() {

            string mdfPath = Path.Combine(Application.StartupPath, "DBJustRipe.mdf") ;

            connStr = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + mdfPath + ";Integrated Security=True;Connect Timeout=30");

        }

        //once MYSQL Connected. I believe this will actually try to connect to the database server.
        public void OpenConn()
        {

            connToDB = new SqlConnection(connStr);

            connToDB.Open();

        }

        //this will close the connection to the database server once the program closed.
        
        public void CloseConn() {

            connToDB.Close();

        }


        /*===============================================================[LogIn/Register Functions]===============================================================================================*/
        //[TEST SUCCESS] it used to check if username existed or not.

        public bool unCheckExist(string un)
        {

            Initialize();
            //connection query for SQL.
            OpenConn();

            string dataUN = "";

            string query = "SELECT username FROM users WHERE username = '" + un + "'";

            comm = new SqlCommand(query, connToDB);
            dataRead = comm.ExecuteReader();

            using (dataRead) {

                while (dataRead.Read()) {

                    dataUN = dataRead["username"].ToString();

                }

            }

            if (dataUN == un)
            {


                return true;

            }
            else
            {

                return false;

            }



        }

        //[TEST SUCCESS] it used to check if username, password correct or not.
        public bool loginCheck(string un, string pw)
        {

            Initialize();
            //connection query for SQL.
            OpenConn();

            string dataUN = "";
            string datapw = "";

            string query = "SELECT users_ID, username, Password FROM users WHERE username = '" + un + "'";

            comm = new SqlCommand(query, connToDB);
            dataRead = comm.ExecuteReader();

            using (dataRead)
            {

                while (dataRead.Read())
                {
                    userID = Convert.ToInt32(dataRead["users_ID"]);
                    dataUN = dataRead["username"].ToString();
                    datapw = dataRead["Password"].ToString();

                }

            }

            if (datapw == pw)
            {

                //saving user Id to the DBConnect.cs until next login
                return true;

            }
            else
            {

                return false;

            }

        }

        //temp storage List.
        public List<object> tempUserInfo;

        //use to import ONLY.
        public void userInfoImport()
        {

            string query = "SELECT users.*, ranktype.* FROM users INNER JOIN ranktype ON users.rankID = ranktype.rank_ID WHERE users_ID = '" + userID + "';";

            comm = new SqlCommand(query, connToDB);
            dataRead = comm.ExecuteReader();

            tempUserInfo = new List<object>();

            using (dataRead)
            {

                while (dataRead.Read())
                {
                    tempUserInfo.Add(Convert.ToInt32(dataRead["users_ID"]));
                    tempUserInfo.Add(dataRead["firstName"].ToString());
                    tempUserInfo.Add(dataRead["lastName"].ToString());
                    tempUserInfo.Add(dataRead["username"].ToString());
                    tempUserInfo.Add(dataRead["Password"].ToString());
                    tempUserInfo.Add(dataRead["ContactNum"].ToString());
                    tempUserInfo.Add(dataRead["rankID"].ToString());

                }

            }

        }
        //export ONLY
        public void userInfoExport(int userID)
        {

            Initialize();
            //connection query for SQL.
            OpenConn();

            string query = "SELECT users.*, ranktype.* FROM users INNER JOIN ranktype ON users.rankID = ranktype.rank_ID WHERE users_ID = " + userID + "";

            comm = new SqlCommand(query, connToDB);
            dataRead = comm.ExecuteReader();

            tempUserInfo = new List<object>();

            using (dataRead)
            {

                while (dataRead.Read())
                {
                    tempUserInfo.Add(Convert.ToInt32(dataRead["users_ID"]));
                    tempUserInfo.Add(dataRead["firstName"].ToString());
                    tempUserInfo.Add(dataRead["lastName"].ToString());
                    tempUserInfo.Add(dataRead["username"].ToString());
                    tempUserInfo.Add(dataRead["Password"].ToString());
                    tempUserInfo.Add(dataRead["ContactNum"].ToString());
                    tempUserInfo.Add(dataRead["Type"].ToString());

                }

            }

        }

        public void userCreate(string fn, string ln, string dob, string g, string ad1, string ad2, string no, string un, string pw)
        {
            Initialize();
            //connection query for SQL.
            OpenConn();
            string query = "INSERT INTO Users (firstname,lastname,username,Password,ContactNum,rankID,DateOfBirth,Gender) VALUES(@firstname, @lastname,@username,@Password,@ContactNum,@rankID,@DateOfBirth,@Gender)";
      
            comm = new SqlCommand(query, connToDB);
      
            comm.Parameters.AddWithValue("@firstname", fn);
            comm.Parameters.AddWithValue("@lastname", ln);
            comm.Parameters.AddWithValue("@username", un);
            comm.Parameters.AddWithValue("@Password", pw);
            comm.Parameters.AddWithValue("@ContactNum", no);
            comm.Parameters.AddWithValue("@rankID", 1);
            comm.Parameters.AddWithValue("@DateOfBirth", dob);
            comm.Parameters.AddWithValue("@Gender", g);

            comm.ExecuteNonQuery();
            dataAdap = new SqlDataAdapter(query, connToDB);
            CloseConn();
            MessageBox.Show("User Created.");


        }

        /*
        public void userUpdate(string fn, string ln, string dob, string g, string ad1, string ad2, string no, string pw, int rank) {

            Initialize();
            conn.Open();

            string connstr = "";

            MySqlCommand comm = new MySqlCommand(connstr, conn);
            //comm.CommandText = "";
            comm.Parameters.AddWithValue("@", "");
            comm.Parameters.AddWithValue("@", "");
            comm.Parameters.AddWithValue("@", "");
            comm.Parameters.AddWithValue("@", "");
            comm.Parameters.AddWithValue("@", "");
            comm.Parameters.AddWithValue("@", "");

        }*/

        /*===============================================================[Other Data Import/Output Functions]===============================================================================================*/

        //functions for getting crops data
        public void getCropsData() {

            Initialize();
            //connection query for SQL for the types of crops.
            OpenConn();
            string query = "INSERT crops_ID, type FROM Crops";

            comm = new SqlCommand(query, connToDB);

        }
        // getting detials for the selected crop.
        public void getCropsDetails() { }


        //functions for getting vehicles data.
        public void getVehicleData() {

            Initialize();
            //connection query for SQL for the types of Vehicles.
            OpenConn();
            string query = "INSERT vehicles_ID, type FROM Vehicles";

            comm = new SqlCommand(query, connToDB);

        }
        //getting details for the selected vehicle.
        public void getVehicleDetails() { }

        //functions for getting fertilizers data.
        public void getfertilizerData() {

            Initialize();
            //connection query for SQL for the types of fertilizers.
            OpenConn();
            string query = "INSERT fertilizer_ID, type FROM fertilizers";

            comm = new SqlCommand(query, connToDB);

        }
        //getting the details for the selected fertilizer.
        public void getfertilizerDetails() { }

        /*===============================================================[Labourer Management / Work Schedule / Timetable Functions]===============================================================================================*/

        //for the list on the left hand side of the Labourer Management
        private List<object[]> labourerList = new List<object[]> { };
        public void getLabourersList() {

            
        }

        //temp storage List.
        public List<object> tempLabourerInfo;
        
        //get the single data selected from the labourer list
        public void getLabourerData() {

            Initialize();
            //connection query for SQL.
            OpenConn();

            string query = "Get labourers first name, last name, username, dob, gender, address, contact and rank";

            comm = new SqlCommand(query, connToDB);
            dataRead = comm.ExecuteReader();

            tempLabourerInfo = new List<object>();

            using (dataRead)
            {

                while (dataRead.Read())
                {
                    tempLabourerInfo.Add(dataRead["firstName"].ToString());
                    tempLabourerInfo.Add(dataRead["lastName"].ToString());
                    tempLabourerInfo.Add(dataRead["username"].ToString());
                    tempLabourerInfo.Add(Convert.ToInt32(dataRead["dob"].ToString()));
                    tempLabourerInfo.Add(dataRead["gender"].ToString());
                    tempLabourerInfo.Add(dataRead["address"].ToString());
                    tempLabourerInfo.Add(Convert.ToInt32(dataRead["contact"].ToString()));
                    tempLabourerInfo.Add(dataRead["rank"].ToString());
                }

            }

            //string fn, ln, un, gender, address, rank;
            //int dob, contact;

            //for (int i = 0; i < labourerList.Count; i++)
            //{
            //    if(labourerList.un == username)
            //    {
            //        //labourers first name
            //        fn = labourerList[i].firstname;
            //        //labourers last name
            //        ln = labourerList[i].lastname;
            //        //labourers username
            //        un = labourerList[i].username;
            //        //labourers DOB
            //        dob = labourerList[i].dob;
            //        //labourers gender
            //        gender = labourerList[i].gender;
            //        //labourers address
            //        address = labourerList[i].address;
            //        //labourers contact no.
            //        contact = labourerList[i].contact;
            //        //labourers rank
            //        rank = labourerList[i].rank;
            //    }
            //}
        }
        //get the harvesttimetable for the specific user
        public void getHarvestTimeTable() { }


        //temp storage List.
        public List<object> tempScheduleInfo;

        //get the work schedule for the specific user
        public void getWorkSchedule() {

            Initialize();
            //connection query for SQL.
            OpenConn();

            string query = "";

            comm = new SqlCommand(query, connToDB);
            dataRead = comm.ExecuteReader();

            tempScheduleInfo = new List<object>();

            using (dataRead)
            {

                while (dataRead.Read())
                {
                    tempScheduleInfo.Add(Convert.ToInt32(dataRead["fertiliserRequired"].ToString()));
                    tempScheduleInfo.Add(Convert.ToInt32(dataRead["cropsHarvested"].ToString()));
                    tempScheduleInfo.Add(Convert.ToInt32(dataRead["cropsCultivated"].ToString()));
                    tempScheduleInfo.Add(Convert.ToInt32(dataRead["storageLevel"].ToString()));
                }

            }



        }

    }
}
