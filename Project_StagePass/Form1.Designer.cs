namespace Project_StagePass
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNextHomepage = new System.Windows.Forms.Button();
            this.lblh2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPrevImage = new System.Windows.Forms.Button();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNameArtist = new System.Windows.Forms.Label();
            this.picBxhomepage = new System.Windows.Forms.PictureBox();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBxhomepage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNextHomepage
            // 
            this.btnNextHomepage.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnNextHomepage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNextHomepage.Location = new System.Drawing.Point(975, 569);
            this.btnNextHomepage.Name = "btnNextHomepage";
            this.btnNextHomepage.Size = new System.Drawing.Size(117, 41);
            this.btnNextHomepage.TabIndex = 0;
            this.btnNextHomepage.Text = "Next";
            this.btnNextHomepage.UseVisualStyleBackColor = false;
            this.btnNextHomepage.Click += new System.EventHandler(this.btnNextHomepage_Click);
            // 
            // lblh2
            // 
            this.lblh2.AutoSize = true;
            this.lblh2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblh2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblh2.Location = new System.Drawing.Point(339, 79);
            this.lblh2.Name = "lblh2";
            this.lblh2.Size = new System.Drawing.Size(484, 31);
            this.lblh2.TabIndex = 2;
            this.lblh2.Text = "Your Ticket to the Front Row Starts Here.";
            this.lblh2.Click += new System.EventHandler(this.lblh2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "the weeknd1.jpg");
            this.imageList1.Images.SetKeyName(1, "the weeknd2.jpg");
            this.imageList1.Images.SetKeyName(2, "the weeknd3.jpg");
            this.imageList1.Images.SetKeyName(3, "bts1.jpg");
            this.imageList1.Images.SetKeyName(4, "bts2.jpg");
            // 
            // btnPrevImage
            // 
            this.btnPrevImage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPrevImage.Location = new System.Drawing.Point(46, 511);
            this.btnPrevImage.Name = "btnPrevImage";
            this.btnPrevImage.Size = new System.Drawing.Size(66, 41);
            this.btnPrevImage.TabIndex = 4;
            this.btnPrevImage.Text = "<<";
            this.btnPrevImage.UseVisualStyleBackColor = false;
            this.btnPrevImage.Click += new System.EventHandler(this.btnPrevImage_Click);
            // 
            // btnNextImage
            // 
            this.btnNextImage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNextImage.Location = new System.Drawing.Point(1017, 511);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(75, 41);
            this.btnNextImage.TabIndex = 5;
            this.btnNextImage.Text = ">>";
            this.btnNextImage.UseVisualStyleBackColor = false;
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(438, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 63);
            this.label1.TabIndex = 6;
            this.label1.Text = "StagePass";
            // 
            // lblNameArtist
            // 
            this.lblNameArtist.AutoSize = true;
            this.lblNameArtist.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameArtist.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNameArtist.Location = new System.Drawing.Point(547, 511);
            this.lblNameArtist.Name = "lblNameArtist";
            this.lblNameArtist.Size = new System.Drawing.Size(57, 25);
            this.lblNameArtist.TabIndex = 7;
            this.lblNameArtist.Text = "BTS";
            // 
            // picBxhomepage
            // 
            this.picBxhomepage.Image = global::Project_StagePass.Properties.Resources.bts2;
            this.picBxhomepage.Location = new System.Drawing.Point(266, 137);
            this.picBxhomepage.Name = "picBxhomepage";
            this.picBxhomepage.Size = new System.Drawing.Size(639, 345);
            this.picBxhomepage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxhomepage.TabIndex = 3;
            this.picBxhomepage.TabStop = false;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Indigo;
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnback.Location = new System.Drawing.Point(34, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(117, 41);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1164, 663);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblNameArtist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNextImage);
            this.Controls.Add(this.btnPrevImage);
            this.Controls.Add(this.picBxhomepage);
            this.Controls.Add(this.lblh2);
            this.Controls.Add(this.btnNextHomepage);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBxhomepage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNextHomepage;
        private System.Windows.Forms.Label lblh2;
        private System.Windows.Forms.PictureBox picBxhomepage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnPrevImage;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNameArtist;
        private System.Windows.Forms.Button btnback;
    }
}

