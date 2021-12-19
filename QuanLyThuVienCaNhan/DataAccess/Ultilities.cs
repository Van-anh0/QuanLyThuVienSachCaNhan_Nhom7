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
        public static string Category_InsertUpdateDelete = "Category_InsertUpdateDelete";
        public static string Book_InsertUpdateDelete = "Book_InsertUpdateDelete";
        public static string TK_TheLoai = "TK_TheLoai";
        public static string TK_TacGia = "TK_TacGia";
        public static string TK_SachMuon = "TK_SachMuon";
        public static string TK_ThoiGian = "TK_ThoiGian";
        public static string ThemBanDoc = "Them_BanDoc";
        public static string ThemMuonTra = "Them_MuonTra";
        public static string Update_MuonTra = "Update_MuonTra";
        public static string Update_TrangThaiSach = "Update_TrangThaiSach";
        public static string Get_MT = "Get_MT";

    }
}
