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
        public int Them(Book book)
        {
            return bookDA.Them_Sua_Xoa(book, 0);
        }
        public int Sua(Book book)
        {
            return bookDA.Them_Sua_Xoa(book, 1);
        }
        public int Xoa(Book book)
        {
            return bookDA.Them_Sua_Xoa(book, 2);
        }

        public int SuaTT(Book book)
        {
            return bookDA.SuaTrangThai(book);
        }

    }
}
