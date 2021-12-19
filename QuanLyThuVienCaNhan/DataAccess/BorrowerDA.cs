using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class BorrowerDA
    {
        public int ThemBD(Borrower borrower)
        {

            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.ThemBanDoc;
            SqlParameter IDPara = new SqlParameter("@MaBD", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;

            //
            command.Parameters.Add(IDPara).Value = 0;
            command.Parameters.Add("@TenBD", SqlDbType.NVarChar, 1000).Value = borrower.Ten;
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 1000).Value = borrower.DiaChi;
            command.Parameters.Add("@SDT", SqlDbType.NVarChar, 100).Value = borrower.SDT;


            int result = command.ExecuteNonQuery();
            if (result > 0)
                return (int)command.Parameters["@MaBD"].Value;
            return 0;
        }

        public int SuaBD(Borrower borrower)
        {
            string query = "UPDATE BanDoc SET DiaChi = @DiaChi, SDT = @SDT OUTPUT INSERTED.* WHERE ten = @TenBD";
            string numberID = "0";
            int numberIDReturn = -1;
            using (SqlConnection con = new SqlConnection(Ultilities.ConnectionString))
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@TenBD", SqlDbType.NVarChar, 1000).Value = borrower.Ten;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 1000).Value = borrower.DiaChi;
                    cmd.Parameters.Add("@SDT", SqlDbType.NVarChar, 100).Value = borrower.SDT;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            numberID = reader["ID"].ToString();
                        }
                    }
                }
                numberIDReturn = int.Parse(numberID);
            }
            return numberIDReturn;
        }
    }
}
