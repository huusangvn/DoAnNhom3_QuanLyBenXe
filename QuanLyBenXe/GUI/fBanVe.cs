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

        private void fBanVe_Load(object sender, EventArgs e)
        {
            HienViVe();
            List<TuyenXe_DTO> lstTuyenXe = TuyenXe_BUS.LayTuyenXe();
            cbBanVe.DataSource = lstTuyenXe;
            cbBanVe.DisplayMember = "TenTuyen1";
            cbBanVe.ValueMember = "IdTuyen1";
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

         
        }

        private void cbBanVe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
