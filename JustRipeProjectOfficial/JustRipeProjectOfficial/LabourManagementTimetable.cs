using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace JustRipeProjectOfficial
{
    public partial class LabourManagementTimetable : Form
    {
        DBConnect dbconn = new DBConnect();

        public LabourManagementTimetable()
        {
            InitializeComponent();
        }


        private void btnHarvTimetable_Click(object sender, EventArgs e)
        {

            dbconn.getWorkSchedule();
            dgvTimeTable.DataSource = dbconn.scheduleInfo;

        }

        private void btnHarvTimetbale_Click(object sender, EventArgs e)
        {
            //////
        }
    }
}
