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
            lbTen1.ForeColor = ThemeColor.SecondaryColor;
            lbTen2.ForeColor = ThemeColor.PrimaryColor;
        }
        private void fBanVe_Load(object sender, EventArgs e)
        {
            HienViVe();
            List<TuyenXe_DTO> lstTuyenXe = TuyenXe_BUS.LayTuyenXe();
            cbBanVe.DataSource = lstTuyenXe;
          
            cbBanVe.DisplayMember = "TenTuyen1";
            cbBanVe.ValueMember = "IdTuyen1";

            //Combobox biển số xe
            List<Xe_DTO> lstXe = Xe_BUS.LayXe();
            cbBienSoXe.DataSource = lstXe;
            cbBienSoXe.DisplayMember = "So_Xe1";
            cbBienSoXe.ValueMember = "So_Xe1";

            //Combobox Giờ Xuất Phát
            List<ThoiDiem_DTO> lstThoiDiem = ThoiDiem_BUS.LayThoiDiem();
            cbGioXuatPhat.DataSource = lstThoiDiem;
            cbGioXuatPhat.DisplayMember = "Gio1";
            cbGioXuatPhat.ValueMember = "Gio1";

            LoadTheme();
        }
        public void HienViVe()
        {
            List<BanVe_DTO> lstBanVe = BanVe_BUS.LayVe();
            dtgvBanVe.DataSource = lstBanVe;

            dtgvBanVe.Columns["IdVe1"].HeaderText = "Mã Vé";
            dtgvBanVe.Columns["TenHanhKhach1"].HeaderText = "Tên Khách Hàng";
            dtgvBanVe.Columns["SDTHanhKhach1"].HeaderText = "Số Điện Thoại";
            dtgvBanVe.Columns["TenTuyen1"].HeaderText = "Tên Tuyến";
            dtgvBanVe.Columns["NgayDi1"].HeaderText = "Ngày Đi";
            dtgvBanVe.Columns["Gio1"].HeaderText = "Giờ Xuất Phát";
            dtgvBanVe.Columns["So_Xe1"].HeaderText = "Số Xe";
            dtgvBanVe.Columns["Gia1"].HeaderText = "Giá";


        }

        private void cbBanVe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgvBanVe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dtgvBanVe.SelectedRows[0];
            txtMaVe.Text = r.Cells["IDVe1"].Value.ToString();
            txtHoTen.Text = r.Cells["TenHanhKhach1"].Value.ToString();
            txtSDT.Text = r.Cells["SDTHanhKhach1"].Value.ToString();
            cbBanVe.Text = r.Cells["TenTuyen1"].Value.ToString();
            dtNgayDi.Text = r.Cells["NgayDi1"].Value.ToString();
            cbGioXuatPhat.Text = r.Cells["Gio1"].Value.ToString();
            cbBienSoXe.Text = r.Cells["So_Xe1"].Value.ToString();
            txtGia.Text = r.Cells["Gia1"].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaVe.Text == "" || txtHoTen.Text == "" || txtSDT.Text == "" || cbGioXuatPhat.Text == "" || txtGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã tuyến có độ dài chuỗi hợp lệ hay không
            if (txtMaVe.Text.Length > 6)
            {
                MessageBox.Show("Mã nhân viên tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (BanVe_BUS.TimVeTheoMa(txtMaVe.Text) != null)
            {
                MessageBox.Show("Mã vé xe đã tồn tại!");
                return;
            }
            BanVe_DTO bv = new BanVe_DTO();
            bv.IDVe1 = txtMaVe.Text;
            bv.TenHanhKhach1 = txtHoTen.Text;
            bv.SDTHanhKhach1 = Int32.Parse(txtSDT.Text);
            bv.TenTuyen1 = cbBanVe.Text;
            bv.NgayDi1 = DateTime.Parse(dtNgayDi.Text);
            bv.Gio1 = cbGioXuatPhat.Text;
            bv.So_Xe1 = cbBienSoXe.Text;
            bv.Gia1 = Int32.Parse(txtGia.Text);

            if (BanVe_BUS.ThemVeXe(bv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            else
            {
                HienViVe();
                MessageBox.Show("Đã thêm vé xe.");
            }
        }
    }
}
