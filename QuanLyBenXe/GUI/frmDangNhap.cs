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
using System.Data.SqlClient;

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
            /*  string sTen = txtTaiKhoan.Text;
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

            string sTruyVan = @"Data Source=ADMIN\MSSQLSEVER;Initial Catalog=QuanLyBenXe;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sTruyVan);
            try
            {
                conn.Open();
                string sTen = txtTaiKhoan.Text;
                string sMatKhau = txtMatKhau.Text;
                string sql = string.Format(@"select * from NguoiDung where IdNguoiDung=N'{0}' and PassND='{1}'", sTen, sMatKhau);
                SqlCommand cm = new SqlCommand(sql, conn);
                SqlDataReader dta = cm.ExecuteReader();
                if(sTen == "" || sMatKhau == "")
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không được bỏ trống!!", "Thông Báo");
                }
                else
                {
                    if (dta.Read() == true)
                    {
                        this.Hide();
                        fManagement f = new fManagement();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu hoặc tài khoản", "Thông Báo");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
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
