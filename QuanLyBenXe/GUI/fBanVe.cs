﻿using System;
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
            List<BanVe_DTO> lstBanVe = BanVe_BUS.LayVe();
            dtgvBanVe.DataSource = lstBanVe;

        }
    }
}
