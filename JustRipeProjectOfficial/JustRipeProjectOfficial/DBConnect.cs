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
        /*Setup for connection to the MYSQL Server*/
        private MySqlConnection conn;
        //fill in information needed for connection.
        private string server = "localhost";
        private string database = "justripe";
        private string uid = "root";
        private string password = "";
        //solve the server doesnt support ssl connection error.
        private string sslmode = "none";

        /*Using information given above to fill in the gaps in connection string
         the use it for the actual SQL connection query.*/
        public void DBInitialize() {

            Initialize();

        }


        private void Initialize() {

            //using information given above.
            string connStr = "Server=" + server + ";database=" + database +
                ";UID=" + uid + ";Password=" + password + ";" + "sslmode=" + sslmode + ";";

            //connection query for SQL.
            conn = new MySqlConnection(connStr);

        }

        //once MYSQL Connected. I believe this will actually try to connet to the database server.
        public bool OpenConn(){

            try {

                conn.Open();
                return true;
                
            }
            catch (MySqlException ex) {

                MessageBox.Show(ex.Message);
                return false;

            }

        }

        //this will close the connection to the database server once the program closed.
        public bool CloseConn() {

            try {

                conn.Close();
                return true;

            }
            catch (MySqlException ex) {

                MessageBox.Show(ex.Message);
                return false;

            }

        }

        /*[WORKING IN PROGRESS]*/
        /*-DO NOT UN COMMENT OR DELETE THIS AREA BELOW-*/
        /*
        //not tested yet
        public bool unCheckExist(string un) {

            string query = "SELECT username FROM users WHERE username = '"+ un +"'";
            MySqlCommand cmd = new MySqlCommand(query, conn);           

        }*/
        /*
        //not tested yet
        public bool pwCheck(string pw){

            string query = "SELECT Password FROM users WHERE username = '"+ pw +"'";
            MySqlCommand cmd = new MySqlCommand(query, conn);

        }*/

        //damn, finally it works
        /*
        public void userCreate(string fn, string ln, string dob, string g, string ad1, string ad2, string no, string un, string pw) {

            //this one works, but i have to figure out how to use the initialize
            string connStr = "Server=" + server + ";database=" + database +
                ";UID=" + uid + ";Password=" + password + ";" + "sslmode=" + sslmode + ";";
            //connection query for SQL.
            conn = new MySqlConnection(connStr);
            conn.Open();

            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO users (firstname, lastname, username, Password, ContactNum) " +
                           "VALUES (@firstname, @lastname, @username, @Password, @ContactNum);";
            comm.Parameters.AddWithValue("@firstname", fn);
            comm.Parameters.AddWithValue("@lastname", ln);
            comm.Parameters.AddWithValue("@username", un);
            comm.Parameters.AddWithValue("@Password", pw);
            comm.Parameters.AddWithValue("@ContactNum", no);
            comm.ExecuteNonQuery();


        }*/

    }
}
