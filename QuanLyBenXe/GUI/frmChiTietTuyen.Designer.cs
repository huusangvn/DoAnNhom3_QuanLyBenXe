
namespace GUI
{
    partial class frmChiTietTuyen
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
            this.dtgvChiTietVe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietVe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvChiTietVe
            // 
            this.dtgvChiTietVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietVe.Location = new System.Drawing.Point(0, 0);
            this.dtgvChiTietVe.Name = "dtgvChiTietVe";
            this.dtgvChiTietVe.RowHeadersWidth = 51;
            this.dtgvChiTietVe.RowTemplate.Height = 24;
            this.dtgvChiTietVe.Size = new System.Drawing.Size(799, 313);
            this.dtgvChiTietVe.TabIndex = 0;
            // 
            // frmChiTietTuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvChiTietVe);
            this.Name = "frmChiTietTuyen";
            this.Text = "frmChiTietTuyen";
            this.Load += new System.EventHandler(this.frmChiTietTuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietVe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvChiTietVe;
    }
}