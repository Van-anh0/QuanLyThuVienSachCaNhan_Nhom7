using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessLogic;
namespace QuanLyThuVienCaNhan
{
    public partial class frmMuonTra : Form
    {
        Book _bookcurrent;
        public int Loai { get; set; }
        public bool hasChange { get; set; }
        public frmMuonTra(Book book, int loai)
        {
            this.Loai = loai;
            _bookcurrent = book;
            InitializeComponent();
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            if (Loai == 1)
                ThemMuon();
            if(Loai == 2)
                ThemTra();
        }
        public void ThemMuon()
        {
            Borrower borrower = new Borrower();
            MuonTra muonTra = new MuonTra();
            borrower.ID = 0;
            if (txtTen.Text == "" || txtDiaChi.Text == "" || mtbSDT.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            else
            {
                borrower.Ten = txtTen.Text;
                borrower.DiaChi = txtDiaChi.Text;
                borrower.SDT = mtbSDT.Text;

                BorrowerBL borrowerBL = new BorrowerBL();
                int kq = borrowerBL.ThemBanDoc(borrower);

                if (kq == 0)
                {
                    kq = borrowerBL.SuaBanDoc(borrower);
                }

                borrower.ID = kq;

                _bookcurrent.TrangThai = 1;
                BookBL bookBL = new BookBL();
                bookBL.SuaTT(_bookcurrent);

                muonTra.ID = borrower.ID;
                muonTra.MaSach = _bookcurrent.Ma;
                muonTra.NgayMuon = new DateTime(dtpNgayMuon.Value.Year, dtpNgayMuon.Value.Month, dtpNgayMuon.Value.Day);
                muonTra.NgayTra = new DateTime(2001, 1, 1);
                MuonTraBL muonTraBL = new MuonTraBL();
                muonTraBL.ThemMuon(muonTra.ID, muonTra.MaSach, muonTra.NgayMuon, muonTra.NgayTra);
                MessageBox.Show("Thêm mượn sách thành công!");
                hasChange = true;
                Close();
            }
        }

        public void ThemTra()
        {
            Borrower borrower = new Borrower();
            MuonTra muonTra = new MuonTra();
            borrower.ID = 0;
            if (txtTen.Text == "" || txtDiaChi.Text == "" || mtbSDT.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            else
            {
                borrower.Ten = txtTen.Text;
                borrower.DiaChi = txtDiaChi.Text;
                borrower.SDT = mtbSDT.Text;

                BorrowerBL borrowerBL = new BorrowerBL();
                int kq = borrowerBL.SuaBanDoc(borrower);


                borrower.ID = kq;

                _bookcurrent.TrangThai = 0;
                BookBL bookBL = new BookBL();
                bookBL.SuaTT(_bookcurrent);

                muonTra.ID = borrower.ID;
                muonTra.MaSach = _bookcurrent.Ma;
                
                muonTra.NgayTra = new DateTime(dtpNgayTra.Value.Year, dtpNgayTra.Value.Month, dtpNgayTra.Value.Day);
                MuonTraBL muonTraBL = new MuonTraBL();
                muonTraBL.ThemTra(muonTra.ID, muonTra.MaSach, muonTra.NgayTra);
                MessageBox.Show("Thêm trả sách thành công!");
                hasChange = true;
                Close();
            }
        }

        public void AddNewBorrow()
        {
            lblNgayTra.Visible = false;
            dtpNgayTra.Value = new DateTime(2001, 1, 1);
            dtpNgayTra.Visible = false;
        }

        public void GiveBook()
        {
            txtTen.Enabled = false;
            txtDiaChi.Enabled = false;
            mtbSDT.Enabled = false;
            dtpNgayMuon.Enabled = false;
            dtpNgayTra.Visible = true;
        }

        private void frmMuonTra_Load(object sender, EventArgs e)
        {
            
            
            if (_bookcurrent.TrangThai == 1)
            {
                StatisticalBL statisticalBL = new StatisticalBL();
                DataTable dt = statisticalBL.ThongTinMT(_bookcurrent.Ma);
                dtgvhaha.DataSource = dt;


                txtTen.Text = dtgvhaha.Rows[0].Cells[0].Value.ToString();
                txtDiaChi.Text = dtgvhaha.Rows[0].Cells[1].Value.ToString();
                mtbSDT.Text = dtgvhaha.Rows[0].Cells[2].Value.ToString();
                dtpNgayMuon.Value = DateTime.Parse(dtgvhaha.Rows[0].Cells[3].Value.ToString());
                dtgvhaha.Visible = false;
            }
                
            

        }
    }
}
