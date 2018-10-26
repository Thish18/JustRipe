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
    public partial class Crops : Form
    {

        private int userID;

        public Crops(int ID)
        {
            InitializeComponent();
            userID = ID;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Crops_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
                if (f is MainMenu)
                {

                    f.Show();
                    break;

                }

            Close();
        }
    }
}
