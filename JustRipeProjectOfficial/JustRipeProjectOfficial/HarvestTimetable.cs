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
    public partial class HarvestTimetable : Form
    {

        private int userID;

        public HarvestTimetable(int ID)
        {
            InitializeComponent();
            userID = ID;
        }

        private void HarvestTimetable_Load(object sender, EventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form is MainMenu)
                {

                    form.Show();
                    break;

                }
            Close();
        }
    }
}
