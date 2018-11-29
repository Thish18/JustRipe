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
    public partial class sowingMethod : Form
    {

        private int userID;

        public sowingMethod(int id)
        {
            InitializeComponent();

            userID = id;

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            foreach (Form f in Application.OpenForms)
                if (f is Crops)
                {

                    f.Show();
                    break;

                }

            Close();

        }
    }
}
