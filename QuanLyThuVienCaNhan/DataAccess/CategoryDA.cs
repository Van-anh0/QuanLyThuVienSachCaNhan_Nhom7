using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;


namespace DataAccess
{
    public class CategoryDA
    {
        public List<Category> GetAll()
        {
            SqlConnection connection = new SqlConnection(Ultilities.ConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Category_GetAll;
            SqlDataReader reader = command.ExecuteReader();
            List<Category> list = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category();
                category.ID = Convert.ToInt32(reader["MaTL"]);
                category.Name = reader["TenTL"].ToString();
                list.Add(category);
            }
            connection.Close();
            return list;           
        }
        public int Them_Xoa_Sua(Category category, int act)
        {
            SqlConnection connection = new SqlConnection(Ultilities.ConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Category_InsertUpdateDelete;
            SqlParameter IDPara = new SqlParameter("@MaTL", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(IDPara).Value = category.ID;
            command.Parameters.Add("@TenTL", SqlDbType.NVarChar, 200).Value = category.Name;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = act;
            int result = command.ExecuteNonQuery();
            if (result > 0)
                return (int)command.Parameters["@MaTL"].Value;
            return 0;
        }
    }
}
