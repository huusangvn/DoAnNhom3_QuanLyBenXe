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
        }
    }
}
