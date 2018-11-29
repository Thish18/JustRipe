namespace JustRipeProjectOfficial
{
    partial class LabourManagementTimetable
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
            this.dgvTimeTable = new System.Windows.Forms.DataGridView();
            this.btnHarvTimetbale = new System.Windows.Forms.Button();
            this.btnHarvTimetable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTimeTable
            // 
            this.dgvTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeTable.Location = new System.Drawing.Point(12, 11);
            this.dgvTimeTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTimeTable.Name = "dgvTimeTable";
            this.dgvTimeTable.RowTemplate.Height = 24;
            this.dgvTimeTable.Size = new System.Drawing.Size(565, 331);
            this.dgvTimeTable.TabIndex = 1;
            // 
            // btnHarvTimetbale
            // 
            this.btnHarvTimetbale.Location = new System.Drawing.Point(412, 346);
            this.btnHarvTimetbale.Name = "btnHarvTimetbale";
            this.btnHarvTimetbale.Size = new System.Drawing.Size(166, 37);
            this.btnHarvTimetbale.TabIndex = 4;
            this.btnHarvTimetbale.Text = "Back to Main Menu";
            this.btnHarvTimetbale.UseVisualStyleBackColor = true;
            this.btnHarvTimetbale.Click += new System.EventHandler(this.btnHarvTimetbale_Click);
            // 
            // btnHarvTimetable
            // 
            this.btnHarvTimetable.Location = new System.Drawing.Point(271, 347);
            this.btnHarvTimetable.Name = "btnHarvTimetable";
            this.btnHarvTimetable.Size = new System.Drawing.Size(135, 37);
            this.btnHarvTimetable.TabIndex = 3;
            this.btnHarvTimetable.Text = "Open Timetable";
            this.btnHarvTimetable.UseVisualStyleBackColor = true;
            this.btnHarvTimetable.Click += new System.EventHandler(this.btnHarvTimetable_Click);
            // 
            // LabourManagementTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 393);
            this.Controls.Add(this.btnHarvTimetbale);
            this.Controls.Add(this.btnHarvTimetable);
            this.Controls.Add(this.dgvTimeTable);
            this.Name = "LabourManagementTimetable";
            this.Text = "LabourManagementTimetable";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimeTable;
        private System.Windows.Forms.Button btnHarvTimetbale;
        private System.Windows.Forms.Button btnHarvTimetable;
    }
}