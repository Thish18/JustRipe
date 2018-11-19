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
    public partial class LabourersList : Form
    {
        public LabourersList()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
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
