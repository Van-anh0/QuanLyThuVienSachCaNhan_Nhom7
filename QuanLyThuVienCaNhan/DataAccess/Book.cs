using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Book
    {
        public int Ma { get; set; }
        public string Name { get; set; }
        public string HinhAnh { get; set; }
        public string NamXB { get; set; }
        public string TacGia { get; set; }
        public string NhaXB { get; set; }
        public int TrangThai { get; set; }
        public int KeSach { get; set; }
        public int VTNgan { get; set; }
        public int MaTheLoai { get; set; }
        public Book()
        {

        }
        public Book(int ma, string name, string namXB, string tacGia, string nhaXB, int trangThai, int keSach, int vtNgan, int maTheLoai,string hinhAnh)
        {
            Ma = ma;
            Name = name;
            NamXB = namXB;
            TacGia = tacGia;
            NhaXB = nhaXB;
            TrangThai = trangThai;
            KeSach = keSach;
            VTNgan = vtNgan;
            MaTheLoai = maTheLoai;
            HinhAnh = hinhAnh;
        }
    }
}
