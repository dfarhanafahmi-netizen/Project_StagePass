namespace Project_StagePass
{
    partial class TermsNCondition
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
            this.txtbxtnc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbxtnc
            // 
            this.txtbxtnc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxtnc.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtbxtnc.Location = new System.Drawing.Point(0, 0);
            this.txtbxtnc.Multiline = true;
            this.txtbxtnc.Name = "txtbxtnc";
            this.txtbxtnc.ReadOnly = true;
            this.txtbxtnc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxtnc.Size = new System.Drawing.Size(800, 450);
            this.txtbxtnc.TabIndex = 0;
            this.txtbxtnc.TextChanged += new System.EventHandler(this.txtbxtnc_TextChanged);
            // 
            // TermsNCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbxtnc);
            this.Name = "TermsNCondition";
            this.Text = "TermsNCondition";
            this.Load += new System.EventHandler(this.TermsNCondition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxtnc;
    }
}