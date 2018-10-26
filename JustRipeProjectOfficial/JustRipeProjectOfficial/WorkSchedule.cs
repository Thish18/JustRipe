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
    public partial class WorkSchedule : Form
    {

        private int userID;

        public WorkSchedule(int ID)
        {
            InitializeComponent();
            userID = ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form is MainMenu)
                {

                    form.Show();
                    break;

                }
            Close();
        }

        private void WorkSchedule_Load(object sender, EventArgs e)
        {

        }
    }
}
