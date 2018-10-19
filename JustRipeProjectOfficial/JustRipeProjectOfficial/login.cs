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
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();

            /*if statement with sql function uncheck and pwcheck*/

            /*do it when the username and password are correct.*/
            frm.Show();
            this.Hide();

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


    }
}
