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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiTuyenXe();
        }
        public void HienThiTuyenXe()
        {
            List<TuyenXe_DTO> lstTuyenXe = TuyenXe_BUS.LayTuyenXe();
            dtgvTuyenXe.DataSource = lstTuyenXe;
            dtgvTuyenXe.Columns["IdTuyen1"].HeaderText = "Mã Tuyến";
            dtgvTuyenXe.Columns["TenTuyen1"].HeaderText = "Tên Tuyến";
            dtgvTuyenXe.Columns["DiaDiemDi1"].HeaderText = "Địa điểm đi";
            dtgvTuyenXe.Columns["DiaDiemDen1"].HeaderText = "Địa điểm đến";
            dtgvTuyenXe.Columns["Gia1"].HeaderText = "Giá";
        }

        private void dtgvTuyenXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dtgvTuyenXe.SelectedRows[0];
            txtIdTuyen.Text = r.Cells["IdTuyen1"].Value.ToString();
            txtTenTuyen.Text = r.Cells["TenTuyen1"].Value.ToString();
            txtDiaDiemDi.Text = r.Cells["DiaDiemDi1"].Value.ToString();
            txtDiaDiemDen.Text = r.Cells["DiaDiemDen1"].Value.ToString();
            txtGia.Text = r.Cells["Gia1"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIdTuyen.Text == "" || txtTenTuyen.Text == "" || txtDiaDiemDi.Text == "" || txtDiaDiemDen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");

                return;
            }
            // Kiểm tra mã tuyến có độ dài chuỗi hợp lệ hay không
            if (txtIdTuyen.Text.Length > 5)
            {
                MessageBox.Show("Mã nhân viên tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (TuyenXe_BUS.TimTuyenXeTheoMa(txtIdTuyen.Text) != null)
            {
                MessageBox.Show("Mã tuyến xe đã tồn tại!");
                return;
            }   
            TuyenXe_DTO tx = new TuyenXe_DTO();
            tx.IdTuyen1 = txtIdTuyen.Text;
            tx.TenTuyen1 = txtTenTuyen.Text;
            tx.DiaDiemDi1 = txtDiaDiemDi.Text;
            tx.DiaDiemDen1 = txtDiaDiemDen.Text;
            tx.Gia1 = Int32.Parse(txtGia.Text);
            
            if (TuyenXe_BUS.ThemTuyenXe(tx) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            else
            {
                HienThiTuyenXe();
                MessageBox.Show("Đã thêm tuyến xe.");
            }
        }
    }
}
