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
    public partial class FrmQuanLy : Form
    {
        public FrmQuanLy()
        {
            InitializeComponent();
        }

        private void tsmiSach_Click(object sender, EventArgs e)
        {
            FrmTTSach sach = new FrmTTSach();
            sach.Show();
        }

        private void tsmiMTra_Click(object sender, EventArgs e)
        {
            FrmQuanLyMuonTra mtr = new FrmQuanLyMuonTra();
            mtr.Show();
        }

        private void tsmiTTMT_Click(object sender, EventArgs e)
        {
            FrmTTMuonTra ttMTr = new FrmTTMuonTra();
            ttMTr.Show();
        }

        private void tsmiDSVP_Click(object sender, EventArgs e)
        {
            FrmDSVP ds = new FrmDSVP();
            ds.Show();
        }
    }
}
