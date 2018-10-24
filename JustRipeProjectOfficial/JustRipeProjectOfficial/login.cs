using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JustRipeProjectOfficial
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
           
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();
            //[SQL]
            


            string un = txtUsername.Text;
            string pw = txtPassword.Text;

            //[SQL]
            
            if (un != "" && pw != "") {

                //if statement with sql function uncheck and pwcheck
                DBConnect dbconn = new DBConnect();
                if (dbconn.loginCheck(un, pw).Equals(true))
                {

                    //do it when the username and password are correct.
                    
                    dbconn.userInfoImport();
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

            //TEMP Link between windows.
<<<<<<< HEAD
            //frm.Show();
            //Hide();
=======
            /*
            frm.Show();
            Hide();
            */
>>>>>>> f7721fd44349f3c1c2aaf17771257d006ad25d27

        }

        /*someone please delete it without crashing the program, 
         like IF YOU KNOW WHAT YOU DOING AND KNOW WHAT WILL HAPPEN,
         PLEASE DELETE THESE " USELESS CODES. thanks*/
        //this one
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }
        //and this one
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
        //DONT DELETE THIS ONE
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            Hide();
        }
    }
}
