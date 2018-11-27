namespace JustRipeProjectOfficial
{
    partial class ManagerHarvestTimetable
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
            this.dgvHarvestMethod = new System.Windows.Forms.DataGridView();
            this.btnHarvTimetable = new System.Windows.Forms.Button();
            this.btnHarvTimetbale = new System.Windows.Forms.Button();
            this.dgvHarvest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHarvestMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHarvest)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHarvestMethod
            // 
            this.dgvHarvestMethod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHarvestMethod.Location = new System.Drawing.Point(12, 12);
            this.dgvHarvestMethod.Name = "dgvHarvestMethod";
            this.dgvHarvestMethod.RowTemplate.Height = 24;
            this.dgvHarvestMethod.Size = new System.Drawing.Size(601, 192);
            this.dgvHarvestMethod.TabIndex = 0;
            // 
            // btnHarvTimetable
            // 
            this.btnHarvTimetable.Location = new System.Drawing.Point(306, 406);
            this.btnHarvTimetable.Name = "btnHarvTimetable";
            this.btnHarvTimetable.Size = new System.Drawing.Size(135, 37);
            this.btnHarvTimetable.TabIndex = 1;
            this.btnHarvTimetable.Text = "Open Timetable";
            this.btnHarvTimetable.UseVisualStyleBackColor = true;
            this.btnHarvTimetable.Click += new System.EventHandler(this.btnHarvTimetable_Click);
            // 
            // btnHarvTimetbale
            // 
            this.btnHarvTimetbale.Location = new System.Drawing.Point(447, 405);
            this.btnHarvTimetbale.Name = "btnHarvTimetbale";
            this.btnHarvTimetbale.Size = new System.Drawing.Size(166, 37);
            this.btnHarvTimetbale.TabIndex = 2;
            this.btnHarvTimetbale.Text = "Back to Main Menu";
            this.btnHarvTimetbale.UseVisualStyleBackColor = true;
            this.btnHarvTimetbale.Click += new System.EventHandler(this.btnHarvTimetbale_Click);
            // 
            // dgvHarvest
            // 
            this.dgvHarvest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHarvest.Location = new System.Drawing.Point(12, 210);
            this.dgvHarvest.Name = "dgvHarvest";
            this.dgvHarvest.RowTemplate.Height = 24;
            this.dgvHarvest.Size = new System.Drawing.Size(601, 192);
            this.dgvHarvest.TabIndex = 3;
            // 
            // ManagerHarvestTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.dgvHarvest);
            this.Controls.Add(this.btnHarvTimetbale);
            this.Controls.Add(this.btnHarvTimetable);
            this.Controls.Add(this.dgvHarvestMethod);
            this.Name = "ManagerHarvestTimetable";
            this.Text = "ManagerHarvestTimetable";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHarvestMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHarvest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHarvestMethod;
        private System.Windows.Forms.Button btnHarvTimetable;
        private System.Windows.Forms.Button btnHarvTimetbale;
        private System.Windows.Forms.DataGridView dgvHarvest;
    }
}