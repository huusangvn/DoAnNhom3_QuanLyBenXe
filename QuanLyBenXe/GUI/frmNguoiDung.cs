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
    public partial class frmNguoiDung : Form
    {
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            List<NguoiDung_DTO> lstNguoiDung = NguoiDung_BUS.LayNguoiDung();
            dtgvNguoiDung.DataSource = lstNguoiDung;
            cbLoaiNguoiDung.DataSource = lstNguoiDung;
            cbLoaiNguoiDung.DisplayMember = "Loại Người Dùng";
            cbLoaiNguoiDung.ValueMember = "IdLoaiND1";

        }
    }
}
