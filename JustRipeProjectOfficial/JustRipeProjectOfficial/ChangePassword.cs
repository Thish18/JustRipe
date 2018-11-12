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

        private string connStr;
        SqlConnection connToDB;
        private SqlDataAdapter dataAdap;
        private SqlDataReader dataRead;
        SqlCommand comm;

        public ChangePassword()
        {
            InitializeComponent();
        }

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
 /// <summary>
 /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 /// </summary>
        static BindingSource bs;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OpenConn();
            DBConnect dbconn = new DBConnect();

            if (txtUsername.Text != "" && txtPassword.Text != "" && txtNewPassword.Text != "" && txtConfirmPassword.Text != "")
            {
                
                string query = "SELECT Users.username = Users.Password " +
                "FROM Users " +
                "WHERE Password = @UserEnteredPassword ";
                comm = new SqlCommand(query, connToDB);
                comm.Parameters.Add("@UserEnteredPassword", SqlDbType.VarChar).Value = txtPassword.Text;
                dataAdap = new SqlDataAdapter(query, connToDB);
                DataTable dt = new DataTable();
                dataAdap.Fill(dt);
                bs = new BindingSource(dt, null);
                comm.ExecuteNonQuery();

                if (dt.Rows.Count == 1) //Old Password is correct.
                {
                    if (txtNewPassword.Text == txtConfirmPassword.Text) //Checking that the new password was typed correctly.
                    {
                        DialogResult Answer = MessageBox.Show("Are you sure you wish to change your current login password?", "Password change confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Answer == DialogResult.Yes)
                        {
                            string query2 = "UPDATE [Users] " +
                            "SET [Password] = @NewPassword " +
                            "WHERE [Users].[username] = @username";
                            comm = new SqlCommand(query, connToDB);

                            comm.Parameters.Add("@NewPassword", SqlDbType.VarChar).Value = txtNewPassword.Text;
                            comm.Parameters.Add("@username", SqlDbType.VarChar).Value = txtUsername.Text;
                            comm.ExecuteNonQuery();

                            MessageBox.Show("The password has been changed.", "Password changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            login frm = new login();
                            frm.ShowDialog();
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
            CloseConn();

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
    }
}
