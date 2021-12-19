using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BookDA
    {
        public List<Book> GetAll()
        {
            SqlConnection connection = new SqlConnection(Ultilities.ConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Book_GetAll;
            SqlDataReader reader = command.ExecuteReader();
            List<Book> list = new List<Book>();
            while (reader.Read())
            {
                Book book = new Book();
                book.Ma = Convert.ToInt32(reader["MaSach"]);
                book.Name = reader["TenSach"].ToString();
                book.MaTheLoai = Convert.ToInt32(reader["MaTL"]);
                book.TacGia = reader["TacGia"].ToString();
                book.NhaXB = reader["NXB"].ToString();
                book.NamXB = reader["NamXB"].ToString();
                book.HinhAnh = reader["Hinh"].ToString();
                book.KeSach = Convert.ToInt32(reader["KeSach"]);
                book.VTNgan = Convert.ToInt32(reader["VTNgan"]);
                book.TrangThai = Convert.ToInt32(reader["TrangThai"]);
                list.Add(book);
            }
            connection.Close();
            return list;
        }
        public int Them_Sua_Xoa(Book book, int act)
        {

            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Book_InsertUpdateDelete;
            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(IDPara).Value = book.Ma;
            command.Parameters.Add("@TenSach", SqlDbType.NVarChar, 200).Value = book.Name;
            command.Parameters.Add("@NamXB", SqlDbType.NVarChar,10).Value = book.NamXB;
            command.Parameters.Add("@TacGia", SqlDbType.NVarChar,100).Value = book.TacGia;
            command.Parameters.Add("@NhaXB", SqlDbType.NVarChar,100).Value = book.NhaXB;
            command.Parameters.Add("@TrangThai", SqlDbType.Bit).Value = book.TrangThai;
            command.Parameters.Add("@KeSach", SqlDbType.Int).Value = book.KeSach;
            command.Parameters.Add("@VTNgan", SqlDbType.Int).Value = book.VTNgan;
            command.Parameters.Add("@MaTL", SqlDbType.Int).Value = book.MaTheLoai;
            command.Parameters.Add("@Hinh", SqlDbType.NVarChar, 200).Value = book.HinhAnh;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = act;
            int result = command.ExecuteNonQuery();
            if (result > 0)
                return (int)command.Parameters["@ID"].Value;
            return 0;
        }

        public int SuaTrangThai(Book book)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Update_TrangThaiSach;
            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(IDPara).Value = book.Ma;
           
            command.Parameters.Add("@TrangThai", SqlDbType.Bit).Value = book.TrangThai;
            
            int result = command.ExecuteNonQuery();
            if (result > 0)
                return result;
            return 0;
        }
    }
}
