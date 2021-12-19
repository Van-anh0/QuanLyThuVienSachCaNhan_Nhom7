using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.Expressions;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace QuanLyThuVienCaNhan
{
    public partial class frmThuVien : Form
    {
        private const string PlaceHolderText = "Nhập thông tin của sách cần tìm !!!!!";
        List<Category> listCategory = new List<Category>();
        List<Book> listBook = new List<Book>();
        int bookID = 0;
        Book bookCurrent = new Book();
        public frmThuVien()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategory();
            SetUpSearchInputText();
           
        }
        private void CreatButton(int id, string name, int yPos)
		{
			var btn = new Button();
			btn.Text = name;
			btn.BackColor = Color.DarkOrchid;
			btn.Height = 37;
			btn.Width = 150;
			btn.ForeColor = Color.White;
			btn.Location = new Point(60, yPos);
			DanhSachTheLoai.Controls.Add(btn);
			btn.Tag = id;
            btn.Click += CategoryButton_Click;
		}

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            BookBL bookBL = new BookBL();
            bookID = Convert.ToInt32((sender as Button).Tag);
            listBook = bookBL.GetAll();
            var books = listBook;
            if (bookID > 0)
            {
                books = books.Where(f => f.MaTheLoai == bookID).ToList();
            }
            LoadBookToLvDetail(books);
        }
        private void LoadBookToLvDetail(List<Book> list)
        {
            lsvDanhSach.Items.Clear();
            foreach (var book in list)
            {
                ListViewItem item = new ListViewItem(book.Ma.ToString());
                item.SubItems.Add(book.Name);
                item.SubItems.Add(book.MaTheLoai.ToString());
                item.SubItems.Add(book.TacGia);
                item.SubItems.Add(book.NhaXB);
                item.SubItems.Add(book.NamXB);
                item.SubItems.Add(book.KeSach.ToString());
                item.SubItems.Add(book.VTNgan.ToString());
                item.SubItems.Add(book.TrangThai.ToString()=="0"? "Còn" : "Đã được mượn");
                item.SubItems.Add(book.HinhAnh);
                
                lsvDanhSach.Items.Add(item);
            }


            for (int i = 0; i < lsvDanhSach.Items.Count; i++)
            {
                ListViewItem item = lsvDanhSach.Items[i];
                if (item.SubItems[8].Text == "Đã được mượn")
                {
                    item.BackColor = Color.LightSalmon;
                }
                else
                {
                    item.BackColor = Color.Aquamarine;
                }
              
            }
            

        }
       
        private void LoadCategory()
		{
			CategoryBL category = new CategoryBL();
			listCategory = category.GetAll();
			var yPos = 0;
			CreatButton(0, "Tất cả", yPos);
			foreach (var cat in listCategory)
			{
				yPos += 40;
				CreatButton(cat.ID, cat.Name, yPos);
			}
		}
        private void SetUpSearchInputText()
        {
            txtSearch.Text = PlaceHolderText;
            txtSearch.GotFocus += RemoveText;
            txtSearch.LostFocus += ShowText; 
        }

        private void ShowText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
                txtSearch.Text = PlaceHolderText;
        }

        private void RemoveText(object sender, EventArgs e)
        {
            if (txtSearch.Text == PlaceHolderText)
                txtSearch.Text = "";
        }


    

        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = lsvDanhSach.SelectedItems.Count;
            if (count > 0)
            {              
                bookCurrent = new Book();
                ListViewItem item = lsvDanhSach.SelectedItems[0];
                bookCurrent.Ma = int.Parse(item.SubItems[0].Text);
                bookCurrent.Name = item.SubItems[1].Text;
                bookCurrent.MaTheLoai = int.Parse(item.SubItems[2].Text);
                bookCurrent.TacGia = item.SubItems[3].Text;
                bookCurrent.NhaXB = item.SubItems[4].Text;
                bookCurrent.NamXB = item.SubItems[5].Text;
                bookCurrent.KeSach = int.Parse(item.SubItems[6].Text);
                bookCurrent.VTNgan = int.Parse(item.SubItems[7].Text);
                if(item.SubItems[8].Text == "Còn")
                bookCurrent.TrangThai = 0;
                else bookCurrent.TrangThai = 1;
                bookCurrent.HinhAnh = item.SubItems[9].Text;
                string hinh = lsvDanhSach.SelectedItems[0].SubItems[9].Text;
                try
                {
                    ptbPicture.Load(hinh);
                }
                catch
                {

                }

            }
        }

        private void tsmThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frmThongKe = new frmThongKe();
            frmThongKe.ShowDialog();
        }

        private void tsmThem_Click(object sender, EventArgs e)
        {
            frmSach frmSach = new frmSach();
            frmSach.AddNewBook();
            frmSach.ShowDialog();
            
        }

        private List<Book> FindBooks(int categoryId, string keyword)
        {
            BookBL bookBL = new BookBL();
            listBook = bookBL.GetAll();
            IEnumerable<Book> query = listBook;

            if (categoryId > 0)
            {
                query = query.Where(f => f.MaTheLoai == bookID);
            }
            if (!string.IsNullOrWhiteSpace(keyword) == true && rdSach.Checked)
            {
                query = query.Where(f => f.Name.IndexOf(keyword, StringComparison.InvariantCultureIgnoreCase) >= 0);
            }
            else if (!string.IsNullOrWhiteSpace(keyword) == true && rdTacGia.Checked)
            {
                query = query.Where(f => f.TacGia.IndexOf(keyword, StringComparison.InvariantCultureIgnoreCase) >= 0);
            }
            else if (!string.IsNullOrWhiteSpace(keyword) == true && rdNXB.Checked)
            {
                query = query.Where(f => f.NhaXB.IndexOf(keyword, StringComparison.InvariantCultureIgnoreCase) >= 0);
            }
            return query.ToList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lsvDanhSach.Items.Clear();
            var keyWord = txtSearch.Text;
            var books = FindBooks(bookID, keyWord);
            LoadBookToLvDetail(books);
        }

        private void lsvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            BookBL bookBL = new BookBL();
            listBook = bookBL.GetAll();
            frmSach frmSach = new frmSach(1);
            bookID = 0;
            int count = lsvDanhSach.SelectedItems.Count;
            if(count != 0)
            {
                int ma = int.Parse(lsvDanhSach.SelectedItems[0].SubItems[0].Text);
                string name = lsvDanhSach.SelectedItems[0].SubItems[1].Text;
                int maTheLoai = int.Parse(lsvDanhSach.SelectedItems[0].SubItems[2].Text);
                string tacGia= lsvDanhSach.SelectedItems[0].SubItems[3].Text;
                string nhaXB = lsvDanhSach.SelectedItems[0].SubItems[4].Text;
                string namXB = lsvDanhSach.SelectedItems[0].SubItems[5].Text;
                int keSach = int.Parse(lsvDanhSach.SelectedItems[0].SubItems[6].Text);
                int vtNgan = int.Parse(lsvDanhSach.SelectedItems[0].SubItems[7].Text);
                int trangThai;
                if (lsvDanhSach.SelectedItems[0].SubItems[8].Text == "Còn")
                    trangThai = 0;
                else
                    trangThai = 1;
                string hinhAnh = lsvDanhSach.SelectedItems[0].SubItems[9].Text;
                frmSach.book = new Book(ma, name, namXB, tacGia, nhaXB, trangThai, keSach, vtNgan, maTheLoai -1, hinhAnh);
            }
            if (frmSach.ShowDialog() == DialogResult.OK)
            {
                var books = listBook;
                if (frmSach.book.MaTheLoai > 0)
                {
                    books = books.Where(f => f.MaTheLoai == frmSach.book.MaTheLoai).ToList();
                }
                LoadBookToLvDetail(books);
            }
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá mẫu tin này?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BookBL bookBL = new BookBL();
                if (bookBL.Xoa(bookCurrent) > 0)
                {
                    MessageBox.Show("Xoá cuốn sách thành công");

                    listBook = bookBL.GetAll();
                    LoadBookToLvDetail(listBook);
                }
                else MessageBox.Show("Xoá không thành công");
            }
        }


        private void tsmiMuonSach_Click(object sender, EventArgs e)
        {
            frmMuonTra frmMuon = new frmMuonTra(bookCurrent,1);
            frmMuon.AddNewBorrow();
            frmMuon.ShowDialog();
            if (frmMuon.hasChange)
            {
                BookBL bookBL = new BookBL();
                listBook = bookBL.GetAll();
                LoadBookToLvDetail(listBook);
            }
        }

        private void tsmiTraSach_Click(object sender, EventArgs e)
        {
            frmMuonTra frmTra = new frmMuonTra(bookCurrent,2);
            frmTra.GiveBook();
            frmTra.ShowDialog();
            if (frmTra.hasChange)
            {
                BookBL bookBL = new BookBL();
                listBook = bookBL.GetAll();
                LoadBookToLvDetail(listBook);
            }
        }
    }
}
