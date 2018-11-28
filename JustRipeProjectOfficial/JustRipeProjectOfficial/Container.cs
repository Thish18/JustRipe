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
    public partial class Container : Form
    {
        DBConnect dbconn = new DBConnect();

        private int userID;

        public Container(int id)
        {
            InitializeComponent();

            userID = id;

            //dbconn.getContainerData();
            //lBContainerList.DataSource = /*dbconn.containerList*/;
            lBContainerList.DisplayMember = "containerT_ID";
            lBContainerList.ValueMember = "containerT_ID";

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
    }
}
