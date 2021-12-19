using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StatisticalDA
    {
        public DataTable TK_Category()
        {

            SqlConnection con = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.TK_TheLoai;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("TK Thể loại");
            adapter.Fill(dt);

            con.Close();
            con.Dispose();
            adapter.Dispose();
            return dt;
        }

        public DataTable TK_Author()
        {

            SqlConnection con = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.TK_TacGia;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("TK Tác giả");
            adapter.Fill(dt);

            con.Close();
            con.Dispose();
            adapter.Dispose();
            return dt;
        }

        public DataTable TK_BorrowedBook()
        {

            SqlConnection con = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.TK_SachMuon;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("TK Sách Mượn chưa trả");
            adapter.Fill(dt);

            con.Close();
            con.Dispose();
            adapter.Dispose();
            return dt;
        }

        public DataTable TK_Time()
        {

            SqlConnection con = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.TK_ThoiGian;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("TK Thời gian mượn trả");
            adapter.Fill(dt);

            con.Close();
            con.Dispose();
            adapter.Dispose();
            return dt;
        }

        public DataTable Get_MT(int maSach)
        {

            SqlConnection con = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Get_MT;
            cmd.Parameters.Add("@MaSach", SqlDbType.Int).Value = maSach;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Lấy thông tin mt");
            adapter.Fill(dt);

            con.Close();
            con.Dispose();
            adapter.Dispose();
            return dt;
        }
    }
}
