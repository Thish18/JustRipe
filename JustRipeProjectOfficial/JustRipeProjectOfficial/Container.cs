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
    public partial class Container : Form
    {
        DBConnect dbconn = new DBConnect();

        private int userID;

        public Container(int id)
        {
            InitializeComponent();

            userID = id;

            dbconn.getContainerData();
            lBContainerList.DataSource = dbconn.containerList;
            lBContainerList.DisplayMember = "containers_ID";
            lBContainerList.ValueMember = "containers_ID";

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            foreach (Form f in Application.OpenForms)
                if (f is Storage)
                {
                    
                    f.Show();
                    break;

                }

            Close();

        }

        private string DefUpdateText = "Update Information";
        private string DefCreateText = "Create New";

        private string newUpdateText = "Create New";
        private string newCreateText = "select existed container to exit";

        private bool createEnable;

        private void AccessEnable()
        {
            //when create button not pressed
            createEnable = false;
            btnCreate.Enabled = true;
            btnCreate.Text = DefCreateText;
            btnUpdate.Text = DefUpdateText;

        }

        private void AccessDisable()
        {
            //when create button pressed
            createEnable = true;
            btnCreate.Enabled = false;
            btnUpdate.Text = newUpdateText;
            btnCreate.Text = newCreateText;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            AccessDisable();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            AccessEnable();

            int id = Convert.ToInt32(lBContainerList.SelectedValue.ToString());

            dbconn.getContainerDetail(id);
            MessageBox.Show(id.ToString());
            /*still working here, [0]["containers_ID"] doesnt work*/
            txtStorageID.Text = dbconn.containerDetail.Rows[0]["containers_ID"].ToString();
            txtSize.Text = dbconn.containerDetail.Rows[0]["size"].ToString();
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txtStorageID.ToString());

            dbconn.tempAddContainer(id);

        }
    }
}