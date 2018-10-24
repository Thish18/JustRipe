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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            login lgin = new login();
            lgin.Show();
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Username: " + tBUN + " has been used. Please with another.");

            //[SQL]
            /*
            DBConnect dbconn = new DBConnect();
            //(firstname, lastname, doB, gender, address1, address2, contactno, username, password)
            dbconn.userCreate(tBFirstName.Text, tBLastName.Text, tBDoB.Text,
                          tBGender.Text, tBAddress1.Text, tBAddress2.Text,
                          tBContactNo.Text, tBUN.Text, tBPW.Text);
            */

            MessageBox.Show("DEMO: User created.");
            login lgin = new login();
            lgin.Show();
            Close();

        }
    }
}
