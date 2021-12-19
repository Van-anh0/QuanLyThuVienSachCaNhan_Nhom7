using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MuonTraDA
    {
        public int ThemMuon(int IdBD, int maSach, DateTime ngayMuon, DateTime ngayTra)
        {

            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.ThemMuonTra;


            command.Parameters.Add("@ID", SqlDbType.Int).Value = IdBD;
            command.Parameters.Add("@MaSach", SqlDbType.Int).Value = maSach;
            command.Parameters.Add("@NgayMuon", SqlDbType.SmallDateTime).Value = ngayMuon;
            if (ngayTra == new DateTime(2001, 1, 1))
                command.Parameters.Add("@NgayTra", SqlDbType.SmallDateTime).Value = DBNull.Value;



            int result = command.ExecuteNonQuery();
            if (result > 0)
                return result;
            return 0;
        }

        public int ThemTra(int IdBD, int maSach, DateTime ngayTra)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Update_MuonTra;


            command.Parameters.Add("@ID", SqlDbType.Int).Value = IdBD;
            command.Parameters.Add("@MaSach", SqlDbType.Int).Value = maSach;
            
            
            command.Parameters.Add("@NgayTra", SqlDbType.SmallDateTime).Value = ngayTra;



            int result = command.ExecuteNonQuery();
            if (result > 0)
                return result;
            return 0;
        }
    }

}
