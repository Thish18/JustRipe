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

        /*not tested yet*/
        public bool unCheck(string un) {

            string query = "SELECT username FROM Users WHERE username = "+ un +";";
            /*dunno will it work or not,  but probably means like (<what you wanna do with query>, <the database and server you connect>)*/
            MySqlCommand cmd = new MySqlCommand(query,conn);

            if (cmd.ToString() != un)
            {

                return false;

            }
            else {

                return true;

            }

        }

        /*not tested yet*/
        public bool pwCheck(string pw){

            string query = "SELECT Password FROM Users WHERE username = " + pw + ";";
            /*dunno will it work or not,  but probably means like (<what you wanna do with query>, <the database and server you connect>)*/
            MySqlCommand cmd = new MySqlCommand(query, conn);

            if (cmd.ToString() != pw)
            {

                return false;

            }
            else
            {

                return true;

            }

        }

    }
}
