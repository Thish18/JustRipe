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
            this.dgvHarvestMethod.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.dgvHarvestMethod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHarvestMethod.Location = new System.Drawing.Point(9, 10);
            this.dgvHarvestMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHarvestMethod.Name = "dgvHarvestMethod";
            this.dgvHarvestMethod.RowTemplate.Height = 24;
            this.dgvHarvestMethod.Size = new System.Drawing.Size(499, 185);
            this.dgvHarvestMethod.TabIndex = 0;
            // 
            // btnHarvTimetable
            // 
            this.btnHarvTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(182)))), ((int)(((byte)(242)))));
            this.btnHarvTimetable.FlatAppearance.BorderSize = 0;
            this.btnHarvTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHarvTimetable.ForeColor = System.Drawing.Color.White;
            this.btnHarvTimetable.Location = new System.Drawing.Point(279, 418);
            this.btnHarvTimetable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHarvTimetable.Name = "btnHarvTimetable";
            this.btnHarvTimetable.Size = new System.Drawing.Size(101, 30);
            this.btnHarvTimetable.TabIndex = 1;
            this.btnHarvTimetable.Text = "Open Timetable";
            this.btnHarvTimetable.UseVisualStyleBackColor = false;
            this.btnHarvTimetable.Click += new System.EventHandler(this.btnHarvTimetable_Click);
            // 
            // btnHarvTimetbale
            // 
            this.btnHarvTimetbale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(182)))), ((int)(((byte)(242)))));
            this.btnHarvTimetbale.FlatAppearance.BorderSize = 0;
            this.btnHarvTimetbale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHarvTimetbale.ForeColor = System.Drawing.Color.White;
            this.btnHarvTimetbale.Location = new System.Drawing.Point(384, 418);
            this.btnHarvTimetbale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHarvTimetbale.Name = "btnHarvTimetbale";
            this.btnHarvTimetbale.Size = new System.Drawing.Size(124, 30);
            this.btnHarvTimetbale.TabIndex = 2;
            this.btnHarvTimetbale.Text = "Back to Main Menu";
            this.btnHarvTimetbale.UseVisualStyleBackColor = false;
            this.btnHarvTimetbale.Click += new System.EventHandler(this.btnHarvTimetbale_Click);
            // 
            // dgvHarvest
            // 
            this.dgvHarvest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.dgvHarvest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHarvest.Location = new System.Drawing.Point(9, 199);
            this.dgvHarvest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHarvest.Name = "dgvHarvest";
            this.dgvHarvest.RowTemplate.Height = 24;
            this.dgvHarvest.Size = new System.Drawing.Size(499, 215);
            this.dgvHarvest.TabIndex = 3;
            // 
            // ManagerHarvestTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(519, 459);
            this.Controls.Add(this.dgvHarvest);
            this.Controls.Add(this.btnHarvTimetbale);
            this.Controls.Add(this.btnHarvTimetable);
            this.Controls.Add(this.dgvHarvestMethod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagerHarvestTimetable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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