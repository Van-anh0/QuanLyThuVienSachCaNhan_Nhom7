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

namespace QuanLyThuVienCaNhan
{
    public partial class frmMuonTra : Form
    {
        public frmMuonTra()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {


            // if (txtTen.Text == "" || txtDiaChi.Text == "" || mtbSDT.Text == "")
            //     MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại","Thông  báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //  else
            //      MessageBox.Show("mượn sách thành công, đã lưu thông tin người mượn","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            string s = "";
            s += "\tHọ và tên: " + txtTen.Text.Trim() + "\r\n";
            s += "\tĐịa chỉ: " + txtDiaChi.Text.Trim() + "\r\n";
            s += "\tSố điện thoại: " + mtbSDT.Text.Trim() + "\r\n";
            s += "\tNgày mượn: " + dtpDateMuon.Value.ToShortDateString() + "\r\n";
            txtThongTin.Text = s;
        }
    }
}
