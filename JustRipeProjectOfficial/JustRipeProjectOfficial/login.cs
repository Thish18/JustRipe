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
            DBConnect dbconn = new DBConnect();

            string un = txtUsername.Text;
            string pw = txtPassword.Text;

            /*if statement with sql function uncheck and pwcheck*/
            if (dbconn.unCheckExist(un).Equals(true) && dbconn.pwCheck(un,pw).Equals(true))
            {

                /*do it when the username and password are correct.*/
                dbconn.userInfoImport(un);
                frm.Show();
                this.Hide();

            }
            else {

                MessageBox.Show("Username / Password Incorrect.");

            }

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

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            Hide();
        }
    }
}
