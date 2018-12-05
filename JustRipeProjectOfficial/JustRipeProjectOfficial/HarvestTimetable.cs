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
    public partial class HarvestTimetable : Form
    {
        DBConnect dbconn = new DBConnect();
        private int userID;
        private int rankID;


        public HarvestTimetable(int ID)
        {
            InitializeComponent();
            userID = ID;

            dbconn.userInfoExport(userID);

            rankID = Convert.ToInt32(dbconn.tempUserInfo.Rows[0]["rankID"].ToString());

            //If rank is 1 (staff) they are not allow to access to these area.
            if (rankID == 1)
            {
                btnManagerHavTime.Enabled = false;
            }
            else if(rankID == 2 )
            {
                btnManagerHavTime.Enabled = true;
            }
            else if(rankID == 3)
            {
                btnManagerHavTime.Enabled = true; 
            }
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

        private void btnManagerHavTime_Click(object sender, EventArgs e)
        {
            ManagerHarvestTimetable frm = new ManagerHarvestTimetable();
            frm.ShowDialog();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string treatment;
            int time, labourR, labourersR, harvestEx;

            treatment = special_treatment_textbox.Text;
            time = Convert.ToInt32(time_needed.Text);
            labourR = Convert.ToInt32(labour_required.Text);
            labourersR = Convert.ToInt32(labourers_required.Text);
            harvestEx = Convert.ToInt32(harvest_expected.Text);
            
            dbconn.insertHarvestTimetable(treatment, time, labourR, labourersR, harvestEx);

            string ft = "Date: " + dtpHarvest.Text + "\r\n";
            ft = ft + "Harvest ID: " + txt.Text + "\r\n";
            ft = ft + "Harvest Treatment: " + txtHarvestTreat.Text + "\r\n";
            ft = ft + "Time needed: " + txtTimeNeed.Text + "\r\n";
            ft = ft + "Labour Required: " + txtLabourRequired.Text + "\r\n";
            ft = ft + "Labourers Required: " + txtLabourersRequired.Text + "\r\n";
            ft = ft + "When Harvest Expected: " + txtHarvExpect.Text;
            HarvestTxt.Text = ft;
        }
      
    }
}
