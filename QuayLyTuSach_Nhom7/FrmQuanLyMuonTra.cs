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
    public partial class FrmQuanLyMuonTra : Form
    {
        public FrmQuanLyMuonTra()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tsmiMuonSach_Click(object sender, EventArgs e)
        {
            FrmMuonTra mt = new FrmMuonTra();
            mt.Show();
        }

        private void tsmiTraSach_Click(object sender, EventArgs e)
        {
            FrmMuonTra mt = new FrmMuonTra();
            mt.ShowFormTra();
            mt.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
