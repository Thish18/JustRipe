﻿using System;
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu(userID);
            mm.Show();
            this.Close();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {

        }

        private void LabourerManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
