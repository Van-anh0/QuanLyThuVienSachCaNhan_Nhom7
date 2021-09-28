using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuayLySachCaNhan_Nhom7
{
    public partial class FrmMuonTra : Form
    {
        public FrmMuonTra()
        {
            InitializeComponent();
        }

       public void ShowFormTra()
        {
            txtTen.Enabled = false;
            txtDiaChi.Enabled = false;
            mtbSDT.Enabled = false;
            lblNgayMT.Text = "Ngày trả";
            lblNgayHen.Visible = false;
            dtpNgayHen.Visible = false;
        }
    }
}
