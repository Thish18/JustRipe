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
    public partial class Settings : Form
    {

        private int userID;

        public Settings(int ID)
        {
            InitializeComponent();
            userID = ID;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
