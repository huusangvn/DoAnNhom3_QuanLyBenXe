using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class fManagement : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public fManagement()
        {
            InitializeComponent();
            random = new Random();
        }

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
            ActivateButton(sender);
        }
        private void btnTuyenXe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
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
    }
}
