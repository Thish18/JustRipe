namespace JustRipeProjectOfficial
{
    partial class HarvestTimetable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpHarvest = new System.Windows.Forms.DateTimePicker();
            this.HarvestTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.txtHarvestID = new System.Windows.Forms.TextBox();
            this.harvest_id_label = new System.Windows.Forms.Label();
            this.harvest_treatment_label = new System.Windows.Forms.Label();
            this.txtHarvestTreat = new System.Windows.Forms.TextBox();
            this.labour_required = new System.Windows.Forms.Label();
            this.txtLabourRequired = new System.Windows.Forms.TextBox();
            this.time_needed = new System.Windows.Forms.Label();
            this.txtTimeNeed = new System.Windows.Forms.TextBox();
            this.labourers_required = new System.Windows.Forms.Label();
            this.txtLabourersRequired = new System.Windows.Forms.TextBox();
            this.harvest_expected = new System.Windows.Forms.Label();
            this.txtHarvExpect = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRank = new System.Windows.Forms.Label();
            this.btnManagerHavTime = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(347, 178);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(677, 347);
            this.dataGridView1.TabIndex = 41;
            // 
            // dtpHarvest
            // 
            this.dtpHarvest.Location = new System.Drawing.Point(0, 64);
            this.dtpHarvest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHarvest.Name = "dtpHarvest";
            this.dtpHarvest.Size = new System.Drawing.Size(301, 22);
            this.dtpHarvest.TabIndex = 40;
            // 
            // HarvestTxt
            // 
            this.HarvestTxt.Location = new System.Drawing.Point(0, 169);
            this.HarvestTxt.Margin = new System.Windows.Forms.Padding(4);
            this.HarvestTxt.Multiline = true;
            this.HarvestTxt.Name = "HarvestTxt";
            this.HarvestTxt.Size = new System.Drawing.Size(303, 295);
            this.HarvestTxt.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(75)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.btnViewDetails);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.HarvestTxt);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.dtpHarvest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 613);
            this.panel1.TabIndex = 46;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(182)))), ((int)(((byte)(242)))));
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(0, 89);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(303, 80);
            this.btnInsert.TabIndex = 45;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 68);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Table";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(182)))), ((int)(((byte)(242)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(0, 533);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(303, 80);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Back to main menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // txtHarvestID
            // 
            this.txtHarvestID.Location = new System.Drawing.Point(348, 91);
            this.txtHarvestID.Margin = new System.Windows.Forms.Padding(4);
            this.txtHarvestID.Name = "txtHarvestID";
            this.txtHarvestID.Size = new System.Drawing.Size(164, 22);
            this.txtHarvestID.TabIndex = 47;
            // 
            // harvest_id_label
            // 
            this.harvest_id_label.AutoSize = true;
            this.harvest_id_label.Location = new System.Drawing.Point(348, 72);
            this.harvest_id_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.harvest_id_label.Name = "harvest_id_label";
            this.harvest_id_label.Size = new System.Drawing.Size(74, 17);
            this.harvest_id_label.TabIndex = 48;
            this.harvest_id_label.Text = "Harvest ID";
            // 
            // harvest_treatment_label
            // 
            this.harvest_treatment_label.AutoSize = true;
            this.harvest_treatment_label.Location = new System.Drawing.Point(600, 72);
            this.harvest_treatment_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.harvest_treatment_label.Name = "harvest_treatment_label";
            this.harvest_treatment_label.Size = new System.Drawing.Size(126, 17);
            this.harvest_treatment_label.TabIndex = 50;
            this.harvest_treatment_label.Text = "Harvest Treatment";
            // 
            // txtHarvestTreat
            // 
            this.txtHarvestTreat.Location = new System.Drawing.Point(600, 91);
            this.txtHarvestTreat.Margin = new System.Windows.Forms.Padding(4);
            this.txtHarvestTreat.Name = "txtHarvestTreat";
            this.txtHarvestTreat.Size = new System.Drawing.Size(164, 22);
            this.txtHarvestTreat.TabIndex = 49;
            // 
            // labour_required
            // 
            this.labour_required.AutoSize = true;
            this.labour_required.Location = new System.Drawing.Point(348, 121);
            this.labour_required.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labour_required.Name = "labour_required";
            this.labour_required.Size = new System.Drawing.Size(115, 17);
            this.labour_required.TabIndex = 54;
            this.labour_required.Text = "Labour Required";
            // 
            // txtLabourRequired
            // 
            this.txtLabourRequired.Location = new System.Drawing.Point(348, 141);
            this.txtLabourRequired.Margin = new System.Windows.Forms.Padding(4);
            this.txtLabourRequired.Name = "txtLabourRequired";
            this.txtLabourRequired.Size = new System.Drawing.Size(164, 22);
            this.txtLabourRequired.TabIndex = 53;
            // 
            // time_needed
            // 
            this.time_needed.AutoSize = true;
            this.time_needed.Location = new System.Drawing.Point(860, 72);
            this.time_needed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time_needed.Name = "time_needed";
            this.time_needed.Size = new System.Drawing.Size(93, 17);
            this.time_needed.TabIndex = 52;
            this.time_needed.Text = "Time Needed";
            // 
            // txtTimeNeed
            // 
            this.txtTimeNeed.Location = new System.Drawing.Point(860, 91);
            this.txtTimeNeed.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeNeed.Name = "txtTimeNeed";
            this.txtTimeNeed.Size = new System.Drawing.Size(164, 22);
            this.txtTimeNeed.TabIndex = 51;
            // 
            // labourers_required
            // 
            this.labourers_required.AutoSize = true;
            this.labourers_required.Location = new System.Drawing.Point(600, 121);
            this.labourers_required.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labourers_required.Name = "labourers_required";
            this.labourers_required.Size = new System.Drawing.Size(135, 17);
            this.labourers_required.TabIndex = 56;
            this.labourers_required.Text = "Labourers Required";
            // 
            // txtLabourersRequired
            // 
            this.txtLabourersRequired.Location = new System.Drawing.Point(600, 141);
            this.txtLabourersRequired.Margin = new System.Windows.Forms.Padding(4);
            this.txtLabourersRequired.Name = "txtLabourersRequired";
            this.txtLabourersRequired.Size = new System.Drawing.Size(164, 22);
            this.txtLabourersRequired.TabIndex = 55;
            // 
            // harvest_expected
            // 
            this.harvest_expected.AutoSize = true;
            this.harvest_expected.Location = new System.Drawing.Point(860, 121);
            this.harvest_expected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.harvest_expected.Name = "harvest_expected";
            this.harvest_expected.Size = new System.Drawing.Size(160, 17);
            this.harvest_expected.TabIndex = 58;
            this.harvest_expected.Text = "When Harvest Expected";
            // 
            // txtHarvExpect
            // 
            this.txtHarvExpect.Location = new System.Drawing.Point(860, 141);
            this.txtHarvExpect.Margin = new System.Windows.Forms.Padding(4);
            this.txtHarvExpect.Name = "txtHarvExpect";
            this.txtHarvExpect.Size = new System.Drawing.Size(164, 22);
            this.txtHarvExpect.TabIndex = 57;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.panel3.Controls.Add(this.lbName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lbRank);
            this.panel3.Location = new System.Drawing.Point(301, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 68);
            this.panel3.TabIndex = 59;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(197, 20);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(130, 25);
            this.lbName.TabIndex = 62;
            this.lbName.Text = "[Name data]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "Logged in as: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(508, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 61;
            this.label3.Text = "Rank:";
            // 
            // lbRank
            // 
            this.lbRank.AutoSize = true;
            this.lbRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRank.ForeColor = System.Drawing.Color.White;
            this.lbRank.Location = new System.Drawing.Point(584, 20);
            this.lbRank.Name = "lbRank";
            this.lbRank.Size = new System.Drawing.Size(126, 25);
            this.lbRank.TabIndex = 63;
            this.lbRank.Text = "[Rank Data]";
            // 
            // btnManagerHavTime
            // 
            this.btnManagerHavTime.Location = new System.Drawing.Point(738, 560);
            this.btnManagerHavTime.Name = "btnManagerHavTime";
            this.btnManagerHavTime.Size = new System.Drawing.Size(286, 46);
            this.btnManagerHavTime.TabIndex = 60;
            this.btnManagerHavTime.Text = "Manager Timetable overview \r\nLogin Required\r\n";
            this.btnManagerHavTime.UseVisualStyleBackColor = true;
            this.btnManagerHavTime.Click += new System.EventHandler(this.btnManagerHavTime_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(182)))), ((int)(((byte)(242)))));
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(0, 462);
            this.btnViewDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(303, 80);
            this.btnViewDetails.TabIndex = 46;
            this.btnViewDetails.Text = "Preview Info inputted ";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // HarvestTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 613);
            this.Controls.Add(this.btnManagerHavTime);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.harvest_expected);
            this.Controls.Add(this.txtHarvExpect);
            this.Controls.Add(this.labourers_required);
            this.Controls.Add(this.txtLabourersRequired);
            this.Controls.Add(this.labour_required);
            this.Controls.Add(this.txtLabourRequired);
            this.Controls.Add(this.time_needed);
            this.Controls.Add(this.txtTimeNeed);
            this.Controls.Add(this.harvest_treatment_label);
            this.Controls.Add(this.txtHarvestTreat);
            this.Controls.Add(this.harvest_id_label);
            this.Controls.Add(this.txtHarvestID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HarvestTimetable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HarvestTimetable";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpHarvest;
        private System.Windows.Forms.TextBox HarvestTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtHarvestID;
        private System.Windows.Forms.Label harvest_id_label;
        private System.Windows.Forms.Label harvest_treatment_label;
        private System.Windows.Forms.TextBox txtHarvestTreat;
        private System.Windows.Forms.Label labour_required;
        private System.Windows.Forms.TextBox txtLabourRequired;
        private System.Windows.Forms.Label time_needed;
        private System.Windows.Forms.TextBox txtTimeNeed;
        private System.Windows.Forms.Label labourers_required;
        private System.Windows.Forms.TextBox txtLabourersRequired;
        private System.Windows.Forms.Label harvest_expected;
        private System.Windows.Forms.TextBox txtHarvExpect;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRank;
        private System.Windows.Forms.Button btnManagerHavTime;
        private System.Windows.Forms.Button btnViewDetails;
    }
}