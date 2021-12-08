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
        // lấy chuỗi kết nối từ tập tin App.Config
        private static string StrName = "ConnectionStringName";
        public static string ConnectionString = ConfigurationManager
        .ConnectionStrings[StrName]
        .ConnectionString;

        // các biến thống kê
        public static string TK_TheLoai = "TK_TheLoai";
        public static string TK_TacGia = "TK_TacGia";
        public static string TK_SachMuon = "TK_SachMuon";
        public static string TK_ThoiGian = "TK_ThoiGian";
       
    }
}
