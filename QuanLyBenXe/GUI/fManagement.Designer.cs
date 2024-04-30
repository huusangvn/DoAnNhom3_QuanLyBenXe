
namespace GUI
{
    partial class fManagement
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.btnTuyenXe = new System.Windows.Forms.Button();
            this.btnXe = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pnTitleBar = new System.Windows.Forms.Panel();
            this.tblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnDeskTop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.pnTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gray;
            this.panelMenu.Controls.Add(this.btnCaiDat);
            this.panelMenu.Controls.Add(this.btnHuongDan);
            this.panelMenu.Controls.Add(this.btnTuyenXe);
            this.panelMenu.Controls.Add(this.btnXe);
            this.panelMenu.Controls.Add(this.btnTicket);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 668);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaiDat.FlatAppearance.BorderSize = 0;
            this.btnCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaiDat.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCaiDat.Image = global::GUI.Properties.Resources.setting;
            this.btnCaiDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaiDat.Location = new System.Drawing.Point(0, 410);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCaiDat.Size = new System.Drawing.Size(230, 80);
            this.btnCaiDat.TabIndex = 6;
            this.btnCaiDat.Text = "   Cài Đặt";
            this.btnCaiDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaiDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaiDat.UseVisualStyleBackColor = false;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHuongDan.FlatAppearance.BorderSize = 0;
            this.btnHuongDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuongDan.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnHuongDan.Image = global::GUI.Properties.Resources.guide;
            this.btnHuongDan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuongDan.Location = new System.Drawing.Point(0, 330);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHuongDan.Size = new System.Drawing.Size(230, 80);
            this.btnHuongDan.TabIndex = 5;
            this.btnHuongDan.Text = "   Hướng Dẫn";
            this.btnHuongDan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuongDan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuongDan.UseVisualStyleBackColor = false;
            this.btnHuongDan.Click += new System.EventHandler(this.btnHuongDan_Click);
            // 
            // btnTuyenXe
            // 
            this.btnTuyenXe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTuyenXe.FlatAppearance.BorderSize = 0;
            this.btnTuyenXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuyenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuyenXe.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnTuyenXe.Image = global::GUI.Properties.Resources.Map;
            this.btnTuyenXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTuyenXe.Location = new System.Drawing.Point(0, 250);
            this.btnTuyenXe.Name = "btnTuyenXe";
            this.btnTuyenXe.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTuyenXe.Size = new System.Drawing.Size(230, 80);
            this.btnTuyenXe.TabIndex = 4;
            this.btnTuyenXe.Text = "   Tuyến Xe";
            this.btnTuyenXe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTuyenXe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTuyenXe.UseVisualStyleBackColor = false;
            this.btnTuyenXe.Click += new System.EventHandler(this.btnTuyenXe_Click);
            // 
            // btnXe
            // 
            this.btnXe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXe.FlatAppearance.BorderSize = 0;
            this.btnXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXe.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnXe.Image = global::GUI.Properties.Resources.Bus__1_;
            this.btnXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXe.Location = new System.Drawing.Point(0, 170);
            this.btnXe.Name = "btnXe";
            this.btnXe.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnXe.Size = new System.Drawing.Size(230, 80);
            this.btnXe.TabIndex = 3;
            this.btnXe.Text = "   Xe";
            this.btnXe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXe.UseVisualStyleBackColor = false;
            this.btnXe.Click += new System.EventHandler(this.btnXe_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTicket.FlatAppearance.BorderSize = 0;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnTicket.Image = global::GUI.Properties.Resources.ticket2;
            this.btnTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicket.Location = new System.Drawing.Point(0, 90);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTicket.Size = new System.Drawing.Size(230, 80);
            this.btnTicket.TabIndex = 1;
            this.btnTicket.Text = "   Bán Vé";
            this.btnTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(230, 90);
            this.panelLogo.TabIndex = 2;
            // 
            // pnTitleBar
            // 
            this.pnTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnTitleBar.Controls.Add(this.tblTitle);
            this.pnTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitleBar.Location = new System.Drawing.Point(230, 0);
            this.pnTitleBar.Name = "pnTitleBar";
            this.pnTitleBar.Size = new System.Drawing.Size(923, 90);
            this.pnTitleBar.TabIndex = 1;
            // 
            // tblTitle
            // 
            this.tblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblTitle.AutoSize = true;
            this.tblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblTitle.ForeColor = System.Drawing.Color.White;
            this.tblTitle.Location = new System.Drawing.Point(368, 31);
            this.tblTitle.Name = "tblTitle";
            this.tblTitle.Size = new System.Drawing.Size(177, 31);
            this.tblTitle.TabIndex = 2;
            this.tblTitle.Text = "TRANG CHỦ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "MyDu-Coach";
            // 
            // pnDeskTop
            // 
            this.pnDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDeskTop.Location = new System.Drawing.Point(230, 90);
            this.pnDeskTop.Name = "pnDeskTop";
            this.pnDeskTop.Size = new System.Drawing.Size(923, 578);
            this.pnDeskTop.TabIndex = 2;
            this.pnDeskTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDeskTop_Paint);
            // 
            // fManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 668);
            this.Controls.Add(this.pnDeskTop);
            this.Controls.Add(this.pnTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "fManagement";
            this.Text = "fManagement";
            this.Load += new System.EventHandler(this.fManagement_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.pnTitleBar.ResumeLayout(false);
            this.pnTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnTuyenXe;
        private System.Windows.Forms.Button btnXe;
        private System.Windows.Forms.Button btnCaiDat;
        private System.Windows.Forms.Button btnHuongDan;
        private System.Windows.Forms.Panel pnTitleBar;
        private System.Windows.Forms.Label tblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnDeskTop;
    }
}