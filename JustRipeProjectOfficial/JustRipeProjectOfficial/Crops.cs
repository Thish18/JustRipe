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
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu(userID);
            mm.Show();
            Hide();
        }

        private void Crops_Load(object sender, EventArgs e)
        {

        }
    }
}
