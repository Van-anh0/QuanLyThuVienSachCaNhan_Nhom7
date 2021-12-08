using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public class Ultilities
    {
        private static string StrName = "ConnectionStringName";
        public static string ConnectionString = ConfigurationManager
        .ConnectionStrings[StrName]
        .ConnectionString;
        public static string Category_GetAll = "Category_GetAll";
        public static string Book_GetAll = "Book_GetAll";
        public static string TimKiem_Book = "TimKiem_Book";
        public static string Book_InsertUpdateDelete = "Book_InsertUpdateDelete";

    }
}
