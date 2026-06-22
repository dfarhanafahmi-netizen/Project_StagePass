using System.Windows.Forms;
namespace Project_StagePass
{
    public partial class receipt : Form
    {
       
        private System.ComponentModel.IContainer components = null;

       
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
            this.lblstagepasspayment = new System.Windows.Forms.Label();
            this.lblthankyou = new System.Windows.Forms.Label();
            this.lblcustdetails = new System.Windows.Forms.Label();
            this.lblline2 = new System.Windows.Forms.Label();
            this.lblreceipt = new System.Windows.Forms.Label();
            this.lblline1 = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.lbltaxamount = new System.Windows.Forms.Label();
            this.lbltaxrate = new System.Windows.Forms.Label();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.lblpaymentmethod = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblcustname = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbleventname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labeleventname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNoofTicket = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblstagepasspayment
            // 
            this.lblstagepasspayment.AutoSize = true;
            this.lblstagepasspayment.Font = new System.Drawing.Font("Matura MT Script Capitals", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstagepasspayment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblstagepasspayment.Location = new System.Drawing.Point(774, 9);
            this.lblstagepasspayment.Name = "lblstagepasspayment";
            this.lblstagepasspayment.Size = new System.Drawing.Size(199, 42);
            this.lblstagepasspayment.TabIndex = 0;
            this.lblstagepasspayment.Text = "Stage Pass";
            // 
            // lblthankyou
            // 
            this.lblthankyou.AutoSize = true;
            this.lblthankyou.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthankyou.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblthankyou.Location = new System.Drawing.Point(135, 452);
            this.lblthankyou.Name = "lblthankyou";
            this.lblthankyou.Size = new System.Drawing.Size(729, 44);
            this.lblthankyou.TabIndex = 13;
            this.lblthankyou.Text = "THANK YOU FOR TRUSTING OUR BUSINESS !!";
            // 
            // lblcustdetails
            // 
            this.lblcustdetails.AutoSize = true;
            this.lblcustdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustdetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcustdetails.Location = new System.Drawing.Point(29, 288);
            this.lblcustdetails.Name = "lblcustdetails";
            this.lblcustdetails.Size = new System.Drawing.Size(163, 22);
            this.lblcustdetails.TabIndex = 14;
            this.lblcustdetails.Text = "Customer Details";
            // 
            // lblline2
            // 
            this.lblline2.AutoSize = true;
            this.lblline2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblline2.Location = new System.Drawing.Point(29, 310);
            this.lblline2.Name = "lblline2";
            this.lblline2.Size = new System.Drawing.Size(909, 20);
            this.lblline2.TabIndex = 15;
            this.lblline2.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-------------------";
            // 
            // lblreceipt
            // 
            this.lblreceipt.AutoSize = true;
            this.lblreceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreceipt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblreceipt.Location = new System.Drawing.Point(29, 115);
            this.lblreceipt.Name = "lblreceipt";
            this.lblreceipt.Size = new System.Drawing.Size(78, 22);
            this.lblreceipt.TabIndex = 16;
            this.lblreceipt.Text = "Receipt";
            // 
            // lblline1
            // 
            this.lblline1.AutoSize = true;
            this.lblline1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblline1.Location = new System.Drawing.Point(29, 137);
            this.lblline1.Name = "lblline1";
            this.lblline1.Size = new System.Drawing.Size(909, 20);
            this.lblline1.TabIndex = 17;
            this.lblline1.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-------------------";
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.Location = new System.Drawing.Point(777, 261);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(34, 20);
            this.lbltotalamount.TabIndex = 49;
            this.lbltotalamount.Text = "RM";
            // 
            // lbltaxamount
            // 
            this.lbltaxamount.AutoSize = true;
            this.lbltaxamount.Location = new System.Drawing.Point(770, 224);
            this.lbltaxamount.Name = "lbltaxamount";
            this.lbltaxamount.Size = new System.Drawing.Size(0, 20);
            this.lbltaxamount.TabIndex = 38;
            // 
            // lbltaxrate
            // 
            this.lbltaxrate.AutoSize = true;
            this.lbltaxrate.Location = new System.Drawing.Point(770, 224);
            this.lbltaxrate.Name = "lbltaxrate";
            this.lbltaxrate.Size = new System.Drawing.Size(45, 20);
            this.lbltaxrate.TabIndex = 37;
            this.lbltaxrate.Text = "         ";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Location = new System.Drawing.Point(755, 157);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(21, 20);
            this.lblsubtotal.TabIndex = 36;
            this.lblsubtotal.Text = "   ";
            // 
            // lblpaymentmethod
            // 
            this.lblpaymentmethod.AutoSize = true;
            this.lblpaymentmethod.Location = new System.Drawing.Point(176, 432);
            this.lblpaymentmethod.Name = "lblpaymentmethod";
            this.lblpaymentmethod.Size = new System.Drawing.Size(0, 20);
            this.lblpaymentmethod.TabIndex = 34;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(87, 367);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(137, 20);
            this.lblemail.TabIndex = 32;
            this.lblemail.Text = "                                ";
            // 
            // lblcustname
            // 
            this.lblcustname.AutoSize = true;
            this.lblcustname.Location = new System.Drawing.Point(107, 330);
            this.lblcustname.Name = "lblcustname";
            this.lblcustname.Size = new System.Drawing.Size(0, 20);
            this.lblcustname.TabIndex = 31;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(87, 224);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 20);
            this.lbltime.TabIndex = 30;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(87, 191);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(13, 20);
            this.lbldate.TabIndex = 29;
            this.lbldate.Text = " ";
            // 
            // lbleventname
            // 
            this.lbleventname.AutoSize = true;
            this.lbleventname.Location = new System.Drawing.Point(139, 157);
            this.lbleventname.Name = "lbleventname";
            this.lbleventname.Size = new System.Drawing.Size(17, 20);
            this.lbleventname.TabIndex = 28;
            this.lbleventname.Text = "  ";
            this.lbleventname.Click += new System.EventHandler(this.lbleventname_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 44);
            this.label1.TabIndex = 26;
            this.label1.Text = "EVENT TICKET RECEIPT";
            // 
            // labeleventname
            // 
            this.labeleventname.AutoSize = true;
            this.labeleventname.Location = new System.Drawing.Point(29, 157);
            this.labeleventname.Name = "labeleventname";
            this.labeleventname.Size = new System.Drawing.Size(104, 20);
            this.labeleventname.TabIndex = 50;
            this.labeleventname.Text = "Event Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Time :  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Sub Total :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(664, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Tax Amount : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Total Amount :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "Email :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 20);
            this.label10.TabIndex = 59;
            this.label10.Text = "Payment Method : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(664, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 60;
            this.label11.Text = "Tax Rate : 6% ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 61;
            this.label9.Text = "No of Ticket :";
            // 
            // lblNoofTicket
            // 
            this.lblNoofTicket.AutoSize = true;
            this.lblNoofTicket.Location = new System.Drawing.Point(136, 402);
            this.lblNoofTicket.Name = "lblNoofTicket";
            this.lblNoofTicket.Size = new System.Drawing.Size(0, 20);
            this.lblNoofTicket.TabIndex = 62;
            // 
            // receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(985, 538);
            this.Controls.Add(this.lblNoofTicket);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labeleventname);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.lbltaxamount);
            this.Controls.Add(this.lbltaxrate);
            this.Controls.Add(this.lblsubtotal);
            this.Controls.Add(this.lblpaymentmethod);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblcustname);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lbleventname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblline1);
            this.Controls.Add(this.lblreceipt);
            this.Controls.Add(this.lblline2);
            this.Controls.Add(this.lblcustdetails);
            this.Controls.Add(this.lblthankyou);
            this.Controls.Add(this.lblstagepasspayment);
            this.Name = "receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstagepasspayment;
        private System.Windows.Forms.Label lblthankyou;
        private System.Windows.Forms.Label lblcustdetails;
        private System.Windows.Forms.Label lblline2;
        private System.Windows.Forms.Label lblreceipt;
        private System.Windows.Forms.Label lblline1;
        private Label lbltotalamount;
        private Label lbltaxamount;
        private Label lbltaxrate;
        private Label lblsubtotal;
        private Label lblpaymentmethod;
        private Label lblemail;
        private Label lblcustname;
        private Label lbltime;
        private Label lbldate;
        private Label lbleventname;
        private Label label1;
        private Label labeleventname;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label9;
        private Label lblNoofTicket;
    }
}