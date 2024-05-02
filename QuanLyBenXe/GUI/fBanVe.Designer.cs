
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
            this.components = new System.ComponentModel.Container();
            this.dtgvBanVe = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.radTimTheoMa = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbTen1 = new System.Windows.Forms.Label();
            this.lbTen2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbBanVe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.blels = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaVe = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dtNgayDi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.cbGioXuatPhat = new System.Windows.Forms.ComboBox();
            this.cbBienSoXe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanVe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvBanVe
            // 
            this.dtgvBanVe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvBanVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBanVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBanVe.Location = new System.Drawing.Point(468, 66);
            this.dtgvBanVe.Name = "dtgvBanVe";
            this.dtgvBanVe.RowHeadersWidth = 51;
            this.dtgvBanVe.RowTemplate.Height = 24;
            this.dtgvBanVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBanVe.Size = new System.Drawing.Size(554, 491);
            this.dtgvBanVe.TabIndex = 0;
            this.dtgvBanVe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBanVe_CellContentClick);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.AutoSize = true;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(878, 573);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(140, 41);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa Vé";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.AutoSize = true;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(468, 573);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(161, 41);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "Thêm Vé";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.AutoSize = true;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(670, 573);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(178, 41);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa Vé";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // radTimTheoMa
            // 
            this.radTimTheoMa.AutoSize = true;
            this.radTimTheoMa.Location = new System.Drawing.Point(32, 557);
            this.radTimTheoMa.Name = "radTimTheoMa";
            this.radTimTheoMa.Size = new System.Drawing.Size(112, 21);
            this.radTimTheoMa.TabIndex = 36;
            this.radTimTheoMa.TabStop = true;
            this.radTimTheoMa.Text = "Tìm Theo Mã";
            this.radTimTheoMa.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 598);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 29);
            this.textBox1.TabIndex = 35;
            // 
            // lbTen1
            // 
            this.lbTen1.AutoSize = true;
            this.lbTen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen1.Location = new System.Drawing.Point(26, 512);
            this.lbTen1.Name = "lbTen1";
            this.lbTen1.Size = new System.Drawing.Size(187, 32);
            this.lbTen1.TabIndex = 34;
            this.lbTen1.Text = "Tìm Kiếm Vé";
            // 
            // lbTen2
            // 
            this.lbTen2.AutoSize = true;
            this.lbTen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen2.Location = new System.Drawing.Point(462, 21);
            this.lbTen2.Name = "lbTen2";
            this.lbTen2.Size = new System.Drawing.Size(254, 32);
            this.lbTen2.TabIndex = 37;
            this.lbTen2.Text = "Danh Sách Vé Xe";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbBanVe
            // 
            this.cbBanVe.FormattingEnabled = true;
            this.cbBanVe.Location = new System.Drawing.Point(194, 256);
            this.cbBanVe.Name = "cbBanVe";
            this.cbBanVe.Size = new System.Drawing.Size(253, 24);
            this.cbBanVe.TabIndex = 1;
            this.cbBanVe.SelectedIndexChanged += new System.EventHandler(this.cbBanVe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Vé";
            // 
            // blels
            // 
            this.blels.AutoSize = true;
            this.blels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blels.Location = new System.Drawing.Point(27, 256);
            this.blels.Name = "blels";
            this.blels.Size = new System.Drawing.Size(98, 25);
            this.blels.TabIndex = 2;
            this.blels.Text = "Tuyến Xe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày Đi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giờ Xuất Phát";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Biển Số Xe";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "SDT";
            // 
            // txtMaVe
            // 
            this.txtMaVe.Location = new System.Drawing.Point(194, 95);
            this.txtMaVe.Multiline = true;
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.Size = new System.Drawing.Size(253, 32);
            this.txtMaVe.TabIndex = 3;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(194, 146);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(253, 34);
            this.txtHoTen.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(194, 204);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(253, 32);
            this.txtSDT.TabIndex = 5;
            // 
            // dtNgayDi
            // 
            this.dtNgayDi.Location = new System.Drawing.Point(194, 305);
            this.dtNgayDi.Name = "dtNgayDi";
            this.dtNgayDi.Size = new System.Drawing.Size(253, 22);
            this.dtNgayDi.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giá Vé";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(194, 451);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(253, 30);
            this.txtGia.TabIndex = 40;
            // 
            // cbGioXuatPhat
            // 
            this.cbGioXuatPhat.FormattingEnabled = true;
            this.cbGioXuatPhat.Location = new System.Drawing.Point(194, 356);
            this.cbGioXuatPhat.Name = "cbGioXuatPhat";
            this.cbGioXuatPhat.Size = new System.Drawing.Size(253, 24);
            this.cbGioXuatPhat.TabIndex = 41;
            // 
            // cbBienSoXe
            // 
            this.cbBienSoXe.FormattingEnabled = true;
            this.cbBienSoXe.Location = new System.Drawing.Point(194, 400);
            this.cbBienSoXe.Name = "cbBienSoXe";
            this.cbBienSoXe.Size = new System.Drawing.Size(253, 24);
            this.cbBienSoXe.TabIndex = 41;
            // 
            // fBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 651);
            this.Controls.Add(this.cbBienSoXe);
            this.Controls.Add(this.cbGioXuatPhat);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.dtNgayDi);
            this.Controls.Add(this.lbTen2);
            this.Controls.Add(this.radTimTheoMa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbTen1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaVe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.blels);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBanVe);
            this.Controls.Add(this.dtgvBanVe);
            this.Name = "fBanVe";
            this.Text = "BÁN VÉ";
            this.Load += new System.EventHandler(this.fBanVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBanVe;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.RadioButton radTimTheoMa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbTen1;
        private System.Windows.Forms.Label lbTen2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbBanVe;
        private System.Windows.Forms.ComboBox cbGioXuatPhat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label blels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaVe;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DateTimePicker dtNgayDi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.ComboBox cbBienSoXe;
    }
}