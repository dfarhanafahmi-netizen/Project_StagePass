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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcerts)).BeginInit();
            this.gpbxconcert.SuspendLayout();
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
            this.dgvConcerts.Location = new System.Drawing.Point(74, 39);
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
            this.dgvConcerts.Size = new System.Drawing.Size(1148, 295);
            this.dgvConcerts.TabIndex = 0;
            this.dgvConcerts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConcerts_CellClick);
            this.dgvConcerts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConcerts_CellContentClick);
            // 
            // gpbxconcert
            // 
            this.gpbxconcert.Controls.Add(this.dgvConcerts);
            this.gpbxconcert.Location = new System.Drawing.Point(36, 90);
            this.gpbxconcert.Name = "gpbxconcert";
            this.gpbxconcert.Size = new System.Drawing.Size(1289, 385);
            this.gpbxconcert.TabIndex = 3;
            this.gpbxconcert.TabStop = false;
            this.gpbxconcert.Text = "Concert Ticket";
            this.gpbxconcert.Enter += new System.EventHandler(this.gpbxconcert_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin Management";
            // 
            // ConcertTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 663);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbxconcert);
            this.Name = "ConcertTable";
            this.Text = "Concert Database";
            this.Load += new System.EventHandler(this.ConcertTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcerts)).EndInit();
            this.gpbxconcert.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvConcerts;
        private System.Windows.Forms.GroupBox gpbxconcert;
        private System.Windows.Forms.Label label1;
    }
}