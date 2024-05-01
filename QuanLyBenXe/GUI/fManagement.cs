using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class fManagement : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public bool bDangNhap; // true: đăng nhập thành công, false: chưa đăng nhập

        public TaiKhoan_DTO TaiKhoan;

        private void HienThiMenu()
        {/*
            iDangNhap.Enabled = !bDangNhap;
            iDangXuat.Enabled = bDangNhap;
            iDanhMuc.Enabled = bDangNhap;
            iNghiepVu.Enabled = bDangNhap;*/
            // tương tự cho các menu còn lại


            if (bDangNhap == true)
            {
               /* txtNguoiDung.Text = "Người dùng: " + NguoiDung.Ten;
                txtThoiDiemDangNhap.Text = "Thời điểm đăng nhập: " + DateTime.Now;*/
                // Hiển thị menu theo quyền, ví dụ:
                // 1. quantri: sử dụng tất cả menu
                // 2. nhanvien: không sử dụng các menu: Danh mục, Nghiệp vụ
                string iQuyen;
                if (TaiKhoan == null)
                {
                    iQuyen = "Nhan_Vien";
                }
                else
                {
                    iQuyen = TaiKhoan.IdLoaiND1.ToString();
                }
                switch (iQuyen)
                {
                    case "Nhan_Vien": // SV tự bổ sung
                  /*      iDanhMuc.Enabled = bDangNhap;
                        iNghiepVu.Enabled = bDangNhap*/;
                        break;
                    case "Quan_Ly": // SV tự bổ sung
                    /*    iDanhMuc.Enabled = !bDangNhap;
                        iNghiepVu.Enabled = !bDangNhap;*/
                        break;
                    default:
                        break;
                }
            }
            else
            {
               /* txtNguoiDung.Text = "Chưa đăng nhập";
                txtThoiDiemDangNhap.Text = ""*/;
            }
        }
        public fManagement()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fManagement_Load(object sender, EventArgs e)
        {
       
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;

                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnDeskTop.Controls.Add(childForm);
            this.pnDeskTop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            tblTitle.Text = childForm.Text;
        }   

        private void btnTicket_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fBanVe(), sender);
        }

        private void btnXe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmXe(), sender);
        }
        private void btnTuyenXe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTuyenXe(), sender);
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void pnDeskTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            tblTitle.Text = "HOME";
            pnTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void fManagement_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void pnTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            if (f.ShowDialog() == DialogResult.OK)
            {
                string sTen = f.txtTaiKhoan.Text;
                string sMatKhau = f.txtMatKhau.Text;
                TaiKhoan = new TaiKhoan_DTO();
                TaiKhoan = TaiKhoan_BUS.LayTaiKhoan(sTen, sMatKhau);
                if (TaiKhoan != null)
                {
                    bDangNhap = true;
                }
            }
            else
            {
                bDangNhap = false;
                MessageBox.Show("Đăng nhập thất bại!!");
            }

        }
    }
}
