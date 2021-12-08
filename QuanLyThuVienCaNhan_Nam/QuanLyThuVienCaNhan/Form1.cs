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
    public partial class Form1 : Form
    {
        private const string PlaceHolderText = "Nhập thông tin cuốn sách cần tìm !!!!!";
        List<Category> listCategory = new List<Category>();
        List<Book> listBook = new List<Book>();
        int bookID = 0;
        Book bookCurrent = new Book();
        public Form1()
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
			btn.Height = 50;
			btn.Width = 240;
			btn.ForeColor = Color.White;
			btn.Location = new Point(0, yPos);
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
            LoadFoodToLvDetail(books);
        }
        private void LoadFoodToLvDetail(List<Book> list)
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
                item.SubItems.Add(book.TrangThai.ToString());
                item.SubItems.Add(book.HinhAnh);
                lsvDanhSach.Items.Add(item);
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
				yPos += 45;
				CreatButton(cat.ID, cat.Name, yPos);
			}
		}
      
        private void tsmiMuonSach_Click(object sender, EventArgs e)
        {
            frmMuonTra frmMuon = new frmMuonTra();
            frmMuon.ShowDialog();
        }

        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void tsmThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frmThongKe = new frmThongKe();
            frmThongKe.ShowDialog();
        }

        private void tsmThem_Click(object sender, EventArgs e)
        {
            frmSach frmSach = new frmSach();
            frmSach.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            test test = new test();
            test.ShowDialog();
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
            LoadFoodToLvDetail(books);
        }
        private void SetUpSearchInputText()
        {
            txtSearch.Text = PlaceHolderText;
            txtSearch.GotFocus += RemovePlaceHolderText;
            txtSearch.LostFocus += ShowPlaceHolderText;
        }
        private void ShowPlaceHolderText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
                txtSearch.Text = PlaceHolderText;
        }
        private void RemovePlaceHolderText(object sender, EventArgs e)
        {
            if (txtSearch.Text == PlaceHolderText)
                txtSearch.Text = "";
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
                int trangThai =int.Parse(lsvDanhSach.SelectedItems[0].SubItems[8].Text);
                string hinhAnh= lsvDanhSach.SelectedItems[0].SubItems[9].Text;
                frmSach.book = new Book(ma, name, namXB, tacGia, nhaXB, trangThai, keSach, vtNgan, maTheLoai -1, hinhAnh);
            }
            if (frmSach.ShowDialog() == DialogResult.OK)
            {
                var books = listBook;
                if (frmSach.book.MaTheLoai > 0)
                {
                    books = books.Where(f => f.MaTheLoai == frmSach.book.MaTheLoai).ToList();
                }
                LoadFoodToLvDetail(books);
            }
        }

        private void DanhSachTheLoai_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadBookDataToListView()
        {
            BookBL bookBL = new BookBL();
            listBook = bookBL.GetAll();
            int count = 1; 
            lsvDanhSach.Items.Clear();
            foreach (var book in listBook)
            {
                ListViewItem item = lsvDanhSach.Items.Add(count.ToString());
                item.SubItems.Add(book.Name);
                item.SubItems.Add(book.MaTheLoai.ToString());
                item.SubItems.Add(book.TacGia);
                item.SubItems.Add(book.NhaXB);
                item.SubItems.Add(book.NamXB);
                item.SubItems.Add(book.KeSach.ToString());
                item.SubItems.Add(book.VTNgan.ToString());
                item.SubItems.Add(book.TrangThai.ToString());
                string foodName = listCategory
                .Find(x => x.ID == book.MaTheLoai).Name;
                item.SubItems.Add(foodName);
                item.SubItems.Add(book.HinhAnh);
                count++;
            }
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá mẫu tin này?", "Thông báo",
             MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BookBL bookBL = new BookBL();
                if (bookBL.Delete(bookCurrent) > 0)
                {
                    MessageBox.Show("Xoá cuốn sách thành công");
                    LoadBookDataToListView();
                }
                else MessageBox.Show("Xoá không thành công");
            }
        }

        private void tsmiTraSach_Click(object sender, EventArgs e)
        {
            ////Gọi đối tượng BookBL từ tầng BusinessLogic
            //BookBL bookBL = new BookBL();
            //// Lấy dữ liệu
            //listBook = bookBL.GetAll();
            //int count = 1; // Biến số thứ tự
            //               // Xoá dữ liệu trong ListView
            //lsvDanhSach.Items.Clear();
            //// Duyệt mảng dữ liệu để đưa vào ListView
            //foreach (var book in listBook)
            //{
            //    // Số thứ tự
            //    ListViewItem item = lsvDanhSach.Items.Add(count.ToString());
            //    item.SubItems.Add(book.Name);
            //    item.SubItems.Add(book.MaTheLoai.ToString());
            //    item.SubItems.Add(book.TacGia);
            //    item.SubItems.Add(book.NhaXB);
            //    item.SubItems.Add(book.NamXB);              
            //    item.SubItems.Add(book.KeSach.ToString());
            //    item.SubItems.Add(book.VTNgan.ToString());
            //    item.SubItems.Add(book.TrangThai.ToString());


            //    // Theo dữ liệu của bảng Category ID, lấy Name để hiển thị
            //    string bookName = listCategory
            //    .Find(x => x.ID == book.MaTheLoai).Name;
            //    item.SubItems.Add(bookName);
            //    // Đưa dữ liệu Notes vào cột cuối
            //    item.SubItems.Add(book.HinhAnh);
            //    count++;
            //}

           // BookBL bookBL = new BookBL();
           // listBook = bookBL.GetAll();
            if(lsvDanhSach.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvDanhSach.SelectedItems[0];
                if(item.SubItems[8].Text != "1")
                {
                    MessageBox.Show("Sách chưa được mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
                else
                {
                    MessageBox.Show("Trả sách thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    item.SubItems[8].Text = "0";

                }
                
            }
            
        }
        private void MuonSach()
            {
                if (lsvDanhSach.SelectedItems.Count > 0)
                {
                    ListViewItem item = lsvDanhSach.SelectedItems[0];
                    item.SubItems[8].Text = "1";

                }
            }
    }
}
