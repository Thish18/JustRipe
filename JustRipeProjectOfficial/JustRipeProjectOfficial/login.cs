using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustRipeProjectOfficial
{
    public partial class login : Form
    {

        private int userID;

        public login()
        {
            InitializeComponent();
           
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            string un = txtUsername.Text;
            string pw = txtPassword.Text;

            //[SQL]
            
            if (un != "" && pw != "") {

                //if statement with sql function uncheck and pwcheck
                DBConnect dbconn = new DBConnect();
                if (dbconn.loginCheck(un, pw).Equals(true))
                {

                    dbconn.userInfoImport();
                    userID = Convert.ToInt32(dbconn.tempUserInfo[0].ToString());

                    //do it when the username and password are correct.
                    MainMenu frm = new MainMenu(userID);
                    frm.Show();
                    this.Hide();

                }
                else
                {

                    MessageBox.Show("Username / Password Incorrect.");

                }

            }//SOMEONE TRY TO SQL INJECT TO THE LOGIN PLZ, thanks
            else if (un.Contains("-").Equals(true) || un.Contains(";").Equals(true) || un.Contains(" ").Equals(true)
                     || pw.Contains("-").Equals(true) || pw.Contains(";").Equals(true) || pw.Contains(" ").Equals(true))
            {
                //check if username or password contain these 2 main symbol for sql injection.
                MessageBox.Show("SQL INJECTION IS ILLEGAL.");

            } else {

                MessageBox.Show("Please Enter Username and Password.");


            }

        }

      
        //DONT DELETE THIS ONE
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            Hide();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangePassword frm = new ChangePassword();
            frm.ShowDialog();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
