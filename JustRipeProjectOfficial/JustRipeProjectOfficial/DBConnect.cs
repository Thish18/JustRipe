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
        private string server = "";
        private string database = "";
        private string uid = "";
        private string password = "";

        public DBConnect() {

            //calling the function to start connection.
            Initialize();

        }

        /*Using information given above to fill in the gaps in connection string
         the use it for the actual SQL connection query.*/
        private void Initialize() {

            //using information given above.
            string connStr = "Server=" + server + "database=" + database +
                ";UID=" + uid + ";Password=" + password + ";";

            //connection query for SQL.
            conn = new MySqlConnection(connStr);

        }

        //once MYSQL Connected. I believe this will actually try to connet to the database server.
        private bool OpenConn(){

            try {

                conn.Open();
                return true;

            }
            catch (MySqlException ex) {

                switch (ex.Number) {

                    case 0:
                        MessageBox.Show("Cannot connection to the database server.");
                        break;
                    case 1:
                        MessageBox.Show("Invalid login, please try again.");
                        break;
                }
                return false;

            }

        }

        //this will close the connection to the database server once the program closed.
        private bool CloseConn() {

            try {

                conn.Close();
                return true;

            }
            catch (MySqlException ex) {

                MessageBox.Show(ex.Message);
                return false;

            }

        }

    }
}
