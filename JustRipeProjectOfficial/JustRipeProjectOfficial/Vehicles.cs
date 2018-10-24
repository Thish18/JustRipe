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
    public partial class Vehicles : Form
    {

        private int userID;

        public Vehicles(int ID)
        {
            InitializeComponent();
            userID = ID;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu(userID);
            mm.Show();
            Hide();
        }

        private void Vehicles_Load(object sender, EventArgs e)
        {

        }
    }
}
