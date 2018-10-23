namespace JustRipeProjectOfficial
{
    partial class Fertiliser
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cBRank = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(541, 375);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(187, 28);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back to main menu";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Fertilisers:";
            // 
            // cBRank
            // 
            this.cBRank.FormattingEnabled = true;
            this.cBRank.Items.AddRange(new object[] {
            "[If this shows up database not working]"});
            this.cBRank.Location = new System.Drawing.Point(22, 38);
            this.cBRank.Margin = new System.Windows.Forms.Padding(4);
            this.cBRank.Name = "cBRank";
            this.cBRank.Size = new System.Drawing.Size(192, 24);
            this.cBRank.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(252, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(476, 337);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fertiliser Information";
            // 
            // Fertiliser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(751, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cBRank);
            this.Controls.Add(this.btnBack);
            this.Name = "Fertiliser";
            this.Text = "Fertiliser";
            this.Load += new System.EventHandler(this.Fertiliser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cBRank;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}