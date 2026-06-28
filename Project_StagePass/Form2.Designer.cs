namespace Project_StagePass
{
    partial class Form2
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
            this.lblComingSoon = new System.Windows.Forms.Label();
            this.btnBackUC = new System.Windows.Forms.Button();
            this.flpconcert = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblComingSoon
            // 
            this.lblComingSoon.AutoSize = true;
            this.lblComingSoon.Font = new System.Drawing.Font("Britannic Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComingSoon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblComingSoon.Location = new System.Drawing.Point(42, 57);
            this.lblComingSoon.Name = "lblComingSoon";
            this.lblComingSoon.Size = new System.Drawing.Size(137, 21);
            this.lblComingSoon.TabIndex = 15;
            this.lblComingSoon.Text = "COMING SOON..";
            this.lblComingSoon.Click += new System.EventHandler(this.lblComingSoon_Click);
            // 
            // btnBackUC
            // 
            this.btnBackUC.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnBackUC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBackUC.Location = new System.Drawing.Point(46, 18);
            this.btnBackUC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackUC.Name = "btnBackUC";
            this.btnBackUC.Size = new System.Drawing.Size(104, 25);
            this.btnBackUC.TabIndex = 19;
            this.btnBackUC.Text = "< Back";
            this.btnBackUC.UseVisualStyleBackColor = false;
            this.btnBackUC.Click += new System.EventHandler(this.btnBackUC_Click);
            // 
            // flpconcert
            // 
            this.flpconcert.AutoScroll = true;
            this.flpconcert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpconcert.Location = new System.Drawing.Point(0, 81);
            this.flpconcert.Name = "flpconcert";
            this.flpconcert.Size = new System.Drawing.Size(1041, 485);
            this.flpconcert.TabIndex = 20;
            this.flpconcert.Paint += new System.Windows.Forms.PaintEventHandler(this.flpconcert_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1041, 566);
            this.Controls.Add(this.flpconcert);
            this.Controls.Add(this.btnBackUC);
            this.Controls.Add(this.lblComingSoon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Upcoming Consert";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblComingSoon;
        private System.Windows.Forms.Button btnBackUC;
        private System.Windows.Forms.FlowLayoutPanel flpconcert;
    }
}