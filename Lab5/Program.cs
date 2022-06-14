using System;
using System.Data.SqlClient;

namespace Lab5
{
    class Program
    {
        public static void Main(string[] args)
        {
            GetData();
        }
        public static void GetData()
        {
            SqlConnectiondb connectionString = new SqlConnectiondb();
            SqlConnection connection =connectionString.GetSqlConnection();

           
            string query = "select * from product";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("product name:" + reader[1]);
                
            }
            connection.Close();

        }
        public static void CreateData(Product product)
        {
            SqlConnectiondb sqlConnectiondb = new SqlConnectiondb();
            SqlConnection conn = sqlConnectiondb.GetSqlConnection();
            string query = "INSERT INTO Product values(@proName,@proDesc,@price)";
            SqlCommand command= new SqlCommand(query,conn);
            SqlParameter proName = new SqlParameter("@proName", product.proName);
            SqlParameter proDesc = new SqlParameter("@proDesc", product.proDesc);
            SqlParameter price = new SqlParameter("@price", product.price);
            command.Parameters.Add(proName);
            command.Parameters.Add(proDesc);
            command.Parameters.Add(price);
            conn.Open();
            int dataCount=command.ExecuteNonQuery();
            Console.WriteLine("Them ban ghi {0} thanh cong",dataCount);
            conn.Close();
        }
        public static void DeleteData(string name)
        {

            SqlConnectiondb sqlConnectiondb = new SqlConnectiondb();
            SqlConnection conn = sqlConnectiondb.GetSqlConnection();

            string queery = "DELETE FROM Product WHERE proName=@proName";
            SqlCommand command = new SqlCommand(queery,conn);
            SqlParameter proName = new SqlParameter("@proName", name);
            command.Parameters.Add(proName);
            conn.Open();
            int dataCount = command.ExecuteNonQuery();
            Console.WriteLine("Delete " + dataCount + "success");
        }
    }
}