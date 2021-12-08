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
    public partial class ThemTL : Form
    {
        List<Category> listCategory = new List<Category>();
        public ThemTL()
        {
            InitializeComponent();
        }
        public int Them()
        {
            Category category = new Category();
            category.ID = 0;
            if (txtName.Text == "")
                MessageBox.Show("Vui lòng nhập tên thể loại bạn muốn thêm !!!", "Nhắc nhở!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                category.Name = txtName.Text;
                category.ID = int.Parse(cbbTheLoai.SelectedValue.ToString());
                CategoryBL categoryBL = new CategoryBL();
                return categoryBL.ThemTL(category);
            }
                return -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int result = Them();
              if (result > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công");
                    LoadData();
                }
                else MessageBox.Show("Đã trùng dữ liệu!!!");           
        }

        private void ThemTL_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            CategoryBL category = new CategoryBL();
            listCategory = category.GetAll();
            cbbTheLoai.DataSource = listCategory;
            cbbTheLoai.DisplayMember = "Name";
            cbbTheLoai.ValueMember = "ID";
            
        }
       
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá mẫu tin này?", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                category.Name = txtName.Text;
                category.ID = int.Parse(cbbTheLoai.SelectedValue.ToString());
                CategoryBL category1 = new CategoryBL();
                if (category1.Xoa(category) > 0)
                {
                    MessageBox.Show("Xoá thành công");
                    LoadData();
                }
                else MessageBox.Show("Xoá không thành công");
            }

        }
        public int Sua()
        {
            Category category = new Category();
            if (txtName.Text == "")
                MessageBox.Show("Vui lòng nhập tên thể loại bạn muốn sửa !!!", "Nhắc nhở!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                category.Name = txtName.Text;
                category.ID = int.Parse(cbbTheLoai.SelectedValue.ToString());
                CategoryBL categoryBL = new CategoryBL();
                return categoryBL.Sua(category);
            }
            return -1;
        }

        private void cbbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var cate in listCategory)
            {
                if (cbbTheLoai.SelectedItem == cate)
                {
                    txtName.Text = cate.Name;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int result2 = Sua();
            if (result2 > 0)
            {
                MessageBox.Show("Sửa thành công thể loại!!");
                LoadData();
            }
            else MessageBox.Show("Không thành công");
        }
    }
}
