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
    public partial class frmXe : Form
    {
        public frmXe()
        {
            InitializeComponent();
        }

        private void dtgvXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmXe_Load(object sender, EventArgs e)
        {
            List<Xe_DTO> lstXe = Xe_BUS.LayXe();
            dtgvXe.DataSource = lstXe;
        }
    }
}
