
namespace GUI
{
    partial class fTuyenXe
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
            this.dtgvTuyenXe = new System.Windows.Forms.DataGridView();
            this.txtDiaDiemDen = new System.Windows.Forms.TextBox();
            this.txtDiaDiemDi = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdTuyen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenTuyen = new System.Windows.Forms.TextBox();
            this.btnThemTuyen = new System.Windows.Forms.Button();
            this.btnXoaTuyen = new System.Windows.Forms.Button();
            this.btnSuaTuyen = new System.Windows.Forms.Button();
            this.lbTen2 = new System.Windows.Forms.Label();
            this.lbTen1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTuyenXe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTuyenXe
            // 
            this.dtgvTuyenXe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvTuyenXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTuyenXe.Location = new System.Drawing.Point(490, 97);
            this.dtgvTuyenXe.Name = "dtgvTuyenXe";
            this.dtgvTuyenXe.RowHeadersWidth = 51;
            this.dtgvTuyenXe.RowTemplate.Height = 24;
            this.dtgvTuyenXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTuyenXe.Size = new System.Drawing.Size(566, 503);
            this.dtgvTuyenXe.TabIndex = 0;
            this.dtgvTuyenXe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTuyenXe_CellContentClick);
            // 
            // txtDiaDiemDen
            // 
            this.txtDiaDiemDen.Location = new System.Drawing.Point(130, 185);
            this.txtDiaDiemDen.Name = "txtDiaDiemDen";
            this.txtDiaDiemDen.Size = new System.Drawing.Size(225, 22);
            this.txtDiaDiemDen.TabIndex = 3;
            this.txtDiaDiemDen.TextChanged += new System.EventHandler(this.txtDiaDiemDen_TextChanged);
            // 
            // txtDiaDiemDi
            // 
            this.txtDiaDiemDi.Location = new System.Drawing.Point(130, 156);
            this.txtDiaDiemDi.Name = "txtDiaDiemDi";
            this.txtDiaDiemDi.Size = new System.Drawing.Size(225, 22);
            this.txtDiaDiemDi.TabIndex = 4;
            this.txtDiaDiemDi.TextChanged += new System.EventHandler(this.txtDiaDiemDi_TextChanged);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(130, 215);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(225, 22);
            this.txtGia.TabIndex = 5;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Địa điểm đi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Địa điểm đến";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtIdTuyen
            // 
            this.txtIdTuyen.Location = new System.Drawing.Point(130, 69);
            this.txtIdTuyen.Multiline = true;
            this.txtIdTuyen.Name = "txtIdTuyen";
            this.txtIdTuyen.Size = new System.Drawing.Size(225, 25);
            this.txtIdTuyen.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã Tuyến";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTenTuyen
            // 
            this.txtTenTuyen.Location = new System.Drawing.Point(130, 127);
            this.txtTenTuyen.Multiline = true;
            this.txtTenTuyen.Name = "txtTenTuyen";
            this.txtTenTuyen.Size = new System.Drawing.Size(225, 22);
            this.txtTenTuyen.TabIndex = 7;
            this.txtTenTuyen.TextChanged += new System.EventHandler(this.txtTenTuyen_TextChanged);
            // 
            // btnThemTuyen
            // 
            this.btnThemTuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemTuyen.AutoSize = true;
            this.btnThemTuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTuyen.Location = new System.Drawing.Point(505, 623);
            this.btnThemTuyen.Name = "btnThemTuyen";
            this.btnThemTuyen.Size = new System.Drawing.Size(167, 54);
            this.btnThemTuyen.TabIndex = 8;
            this.btnThemTuyen.Text = "Thêm Tuyến";
            this.btnThemTuyen.UseVisualStyleBackColor = true;
            this.btnThemTuyen.Click += new System.EventHandler(this.btnThemTuyen_Click);
            // 
            // btnXoaTuyen
            // 
            this.btnXoaTuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaTuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTuyen.Location = new System.Drawing.Point(721, 623);
            this.btnXoaTuyen.Name = "btnXoaTuyen";
            this.btnXoaTuyen.Size = new System.Drawing.Size(128, 54);
            this.btnXoaTuyen.TabIndex = 9;
            this.btnXoaTuyen.Text = "Xóa Tuyến";
            this.btnXoaTuyen.UseVisualStyleBackColor = true;
            this.btnXoaTuyen.Click += new System.EventHandler(this.btnXoaTuyen_Click);
            // 
            // btnSuaTuyen
            // 
            this.btnSuaTuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaTuyen.AutoSize = true;
            this.btnSuaTuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTuyen.Location = new System.Drawing.Point(888, 623);
            this.btnSuaTuyen.Name = "btnSuaTuyen";
            this.btnSuaTuyen.Size = new System.Drawing.Size(135, 54);
            this.btnSuaTuyen.TabIndex = 10;
            this.btnSuaTuyen.Text = "Sửa Tuyến";
            this.btnSuaTuyen.UseVisualStyleBackColor = true;
            this.btnSuaTuyen.Click += new System.EventHandler(this.btnSuaTuyen_Click);
            // 
            // lbTen2
            // 
            this.lbTen2.AutoSize = true;
            this.lbTen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen2.Location = new System.Drawing.Point(487, 47);
            this.lbTen2.Name = "lbTen2";
            this.lbTen2.Size = new System.Drawing.Size(99, 32);
            this.lbTen2.TabIndex = 11;
            this.lbTen2.Text = "label5";
            // 
            // lbTen1
            // 
            this.lbTen1.AutoSize = true;
            this.lbTen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen1.Location = new System.Drawing.Point(50, 304);
            this.lbTen1.Name = "lbTen1";
            this.lbTen1.Size = new System.Drawing.Size(99, 32);
            this.lbTen1.TabIndex = 11;
            this.lbTen1.Text = "label5";
            // 
            // fTuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 721);
            this.Controls.Add(this.lbTen1);
            this.Controls.Add(this.lbTen2);
            this.Controls.Add(this.btnSuaTuyen);
            this.Controls.Add(this.btnXoaTuyen);
            this.Controls.Add(this.btnThemTuyen);
            this.Controls.Add(this.txtTenTuyen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtIdTuyen);
            this.Controls.Add(this.txtDiaDiemDi);
            this.Controls.Add(this.txtDiaDiemDen);
            this.Controls.Add(this.dtgvTuyenXe);
            this.Name = "fTuyenXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tuyến Xe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTuyenXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTuyenXe;
        private System.Windows.Forms.TextBox txtDiaDiemDen;
        private System.Windows.Forms.TextBox txtDiaDiemDi;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdTuyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenTuyen;
        private System.Windows.Forms.Button btnThemTuyen;
        private System.Windows.Forms.Button btnXoaTuyen;
        private System.Windows.Forms.Button btnSuaTuyen;
        private System.Windows.Forms.Label lbTen2;
        private System.Windows.Forms.Label lbTen1;
    }
}

