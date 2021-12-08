using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class BookBL
    {
        BookDA bookDA = new BookDA();
        public List<Book> GetAll()
        {
            return bookDA.GetAll();
        }
        public List<Book> TimTheoTen()
        {
            return bookDA.TimTheoTen();
        }
        //Phương thức thêm dữ liệu
        public int Insert(Book food)
        {
            return bookDA.Insert_Update_Delete(food, 0);
        }
        //Phương thức cập nhật dữ liệu
        public int Update(Book food)
        {
            return bookDA.Insert_Update_Delete(food, 1);
        }
        //Phương thức xoá dữ liệu với ID cho trước
        public int Delete(Book food)
        {
            return bookDA.Insert_Update_Delete(food, 2);
        }
    }
}
