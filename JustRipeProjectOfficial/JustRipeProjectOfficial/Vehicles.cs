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
    public partial class Vehicles : Form
    {

        DBConnect dbconn = new DBConnect();

        private int userID;
        private int rankID;

        public Vehicles(int ID)
        {

            InitializeComponent();
            userID = ID;

            dbconn.userInfoExport(userID);

            rankID = Convert.ToInt32(dbconn.tempUserInfo[6]);

            if (rankID == 1)
            {

                btnCreate.Enabled = false;
                btnUpdate.Enabled = false;

            }

            /*More Code here*/

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Vehicles_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click_1(object sender, EventArgs e)
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
