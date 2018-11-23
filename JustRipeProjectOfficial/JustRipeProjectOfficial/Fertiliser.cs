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
    public partial class Fertiliser : Form
    {

        DBConnect dbconn = new DBConnect();

        private int userID;
        private int rankID;

        public Fertiliser(int ID)
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
            dbconn.getfertilizerData();
            lBFertilizersList.DataSource = dbconn.fertilizersList;
            lBFertilizersList.DisplayMember = "Type";
            lBFertilizersList.ValueMember = "fertilizer_ID";

        }

        private void Fertiliser_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {

            foreach (Form f in Application.OpenForms)
                if (f is Crops)
                {

                    f.Show();
                    break;

                }

            Close();

        }
    }
}
