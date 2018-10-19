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
            /*
            DBConnect dbconn = new DBConnect();
            
            
            
            if (dbconn.unCheck(tBUN.Text).Equals(false))
            {
                //(firstname, lastname, doB, gender, address1, address2, contactno, username, password)
                dbconn.userCreate(tBFirstName.Text, tBLastName.Text, tBDoB.Text,
                              tBGender.Text, tBAddress1.Text, tBAddress2.Text,
                              tBContactNo.Text, tBUN.Text, tBPW.Text);

                //if success, output messagebox and login screen, then close the register window.
                MessageBox.Show("User created.");
                login lgin = new login();
                lgin.Show();
                Close();

            }
            else {

                MessageBox.Show("Username already existed.");

            }*/

            //DEMO, NO ACTUAL DATA SAVED
            MessageBox.Show("DEMO: User created.[working in progress, no actual data saved]");
            login lgin = new login();
            lgin.Show();
            Close();

        }
    }
}
