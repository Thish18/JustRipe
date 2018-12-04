﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace JustRipeProjectOfficial
{
    public partial class ManagerHarvestTimetable : Form
    {
        DBConnect dbconn = new DBConnect();
       
        public ManagerHarvestTimetable()
        {
            InitializeComponent();
        }

        private void btnHarvTimetbale_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
                if (f is Crops)
                {

                    f.Show();
                    break;

                }

            Close();
        }

        private void btnHarvTimetable_Click(object sender, EventArgs e)
        {

            dbconn.getHarvestData();
            dgvHarvestMethod.DataSource = dbconn.harvestTypeList;

            dbconn.getHarvest();
            dgvHarvest.DataSource = dbconn.HarvestList;

        }
    }
}
