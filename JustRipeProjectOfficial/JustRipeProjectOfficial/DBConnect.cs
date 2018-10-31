using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*addition namespace needed.*/
//use for messagebox in this case.
using System.Windows.Forms;
//use for mysql commands and functions.
using MySql.Data.MySqlClient;

namespace JustRipeProjectOfficial
{
    class DBConnect
    {

        /*===============================================================[Database Connection Setup]===============================================================================================*/
        /*Setup for connection to the MYSQL Server*/
        private MySqlConnection conn;

        //fill in information needed for connection.
        private string server = "localhost";
        private string database = "mydb";
        private string uid = "root";
        private string password = "";

        //solve the server doesnt support ssl connection error.
        private string sslmode = "none";

        //setup logged in info.
        private int userID;

        /*Using information given above to fill in the gaps in connection string
         the use it for the actual SQL connection query.*/

        public void Initialize()
        {

            //using information given above.
            string connStr = "Server=" + server + ";database=" + database +
                ";UID=" + uid + ";Password=" + password + ";" + "sslmode=" + sslmode + ";";

            //connection query for SQL.
            conn = new MySqlConnection(connStr);

        }

        //once MYSQL Connected. I believe this will actually try to connect to the database server.
        public bool OpenConn()
        {

            try
            {

                conn.Open();
                return true;

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                return false;

            }

        }

        //this will close the connection to the database server once the program closed.
        /*
        public bool CloseConn() {

            try {

                conn.Close();
                return true;

            }
            catch (MySqlException ex) {

                MessageBox.Show(ex.Message);
                return false;

            }

        }*/


        /*===============================================================[LogIn/Register Functions]===============================================================================================*/
        //[TEST SUCCESS] it used to check if username existed or not.
        public bool unCheckExist(string un)
        {

            string dataUN = "";
            Initialize();
            conn.Open();

            string query = "SELECT username FROM users WHERE username = '" + un + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            /*important code to export data read from sql database.*/
            MySqlDataReader mdr = cmd.ExecuteReader();



            while (mdr.Read())
            {

                dataUN = (string)mdr["username"];

            }

            if (dataUN == un)
            {

                conn.Close();
                return true;

            }
            else
            {

                conn.Close();
                return false;

            }



        }

        //[TEST SUCCESS] it used to check if username, password correct or not.
        public bool loginCheck(string un, string pw)
        {

            string dataUN = "";
            string datapw = "";

            Initialize();
            conn.Open();

            string query = "SELECT users_ID, username, Password FROM users WHERE username = '" + un + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            /*important code to export data read from sql database.*/
            MySqlDataReader mdr = cmd.ExecuteReader();

            while (mdr.Read())
            {

                //use to check username and password.
                dataUN = (string)mdr["username"];
                datapw = (string)mdr["Password"];
                //userID to temp store user ID.
                userID = (int)mdr["users_ID"];

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
        public List<object> tempUserInfo = new List<object>();

        //use to import ONLY.
        public void userInfoImport()
        {

            Initialize();
            conn.Open();

            string query = "SELECT users.*, ranktype.* FROM users INNER JOIN ranktype ON users.rankID = ranktype.rank_ID WHERE users_ID = '" + userID + "';";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            /*important code to export data read from sql database.*/
            MySqlDataReader mdr = cmd.ExecuteReader();

            while (mdr.Read())
            {

                //storing all users data to the temp list.
                tempUserInfo.Add((int)mdr["users_ID"]);
                tempUserInfo.Add((string)mdr["firstname"]);
                tempUserInfo.Add((string)mdr["lastname"]);
                tempUserInfo.Add((string)mdr["username"]);
                tempUserInfo.Add((string)mdr["Password"]);
                tempUserInfo.Add((string)mdr["ContactNum"]);
                tempUserInfo.Add((string)mdr["rankType"]);

            }

        }
        //export ONLY
        public void userInfoExport(int userID)
        {

            Initialize();
            conn.Open();

            string query = "SELECT users.*, ranktype.* FROM users INNER JOIN ranktype ON users.rankID = ranktype.rank_ID WHERE users_ID = " + userID + "";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            /*important code to export data read from sql database.*/
            MySqlDataReader mdr = cmd.ExecuteReader();

            while (mdr.Read())
            {

                //storing all users data to the temp list.
                tempUserInfo.Add((int)mdr["users_ID"]);
                tempUserInfo.Add((string)mdr["firstname"]);
                tempUserInfo.Add((string)mdr["lastname"]);
                tempUserInfo.Add((string)mdr["username"]);
                tempUserInfo.Add((string)mdr["Password"]);
                tempUserInfo.Add((string)mdr["ContactNum"]);
                tempUserInfo.Add((string)mdr["rankType"]);

            }

        }

        //damn, finally it works

        public void userCreate(string fn, string ln, string dob, string g, string ad1, string ad2, string no, string un, string pw)
        {

            Initialize();
            conn.Open();

            //connection query for SQL.
            string connstr = "INSERT INTO users(firstname, lastname,username,Password,ContactNum,rankID) VALUES(@firstname, @lastname,@username,@Password,@ContactNum,@rankID)";

            MySqlCommand comm = new MySqlCommand(connstr, conn);
            //comm.CommandText = "INSERT INTO users(firstname, lastname,username,Password,ContactNum,rankID) VALUES(@firstname, @lastname,@username,@Password,@ContactNum,@rankID)";
            comm.Parameters.AddWithValue("@firstname", fn);
            comm.Parameters.AddWithValue("@lastname", ln);
            comm.Parameters.AddWithValue("@username", un);
            comm.Parameters.AddWithValue("@Password", pw);
            comm.Parameters.AddWithValue("@ContactNum", no);
            comm.Parameters.AddWithValue("@rankID", "1");
            comm.ExecuteNonQuery();

            MessageBox.Show("User Created.");

            conn.Close();

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

        //functiosn for getting crops data
        public void getCropsData() { }
        //functiosn for getting vehicles data
        public void getVehicleData() { }
        //functiosn for getting fertilizers data
        public void getfertilizerData() { }

        /*===============================================================[Labourer Management / Work Schedule / Timetable Functions]===============================================================================================*/

        //for the list on the left hand side of the Labourer Management
        private List<object[]> labourerList = new List<object[]> { };
        public void getLabourersList() {

            Initialize();
            conn.Open();

            string query = "SELECT  users_ID, firstname, lastname FROM users;";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader mdr = cmd.ExecuteReader();

            object[] labourerListInfo = new object[3];
            while (mdr.Read())
            {

                labourerListInfo[0] = (int)mdr["users_ID"];
                labourerListInfo[1] = (string)mdr["firstname"];
                labourerListInfo[2] = (string)mdr["lastname"];

                

            }

            labourerList.Add(labourerListInfo);

        }

        //get the single data selected from the labourer list
        public void getLabourerData() { }
        //get the harvesttimetable for the specific user
        public void getHarvestTimeTable() { }
        //get the work schedule for the specific user
        public void getWorkSchedule() { }

    }
}
