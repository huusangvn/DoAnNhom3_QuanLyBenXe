
namespace GUI
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
            this.dtgvTuyenXe = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiaDiemDen = new System.Windows.Forms.TextBox();
            this.txtDiaDiemDi = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdTuyen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenTuyen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTuyenXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTuyenXe
            // 
            this.dtgvTuyenXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTuyenXe.Location = new System.Drawing.Point(0, 0);
            this.dtgvTuyenXe.Name = "dtgvTuyenXe";
            this.dtgvTuyenXe.RowHeadersWidth = 51;
            this.dtgvTuyenXe.RowTemplate.Height = 24;
            this.dtgvTuyenXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTuyenXe.Size = new System.Drawing.Size(796, 312);
            this.dtgvTuyenXe.TabIndex = 0;
            this.dtgvTuyenXe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTuyenXe_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(419, 212);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(8, 10);
            this.dataGridView2.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(526, 339);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 35);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm tuyến";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDiaDiemDen
            // 
            this.txtDiaDiemDen.Location = new System.Drawing.Point(130, 416);
            this.txtDiaDiemDen.Name = "txtDiaDiemDen";
            this.txtDiaDiemDen.Size = new System.Drawing.Size(178, 22);
            this.txtDiaDiemDen.TabIndex = 3;
            // 
            // txtDiaDiemDi
            // 
            this.txtDiaDiemDi.Location = new System.Drawing.Point(130, 387);
            this.txtDiaDiemDi.Name = "txtDiaDiemDi";
            this.txtDiaDiemDi.Size = new System.Drawing.Size(178, 22);
            this.txtDiaDiemDi.TabIndex = 4;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(376, 345);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 22);
            this.txtGia.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Địa điểm đi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Địa điểm đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá";
            // 
            // txtIdTuyen
            // 
            this.txtIdTuyen.Location = new System.Drawing.Point(130, 330);
            this.txtIdTuyen.Name = "txtIdTuyen";
            this.txtIdTuyen.Size = new System.Drawing.Size(178, 22);
            this.txtIdTuyen.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã Tuyến";
            // 
            // txtTenTuyen
            // 
            this.txtTenTuyen.Location = new System.Drawing.Point(130, 358);
            this.txtTenTuyen.Name = "txtTenTuyen";
            this.txtTenTuyen.Size = new System.Drawing.Size(178, 22);
            this.txtTenTuyen.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTenTuyen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtIdTuyen);
            this.Controls.Add(this.txtDiaDiemDi);
            this.Controls.Add(this.txtDiaDiemDen);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dtgvTuyenXe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTuyenXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTuyenXe;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiaDiemDen;
        private System.Windows.Forms.TextBox txtDiaDiemDi;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdTuyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenTuyen;
    }
}

