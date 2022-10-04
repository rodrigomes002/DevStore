using DevStore.API.Models;
using System.Data.SqlClient;

namespace DevStore.API.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly string connectionString;
        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Product> List()
        {
            var products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var sql = "SELECT Id,Name,Price FROM Product";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    connection.Open();

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            var product = this.Map(sdr);
                            products.Add(product);
                        }
                    }
                }
                connection.Close();
            }
            return products;
        }

        private Product Map(SqlDataReader dataReader)
        {
            return new Product()
            {
                Id = (int)dataReader["Id"],
                Name = (string)dataReader["Name"],
                Price = (decimal?)dataReader["Price"]
            };
        }
    }
}
