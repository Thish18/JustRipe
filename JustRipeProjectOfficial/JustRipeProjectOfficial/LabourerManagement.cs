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
    public partial class LabourerManagement : Form
    {

        private int userID;

        public LabourerManagement(int ID)
        {
            InitializeComponent();
            userID = ID;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form is MainMenu)
                {

                    form.Show();
                    break;

                }
            Close();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {

        }

        private void LabourerManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
