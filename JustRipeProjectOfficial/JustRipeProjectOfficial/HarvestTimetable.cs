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
    }
}
