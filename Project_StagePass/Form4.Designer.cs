namespace Project_StagePass
{
    partial class PaymentMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentMethod));
            this.cbTerms = new System.Windows.Forms.CheckBox();
            this.gbPayment = new System.Windows.Forms.GroupBox();
            this.picbxtng = new System.Windows.Forms.PictureBox();
            this.picbxvisa = new System.Windows.Forms.PictureBox();
            this.picbxfpx = new System.Windows.Forms.PictureBox();
            this.rbTNG = new System.Windows.Forms.RadioButton();
            this.rbCARD = new System.Windows.Forms.RadioButton();
            this.rbFPX = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnbuy = new System.Windows.Forms.Button();
            this.gbPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxtng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxvisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxfpx)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTerms
            // 
            this.cbTerms.AutoSize = true;
            this.cbTerms.Location = new System.Drawing.Point(102, 525);
            this.cbTerms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTerms.Name = "cbTerms";
            this.cbTerms.Size = new System.Drawing.Size(523, 24);
            this.cbTerms.TabIndex = 18;
            this.cbTerms.Text = "By clicking this checkbox , you agree with TERMS AND CONDITIONS";
            this.cbTerms.UseVisualStyleBackColor = true;
            this.cbTerms.CheckedChanged += new System.EventHandler(this.cbTerms_CheckedChanged);
            // 
            // gbPayment
            // 
            this.gbPayment.Controls.Add(this.picbxtng);
            this.gbPayment.Controls.Add(this.picbxvisa);
            this.gbPayment.Controls.Add(this.picbxfpx);
            this.gbPayment.Controls.Add(this.rbTNG);
            this.gbPayment.Controls.Add(this.rbCARD);
            this.gbPayment.Controls.Add(this.rbFPX);
            this.gbPayment.Location = new System.Drawing.Point(95, 179);
            this.gbPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPayment.Name = "gbPayment";
            this.gbPayment.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPayment.Size = new System.Drawing.Size(1004, 338);
            this.gbPayment.TabIndex = 16;
            this.gbPayment.TabStop = false;
            this.gbPayment.Text = "PAYMENT METHOD";
            this.gbPayment.Enter += new System.EventHandler(this.gbPayment_Enter);
            // 
            // picbxtng
            // 
            this.picbxtng.Image = ((System.Drawing.Image)(resources.GetObject("picbxtng.Image")));
            this.picbxtng.Location = new System.Drawing.Point(7, 214);
            this.picbxtng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picbxtng.Name = "picbxtng";
            this.picbxtng.Size = new System.Drawing.Size(257, 101);
            this.picbxtng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxtng.TabIndex = 5;
            this.picbxtng.TabStop = false;
            // 
            // picbxvisa
            // 
            this.picbxvisa.Image = ((System.Drawing.Image)(resources.GetObject("picbxvisa.Image")));
            this.picbxvisa.Location = new System.Drawing.Point(525, 70);
            this.picbxvisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picbxvisa.Name = "picbxvisa";
            this.picbxvisa.Size = new System.Drawing.Size(300, 101);
            this.picbxvisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxvisa.TabIndex = 4;
            this.picbxvisa.TabStop = false;
            // 
            // picbxfpx
            // 
            this.picbxfpx.Image = ((System.Drawing.Image)(resources.GetObject("picbxfpx.Image")));
            this.picbxfpx.Location = new System.Drawing.Point(7, 70);
            this.picbxfpx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picbxfpx.Name = "picbxfpx";
            this.picbxfpx.Size = new System.Drawing.Size(257, 101);
            this.picbxfpx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxfpx.TabIndex = 3;
            this.picbxfpx.TabStop = false;
            // 
            // rbTNG
            // 
            this.rbTNG.AutoSize = true;
            this.rbTNG.Location = new System.Drawing.Point(7, 181);
            this.rbTNG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbTNG.Name = "rbTNG";
            this.rbTNG.Size = new System.Drawing.Size(184, 24);
            this.rbTNG.TabIndex = 2;
            this.rbTNG.TabStop = true;
            this.rbTNG.Text = "Touch \'n Go E-Wallet";
            this.rbTNG.UseVisualStyleBackColor = true;
            this.rbTNG.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbCARD
            // 
            this.rbCARD.AutoSize = true;
            this.rbCARD.Location = new System.Drawing.Point(525, 38);
            this.rbCARD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCARD.Name = "rbCARD";
            this.rbCARD.Size = new System.Drawing.Size(254, 24);
            this.rbCARD.TabIndex = 1;
            this.rbCARD.TabStop = true;
            this.rbCARD.Text = "Credit/Debit Card (Visa/Master)";
            this.rbCARD.UseVisualStyleBackColor = true;
            // 
            // rbFPX
            // 
            this.rbFPX.AutoSize = true;
            this.rbFPX.Location = new System.Drawing.Point(7, 38);
            this.rbFPX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFPX.Name = "rbFPX";
            this.rbFPX.Size = new System.Drawing.Size(187, 24);
            this.rbFPX.TabIndex = 0;
            this.rbFPX.TabStop = true;
            this.rbFPX.Text = "FPX Internet Banking";
            this.rbFPX.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 52);
            this.label2.TabIndex = 15;
            this.label2.Text = "SELECT PAYMENT METHOD\r\nChoose your preferred method and click \"PROCEED\'";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(449, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 44);
            this.label3.TabIndex = 14;
            this.label3.Text = "Payment Details";
            // 
            // btnbuy
            // 
            this.btnbuy.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnbuy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnbuy.Location = new System.Drawing.Point(103, 573);
            this.btnbuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(182, 55);
            this.btnbuy.TabIndex = 20;
            this.btnbuy.Text = "BUY";
            this.btnbuy.UseVisualStyleBackColor = false;
            this.btnbuy.Click += new System.EventHandler(this.btnnuy_Click);
            // 
            // PaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1188, 660);
            this.Controls.Add(this.btnbuy);
            this.Controls.Add(this.cbTerms);
            this.Controls.Add(this.gbPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "PaymentMethod";
            this.Text = "Payment Method";
            this.Load += new System.EventHandler(this.PaymentMethod_Load);
            this.gbPayment.ResumeLayout(false);
            this.gbPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxtng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxvisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxfpx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbTerms;
        private System.Windows.Forms.GroupBox gbPayment;
        private System.Windows.Forms.PictureBox picbxtng;
        private System.Windows.Forms.PictureBox picbxvisa;
        private System.Windows.Forms.PictureBox picbxfpx;
        private System.Windows.Forms.RadioButton rbTNG;
        private System.Windows.Forms.RadioButton rbCARD;
        private System.Windows.Forms.RadioButton rbFPX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbuy;
    }
}