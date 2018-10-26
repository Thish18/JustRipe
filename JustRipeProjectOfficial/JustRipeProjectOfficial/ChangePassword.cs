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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DBConnect dbconn = new DBConnect();

            if (dbconn.unCheckExist(txtUsername.Text).Equals(true))
            {

                MessageBox.Show("yah");

            }
            else {

                MessageBox.Show("Incorrect username/password.");


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
    }
}
