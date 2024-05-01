using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmDangNhap : Form
    {

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
                /*string sTen = txtTaiKhoan.Text;
                string sMatKhau = txtMatKhau.Text;
                TaiKhoan_DTO TaiKhoan = new TaiKhoan_DTO();
                TaiKhoan = TaiKhoan_BUS.LayTaiKhoan(sTen, sMatKhau);
                if (TaiKhoan != null)
                {
                    fManagement f = new fManagement();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!!");
            }*/
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
