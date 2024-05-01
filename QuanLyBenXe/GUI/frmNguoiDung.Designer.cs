
namespace GUI
{
    partial class frmNguoiDung
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
            this.dtgvNguoiDung = new System.Windows.Forms.DataGridView();
            this.cbLoaiNguoiDung = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvNguoiDung
            // 
            this.dtgvNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNguoiDung.Location = new System.Drawing.Point(341, 12);
            this.dtgvNguoiDung.Name = "dtgvNguoiDung";
            this.dtgvNguoiDung.RowHeadersWidth = 51;
            this.dtgvNguoiDung.RowTemplate.Height = 24;
            this.dtgvNguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvNguoiDung.Size = new System.Drawing.Size(431, 426);
            this.dtgvNguoiDung.TabIndex = 0;
            this.dtgvNguoiDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbLoaiNguoiDung
            // 
            this.cbLoaiNguoiDung.FormattingEnabled = true;
            this.cbLoaiNguoiDung.Location = new System.Drawing.Point(25, 40);
            this.cbLoaiNguoiDung.Name = "cbLoaiNguoiDung";
            this.cbLoaiNguoiDung.Size = new System.Drawing.Size(209, 24);
            this.cbLoaiNguoiDung.TabIndex = 1;
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbLoaiNguoiDung);
            this.Controls.Add(this.dtgvNguoiDung);
            this.Name = "frmNguoiDung";
            this.Text = "frmNguoiDung";
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvNguoiDung;
        private System.Windows.Forms.ComboBox cbLoaiNguoiDung;
    }
}