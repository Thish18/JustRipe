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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu(userID);
            mm.Show();
            Hide();
        }

        private void WorkSchedule_Load(object sender, EventArgs e)
        {

        }
    }
}
