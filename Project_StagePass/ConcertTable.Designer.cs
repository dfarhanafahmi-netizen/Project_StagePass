namespace Project_StagePass
{
    partial class ConcertTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvConcerts = new System.Windows.Forms.DataGridView();
            this.gpbxconcert = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtptime = new System.Windows.Forms.DateTimePicker();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.txtbxtourname = new System.Windows.Forms.TextBox();
            this.txtbxartistname = new System.Windows.Forms.TextBox();
            this.txtbxconcertid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPosterUpload = new System.Windows.Forms.PictureBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcerts)).BeginInit();
            this.gpbxconcert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosterUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConcerts
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConcerts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvConcerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConcerts.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvConcerts.Location = new System.Drawing.Point(66, 31);
            this.dgvConcerts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConcerts.Name = "dgvConcerts";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConcerts.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvConcerts.RowHeadersWidth = 51;
            this.dgvConcerts.RowTemplate.Height = 24;
            this.dgvConcerts.Size = new System.Drawing.Size(695, 174);
            this.dgvConcerts.TabIndex = 0;
            this.dgvConcerts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConcerts_CellClick);
            this.dgvConcerts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConcerts_CellContentClick);
            // 
            // gpbxconcert
            // 
            this.gpbxconcert.Controls.Add(this.btnBrowseImage);
            this.gpbxconcert.Controls.Add(this.pbPosterUpload);
            this.gpbxconcert.Controls.Add(this.btnDelete);
            this.gpbxconcert.Controls.Add(this.btnupdate);
            this.gpbxconcert.Controls.Add(this.btnAdd);
            this.gpbxconcert.Controls.Add(this.dtptime);
            this.gpbxconcert.Controls.Add(this.dtpdate);
            this.gpbxconcert.Controls.Add(this.txtbxtourname);
            this.gpbxconcert.Controls.Add(this.txtbxartistname);
            this.gpbxconcert.Controls.Add(this.txtbxconcertid);
            this.gpbxconcert.Controls.Add(this.label6);
            this.gpbxconcert.Controls.Add(this.label5);
            this.gpbxconcert.Controls.Add(this.label4);
            this.gpbxconcert.Controls.Add(this.label3);
            this.gpbxconcert.Controls.Add(this.label2);
            this.gpbxconcert.Controls.Add(this.dgvConcerts);
            this.gpbxconcert.Location = new System.Drawing.Point(32, 72);
            this.gpbxconcert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbxconcert.Name = "gpbxconcert";
            this.gpbxconcert.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbxconcert.Size = new System.Drawing.Size(938, 447);
            this.gpbxconcert.TabIndex = 3;
            this.gpbxconcert.TabStop = false;
            this.gpbxconcert.Text = "Concert Ticket";
            this.gpbxconcert.Enter += new System.EventHandler(this.gpbxconcert_Enter);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(639, 224);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 39);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(491, 224);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(122, 39);
            this.btnupdate.TabIndex = 12;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(337, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 39);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtptime
            // 
            this.dtptime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtptime.Location = new System.Drawing.Point(174, 333);
            this.dtptime.Name = "dtptime";
            this.dtptime.Size = new System.Drawing.Size(130, 22);
            this.dtptime.TabIndex = 10;
            this.dtptime.ValueChanged += new System.EventHandler(this.dtptime_ValueChanged);
            // 
            // dtpdate
            // 
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(174, 301);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(130, 22);
            this.dtpdate.TabIndex = 9;
            this.dtpdate.ValueChanged += new System.EventHandler(this.dtpdate_ValueChanged);
            // 
            // txtbxtourname
            // 
            this.txtbxtourname.Location = new System.Drawing.Point(174, 272);
            this.txtbxtourname.Name = "txtbxtourname";
            this.txtbxtourname.Size = new System.Drawing.Size(130, 22);
            this.txtbxtourname.TabIndex = 8;
            this.txtbxtourname.TextChanged += new System.EventHandler(this.txtbxtourname_TextChanged);
            // 
            // txtbxartistname
            // 
            this.txtbxartistname.Location = new System.Drawing.Point(174, 244);
            this.txtbxartistname.Name = "txtbxartistname";
            this.txtbxartistname.Size = new System.Drawing.Size(130, 22);
            this.txtbxartistname.TabIndex = 7;
            this.txtbxartistname.TextChanged += new System.EventHandler(this.txtbxartistname_TextChanged);
            // 
            // txtbxconcertid
            // 
            this.txtbxconcertid.Location = new System.Drawing.Point(174, 216);
            this.txtbxconcertid.Name = "txtbxconcertid";
            this.txtbxconcertid.Size = new System.Drawing.Size(130, 22);
            this.txtbxconcertid.TabIndex = 6;
            this.txtbxconcertid.TextChanged += new System.EventHandler(this.txtbxconcertid_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Concert Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Concert Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tour Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Artist Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Concert ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin Management";
            // 
            // pbPosterUpload
            // 
            this.pbPosterUpload.Location = new System.Drawing.Point(337, 269);
            this.pbPosterUpload.Name = "pbPosterUpload";
            this.pbPosterUpload.Size = new System.Drawing.Size(216, 118);
            this.pbPosterUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPosterUpload.TabIndex = 14;
            this.pbPosterUpload.TabStop = false;
            this.pbPosterUpload.Click += new System.EventHandler(this.pbPosterUpload_Click);
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(568, 361);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(147, 26);
            this.btnBrowseImage.TabIndex = 15;
            this.btnBrowseImage.Text = "Browse Image...";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // ConcertTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbxconcert);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConcertTable";
            this.Text = "Concert Database";
            this.Load += new System.EventHandler(this.ConcertTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcerts)).EndInit();
            this.gpbxconcert.ResumeLayout(false);
            this.gpbxconcert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosterUpload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvConcerts;
        private System.Windows.Forms.GroupBox gpbxconcert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.TextBox txtbxtourname;
        private System.Windows.Forms.TextBox txtbxartistname;
        private System.Windows.Forms.TextBox txtbxconcertid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtptime;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.PictureBox pbPosterUpload;
    }
}