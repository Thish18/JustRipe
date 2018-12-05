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
    public partial class ChangePassword : Form
    {

        DBConnect dbconn = new DBConnect();
        private string connStr;
        SqlConnection connToDB;
        private SqlDataAdapter dataAdap;
        private SqlDataReader dataRead;
        SqlCommand comm;

        public ChangePassword()
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

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "" && txtNewPassword.Text != "" && txtConfirmPassword.Text != "") {

                string un = txtUsername.Text;
                string pw = txtPassword.Text;
                string npw = txtNewPassword.Text;
                string pwCorr = txtConfirmPassword.Text;

                if (dbconn.loginCheck(un, pw)) //Old Password is correct.
                {
                    if (npw == pwCorr) //Checking that the new password was typed correctly.
                    {
                        DialogResult Answer = MessageBox.Show("Are you sure you wish to change your current login password?", "Password change confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Answer == DialogResult.Yes)
                        {                                  
                            dbconn.passwordUpdate(un,pw,npw);

                            MessageBox.Show("The password has been changed.", "Password changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            foreach (Form f in Application.OpenForms)
                                if (f is login)
                                {

                                    f.Show();
                                    break;

                                }

                            Close();

                        }
                        else
                        {
                            MessageBox.Show("The password has not been changed.", "Password not changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The new password may have been typed incorrectly.", "Password change failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else //Old password isn't correct.
                {
                    MessageBox.Show("The old password you entered is incorrect.", "Password change failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Not all required fields have data in them.", "Password change failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
                if (f is login)
                {

                    f.Show();
                    break;

                }

            Close();
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text= "";
        }

        private void btnOpenTable_Click(object sender, EventArgs e)
        {         
                InitializeComponent();
                OpenConn();
             
                string query = "SELECT Username =" + txtUsername.Text + "Password FROM Users";
                comm = new SqlCommand(query, connToDB);
                dataAdap = new SqlDataAdapter(comm);

             
                CloseConn();

            
        }
    }
}
