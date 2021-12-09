using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace QuanLyThuVienCaNhan
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = null;

            StatisticalBL stBl = new StatisticalBL();


            dgvDanhSach.DataSource = stBl.ThongKeTG();
            dgvDanhSach.Columns[0].Width = 200;
            dgvDanhSach.Columns[1].Width = 200;
            dgvDanhSach.Columns[2].Width = 200;
            dgvDanhSach.DefaultCellStyle.Font = new Font("Times New Roman", 15);
            this.dgvDanhSach.DefaultCellStyle.BackColor = Color.DarkOrchid;
            this.dgvDanhSach.DefaultCellStyle.ForeColor = Color.White;
            this.dgvDanhSach.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dgvDanhSach.DefaultCellStyle.SelectionBackColor = Color.Black;
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = null;
            StatisticalBL stBL = new StatisticalBL();


            dgvDanhSach.DataSource = stBL.ThongKeTL();
            dgvDanhSach.Columns[0].Width = 150;
            dgvDanhSach.Columns[1].Width = 200;
            dgvDanhSach.Columns[2].Width = 200;
            dgvDanhSach.Columns[3].Width = 200;
        }

        private void btnSachMuon_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = null;
            StatisticalBL stBL = new StatisticalBL();


            dgvDanhSach.DataSource = stBL.ThongKeSM();
        }

        private void btnThoiGian_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = null;
            StatisticalBL stBL = new StatisticalBL();


            dgvDanhSach.DataSource = stBL.ThongKeThoiGian();
            dgvDanhSach.Columns[0].Width = 150;
            dgvDanhSach.Columns[1].Width = 200;
            dgvDanhSach.Columns[2].Width = 200;
            dgvDanhSach.Columns[3].Width = 200;
        }
    }
}
