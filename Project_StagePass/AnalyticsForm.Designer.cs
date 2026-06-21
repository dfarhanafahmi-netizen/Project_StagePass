namespace Project_StagePass
{
    partial class AnalyticsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblanalyticdashboard = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmostpopularpanel = new System.Windows.Forms.Label();
            this.lbltixsold = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblavgorderprice = new System.Windows.Forms.Label();
            this.lbltotaltixsold = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltotalrevenue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnallemails = new System.Windows.Forms.Button();
            this.btnuniqueemail = new System.Windows.Forms.Button();
            this.listBoxUniqueEmail = new System.Windows.Forms.ListBox();
            this.listBoxSearchCustomer = new System.Windows.Forms.ListBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtbxsearchcust = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblemptyorders = new System.Windows.Forms.Label();
            this.btnnext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Revenue ";
            // 
            // lblanalyticdashboard
            // 
            this.lblanalyticdashboard.AutoSize = true;
            this.lblanalyticdashboard.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanalyticdashboard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblanalyticdashboard.Location = new System.Drawing.Point(26, 18);
            this.lblanalyticdashboard.Name = "lblanalyticdashboard";
            this.lblanalyticdashboard.Size = new System.Drawing.Size(285, 37);
            this.lblanalyticdashboard.TabIndex = 17;
            this.lblanalyticdashboard.Text = "Analytics Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total Tickets Sold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 27);
            this.label3.TabIndex = 21;
            this.label3.Text = "Average Order Price";
            // 
            // lblmostpopularpanel
            // 
            this.lblmostpopularpanel.AutoSize = true;
            this.lblmostpopularpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmostpopularpanel.Location = new System.Drawing.Point(536, 175);
            this.lblmostpopularpanel.Name = "lblmostpopularpanel";
            this.lblmostpopularpanel.Size = new System.Drawing.Size(0, 29);
            this.lblmostpopularpanel.TabIndex = 24;
            // 
            // lbltixsold
            // 
            this.lbltixsold.AutoSize = true;
            this.lbltixsold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltixsold.Location = new System.Drawing.Point(900, 175);
            this.lbltixsold.Name = "lbltixsold";
            this.lbltixsold.Size = new System.Drawing.Size(0, 29);
            this.lbltixsold.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblavgorderprice);
            this.groupBox1.Controls.Add(this.lbltotaltixsold);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbltotalrevenue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(33, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 393);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // lblavgorderprice
            // 
            this.lblavgorderprice.AutoSize = true;
            this.lblavgorderprice.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavgorderprice.Location = new System.Drawing.Point(243, 221);
            this.lblavgorderprice.Name = "lblavgorderprice";
            this.lblavgorderprice.Size = new System.Drawing.Size(0, 27);
            this.lblavgorderprice.TabIndex = 24;
            // 
            // lbltotaltixsold
            // 
            this.lbltotaltixsold.AutoSize = true;
            this.lbltotaltixsold.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaltixsold.Location = new System.Drawing.Point(223, 145);
            this.lbltotaltixsold.Name = "lbltotaltixsold";
            this.lbltotaltixsold.Size = new System.Drawing.Size(0, 27);
            this.lbltotaltixsold.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 22;
            // 
            // lbltotalrevenue
            // 
            this.lbltotalrevenue.AutoSize = true;
            this.lbltotalrevenue.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalrevenue.Location = new System.Drawing.Point(208, 65);
            this.lbltotalrevenue.Name = "lbltotalrevenue";
            this.lbltotalrevenue.Size = new System.Drawing.Size(0, 27);
            this.lbltotalrevenue.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 27);
            this.label6.TabIndex = 23;
            this.label6.Text = "Empty Orders Count";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnallemails);
            this.groupBox2.Controls.Add(this.btnuniqueemail);
            this.groupBox2.Controls.Add(this.listBoxUniqueEmail);
            this.groupBox2.Controls.Add(this.listBoxSearchCustomer);
            this.groupBox2.Controls.Add(this.btnsearch);
            this.groupBox2.Controls.Add(this.txtbxsearchcust);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(440, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 560);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detailed Reports & Search";
            // 
            // btnallemails
            // 
            this.btnallemails.BackColor = System.Drawing.Color.Indigo;
            this.btnallemails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnallemails.Location = new System.Drawing.Point(295, 293);
            this.btnallemails.Name = "btnallemails";
            this.btnallemails.Size = new System.Drawing.Size(108, 39);
            this.btnallemails.TabIndex = 28;
            this.btnallemails.Text = "All Emails";
            this.btnallemails.UseVisualStyleBackColor = false;
            this.btnallemails.Click += new System.EventHandler(this.btnallemails_Click);
            // 
            // btnuniqueemail
            // 
            this.btnuniqueemail.BackColor = System.Drawing.Color.Gold;
            this.btnuniqueemail.Location = new System.Drawing.Point(165, 293);
            this.btnuniqueemail.Name = "btnuniqueemail";
            this.btnuniqueemail.Size = new System.Drawing.Size(124, 39);
            this.btnuniqueemail.TabIndex = 27;
            this.btnuniqueemail.Text = "Sort ";
            this.btnuniqueemail.UseVisualStyleBackColor = false;
            this.btnuniqueemail.Click += new System.EventHandler(this.btnuniqueemail_Click);
            // 
            // listBoxUniqueEmail
            // 
            this.listBoxUniqueEmail.FormattingEnabled = true;
            this.listBoxUniqueEmail.ItemHeight = 20;
            this.listBoxUniqueEmail.Location = new System.Drawing.Point(21, 351);
            this.listBoxUniqueEmail.Name = "listBoxUniqueEmail";
            this.listBoxUniqueEmail.Size = new System.Drawing.Size(382, 184);
            this.listBoxUniqueEmail.TabIndex = 26;
            // 
            // listBoxSearchCustomer
            // 
            this.listBoxSearchCustomer.FormattingEnabled = true;
            this.listBoxSearchCustomer.ItemHeight = 20;
            this.listBoxSearchCustomer.Location = new System.Drawing.Point(21, 99);
            this.listBoxSearchCustomer.Name = "listBoxSearchCustomer";
            this.listBoxSearchCustomer.Size = new System.Drawing.Size(382, 164);
            this.listBoxSearchCustomer.TabIndex = 25;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnsearch.Location = new System.Drawing.Point(302, 42);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(101, 51);
            this.btnsearch.TabIndex = 24;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtbxsearchcust
            // 
            this.txtbxsearchcust.Location = new System.Drawing.Point(21, 67);
            this.txtbxsearchcust.Name = "txtbxsearchcust";
            this.txtbxsearchcust.Size = new System.Drawing.Size(262, 26);
            this.txtbxsearchcust.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(198, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 27);
            this.label8.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(267, 27);
            this.label9.TabIndex = 1;
            this.label9.Text = "Search Customer by Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 27);
            this.label10.TabIndex = 19;
            this.label10.Text = " Email List";
            // 
            // lblemptyorders
            // 
            this.lblemptyorders.AutoSize = true;
            this.lblemptyorders.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemptyorders.Location = new System.Drawing.Point(92, 544);
            this.lblemptyorders.Name = "lblemptyorders";
            this.lblemptyorders.Size = new System.Drawing.Size(0, 27);
            this.lblemptyorders.TabIndex = 30;
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.Violet;
            this.btnnext.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.Location = new System.Drawing.Point(946, 600);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(101, 51);
            this.btnnext.TabIndex = 29;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1082, 678);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.lblemptyorders);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbltixsold);
            this.Controls.Add(this.lblmostpopularpanel);
            this.Controls.Add(this.lblanalyticdashboard);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnalyticsForm";
            this.Text = "AnalyticsForm";
            this.Load += new System.EventHandler(this.AnalyticsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblanalyticdashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmostpopularpanel;
        private System.Windows.Forms.Label lbltixsold;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltotalrevenue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnuniqueemail;
        private System.Windows.Forms.ListBox listBoxUniqueEmail;
        private System.Windows.Forms.ListBox listBoxSearchCustomer;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtbxsearchcust;
        private System.Windows.Forms.Button btnallemails;
        private System.Windows.Forms.Label lblavgorderprice;
        private System.Windows.Forms.Label lbltotaltixsold;
        private System.Windows.Forms.Label lblemptyorders;
        private System.Windows.Forms.Button btnnext;
    }
}