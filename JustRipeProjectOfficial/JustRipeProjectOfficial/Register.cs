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

            foreach (Form f in Application.OpenForms)
                if (f is login) {

                    f.Show();
                    break;

                }

            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Username: " + tBUN.Text + " has been used. Please with another.");

            //MySqlConnection conn = new MySqlConnection();
            //conn.Open();

            //[SQL]

            DBConnect dbconn = new DBConnect();
            //(firstname, lastname, doB, gender, address1, address2, contactno, username, password)
            dbconn.userCreate(tBFirstName.Text, tBLastName.Text, tBDoB.Text,
                          tBGender.Text, tBAddress1.Text, tBAddress2.Text,
                          tBContactNo.Text, tBUN.Text, tBPW.Text);
      
            login lgin = new login();
            lgin.Show();
            Close();

        }
    }
}
