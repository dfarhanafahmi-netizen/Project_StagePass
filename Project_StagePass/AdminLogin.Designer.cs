namespace Project_StagePass
{
    partial class AdminLogin
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
            this.txtbxusername = new System.Windows.Forms.TextBox();
            this.txtbxpassword = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnloginadmin = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxusername
            // 
            this.txtbxusername.Location = new System.Drawing.Point(165, 82);
            this.txtbxusername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxusername.Name = "txtbxusername";
            this.txtbxusername.Size = new System.Drawing.Size(184, 22);
            this.txtbxusername.TabIndex = 0;
            // 
            // txtbxpassword
            // 
            this.txtbxpassword.Location = new System.Drawing.Point(165, 124);
            this.txtbxpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxpassword.Name = "txtbxpassword";
            this.txtbxpassword.Size = new System.Drawing.Size(184, 22);
            this.txtbxpassword.TabIndex = 1;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblusername.Location = new System.Drawing.Point(51, 84);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(92, 23);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(51, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnloginadmin
            // 
            this.btnloginadmin.BackColor = System.Drawing.SystemColors.Info;
            this.btnloginadmin.Location = new System.Drawing.Point(54, 206);
            this.btnloginadmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnloginadmin.Name = "btnloginadmin";
            this.btnloginadmin.Size = new System.Drawing.Size(124, 42);
            this.btnloginadmin.TabIndex = 4;
            this.btnloginadmin.Text = "Login";
            this.btnloginadmin.UseVisualStyleBackColor = false;
            this.btnloginadmin.Click += new System.EventHandler(this.buttonloginadmin_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Firebrick;
            this.btncancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncancel.Location = new System.Drawing.Point(266, 206);
            this.btncancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(124, 42);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnloginadmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtbxpassword);
            this.Controls.Add(this.txtbxusername);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxusername;
        private System.Windows.Forms.TextBox txtbxpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnloginadmin;
        private System.Windows.Forms.Button btncancel;
    }
}