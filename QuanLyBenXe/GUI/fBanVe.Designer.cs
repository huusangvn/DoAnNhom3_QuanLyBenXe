
namespace GUI
{
    partial class fBanVe
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
            this.dtgvBanVe = new System.Windows.Forms.DataGridView();
            this.cbBanVe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanVe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvBanVe
            // 
            this.dtgvBanVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBanVe.Location = new System.Drawing.Point(0, 0);
            this.dtgvBanVe.Name = "dtgvBanVe";
            this.dtgvBanVe.RowHeadersWidth = 51;
            this.dtgvBanVe.RowTemplate.Height = 24;
            this.dtgvBanVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBanVe.Size = new System.Drawing.Size(799, 211);
            this.dtgvBanVe.TabIndex = 0;
            // 
            // cbBanVe
            // 
            this.cbBanVe.FormattingEnabled = true;
            this.cbBanVe.Location = new System.Drawing.Point(419, 262);
            this.cbBanVe.Name = "cbBanVe";
            this.cbBanVe.Size = new System.Drawing.Size(229, 24);
            this.cbBanVe.TabIndex = 1;
            // 
            // fBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbBanVe);
            this.Controls.Add(this.dtgvBanVe);
            this.Name = "fBanVe";
            this.Text = "fBanVe";
            this.Load += new System.EventHandler(this.fBanVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanVe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBanVe;
        private System.Windows.Forms.ComboBox cbBanVe;
    }
}