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
    public partial class Storage : Form
    {

        DBConnect dbconn = new DBConnect();

        private int userID;

        public Storage(int id)
        {
            InitializeComponent();

            userID = id;

            //dbconn.getStorageData();
            //lBStorageList.DataSource = /*dbconn.storageList*/;
            lBStorageList.DisplayMember = "storage_ID";
            lBStorageList.ValueMember = "storage_ID";


        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            foreach (Form f in Application.OpenForms)
                if (f is MainMenu)
                {

                    f.Show();
                    break;

                }

            Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Container ctner = new Container(userID);
            ctner.Show();
            Hide();

        }
    }
}
