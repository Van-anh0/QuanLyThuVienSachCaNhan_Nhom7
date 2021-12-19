using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace QuanLyThuVienCaNhan
{
    public partial class frmSach : Form
    {
        private int sachId;
        List<Category> listCategory = new List<Category>();
        List<Book> listBook = new List<Book>();
        public Book book;
        Book bookCurrent = new Book();

        public frmSach(int sachID = 0)
        {
            InitializeComponent();
            sachId = sachID;
        }

        public void AddNewBook()
        {
            cbbTinhTrang.Text = "0";
            cbbTinhTrang.Enabled = false;
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            CategoryBL category = new CategoryBL();
            listCategory = category.GetAll();
            cbbTheLoai.DataSource = listCategory;
            cbbTheLoai.DisplayMember = "Name";
            cbbTheLoai.ValueMember = "ID";
            if (sachId != 0)
            {
                txtMa.Text = book.Ma.ToString();
                txtTenSach.Text = book.Name;
                txtTacGia.Text = book.TacGia;
                txtNxb.Text = book.NhaXB;
                txtNamXB.Text = book.NamXB;
                txtKeSach.Text = book.KeSach.ToString();
                txtVTNgan.Text = book.VTNgan.ToString();
                cbbTinhTrang.Text = book.TrangThai.ToString();
                txtHinh.Text = book.HinhAnh;
                try
                {
                    ptbPicture.Load(txtHinh.Text);
                }
                catch
                {

                }
            }
        }

        private void btnHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select Picture";
            dlg.Filter = "Image Files (JPEG, GIF, BMF, BMP, etc.)|"
                  + "*.jpg;*.jpeg;*.gif;*.bmp;"
                  + "*.tif;*.tiff;*.png|"
                  + "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|"
                  + "GIF files (*.gif)|*.gif|"
                  + "BMP files (*.bmp)|*.bmp|"
                  + "TIFF files (*.tif;*.tiff)|*.tif;*tiff|"
                  + "PNG files (*.png)|*.png|"
                  + "All files (*.*)|*.*";
            dlg.InitialDirectory = Environment.CurrentDirectory;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var fileName = dlg.FileName;
                txtHinh.Text = fileName;
                ptbPicture.Load(fileName);
            }
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtNxb.Text = "";
            txtNamXB.Text = "";
            txtKeSach.Text = "";
            txtVTNgan.Text = "";
            txtHinh.Text = "";
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            ThemTL them = new ThemTL();
            them.ShowDialog();
        }
        public int Insertbook()
        {
            Book book = new Book();
            book.Ma = 0;
            if (txtTenSach.Text == "" || txtTacGia.Text == "" || txtKeSach.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            else
            {
                book.Name = txtTenSach.Text;
                book.TacGia = txtTacGia.Text;
                book.NamXB = txtNamXB.Text;
                book.NhaXB = txtNxb.Text;
                book.KeSach = int.Parse(txtKeSach.Text);
                int ngan = 0;
                try
                {
                    ngan = int.Parse(txtVTNgan.Text);
                }
                catch
                {
                    ngan = 0;
                }
                book.VTNgan = ngan;
                book.HinhAnh = txtHinh.Text;
                book.MaTheLoai = int.Parse(cbbTheLoai.SelectedValue.ToString());
                BookBL bookBL = new BookBL();
                return bookBL.Them(book);
            }
            return -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int result = Insertbook();
            if (result > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
            }
            else MessageBox.Show("Thêm dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int result = UpdateBook();
            if (result > 0) 
            {
                MessageBox.Show("Cập nhật dữ liệu thành công");

            }
            else MessageBox.Show("Cập nhật dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
        }
        public int UpdateBook()
        {
            book.Ma = 0;
            if (txtTenSach.Text == "" || txtTacGia.Text == "" || txtKeSach.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            else
            {
                book.Name = txtTenSach.Text;
                book.TacGia = txtTacGia.Text;
                book.NamXB = txtNamXB.Text;
                book.NhaXB = txtNxb.Text;
                book.KeSach = int.Parse(txtKeSach.Text);
                int ngan = 0;
                try
                {
                    ngan = int.Parse(txtVTNgan.Text);
                }
                catch
                {
                    ngan = 0;
                }
                book.VTNgan = ngan;
                book.MaTheLoai = int.Parse(cbbTheLoai.SelectedValue.ToString());
                BookBL bookBL = new BookBL();
                return bookBL.Sua(book);
            }
            return -1;
        }
    }
}
