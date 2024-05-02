using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class fBanVe : Form
    {
        public fBanVe()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
           // lbTen1.ForeColor = ThemeColor.SecondaryColor;
            lbTen2.ForeColor = ThemeColor.PrimaryColor;
        }
        private void fBanVe_Load(object sender, EventArgs e)
        {
            LoadTheme();
            HienThiBanVe();
            HienViVe();
        }
        public void HienViVe()
        {
            List<ChiTietBanVe_DTO> lstChiTietBanVe = ChiTietBanVe_BUS.LayVe();
            dtgvChiTietBanVe.DataSource = lstChiTietBanVe;

            dtgvChiTietBanVe.Columns["IdVe1"].HeaderText = "Mã Vé";
            dtgvChiTietBanVe.Columns["TenHanhKhach1"].HeaderText = "Tên Khách Hàng";
            dtgvChiTietBanVe.Columns["SDTHanhKhach1"].HeaderText = "Số Điện Thoại";
            /*dtgvBanVe.Columns["TenTuyen1"].HeaderText = "Tên Tuyến";
            dtgvBanVe.Columns["NgayDi1"].HeaderText = "Ngày Đi";
            dtgvBanVe.Columns["Gio1"].HeaderText = "Giờ Xuất Phát";
            dtgvBanVe.Columns["So_Xe1"].HeaderText = "Số Xe";
            dtgvBanVe.Columns["Gia1"].HeaderText = "Giá";*/
        }
        public void HienThiBanVe()
        {
            List<BanVe_DTO> lstBanVe = BanVe_BUS.BanVe();
            dtgvBanVe.DataSource = lstBanVe;

            List<ChuyenXe_DTO> lstIdChuyenXe = ChuyenXe_BUS.LayChuyenXe();
            cbChuyenXe.DataSource = lstIdChuyenXe;
            cbChuyenXe.DisplayMember = "Mã Chuyến";
            cbChuyenXe.ValueMember = "IdChuyen1";
        }
        private void cbBanVe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgvBanVe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dtgvChiTietBanVe.SelectedRows[0];
            txtMaVe.Text = r.Cells["IDVe1"].Value.ToString();
            txtHoTen.Text = r.Cells["TenHanhKhach1"].Value.ToString();
            txtSDT.Text = r.Cells["SDTHanhKhach1"].Value.ToString();
            cbChuyenXe.Text = r.Cells["TenTuyen1"].Value.ToString();
           /* dtNgayDi.Text = r.Cells["NgayDi1"].Value.ToString();
            txtGioXuatPhat.Text = r.Cells["Gio1"].Value.ToString();
            cbBienSoXe.Text = r.Cells["So_Xe1"].Value.ToString();
            txtGia.Text = r.Cells["Gia1"].Value.ToString();*/
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaVe.Text == "" || txtHoTen.Text == "" || txtSDT.Text == "" || cbChuyenXe.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã tuyến có độ dài chuỗi hợp lệ hay không
            if (txtMaVe.Text.Length > 6)
            {
                MessageBox.Show("Mã vé tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (BanVe_BUS.TimVeTheoMa(txtMaVe.Text) != null)
            {
                MessageBox.Show("Mã tuyến xe đã tồn tại!");
                return;
            }
            BanVe_DTO bv = new BanVe_DTO();
            bv.IdVe1 = txtMaVe.Text;
            bv.IdChuyen1 = cbChuyenXe.Text;
            bv.TenHanhKhach1 = txtHoTen.Text;
            bv.SDTHanhKhach1 = Int32.Parse(txtSDT.Text);
            if (BanVe_BUS.ThemVe(bv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            else
            {
                HienThiBanVe();
                MessageBox.Show("Đã thêm tuyến xe.");
                HienViVe();
            }
        }

        private void cbBienSoXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }
    }
}
