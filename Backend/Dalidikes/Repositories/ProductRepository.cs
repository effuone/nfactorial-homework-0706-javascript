using System.Data.SqlClient;
using Dalidikes.Data;
using Dalidikes.Interfaces;
using Dalidikes.Models;
using Dalidikes.ViewModels;
using Dapper;
using System.Data.Common;
using Dapper.Contrib;
using Dalidikes.RequestModels;
using System.Data;

namespace Dalidikes.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DapperContext _dapper;
        private readonly BikeStoresContext _context;

        public ProductRepository(DapperContext dapper, BikeStoresContext context)
        {
            _dapper = dapper;
            _context = context;
        }

        public Task<int> CreateAsync(ProductVm model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductVm>> GetAllAsync(PageLimit limits)
        {
            var list = new List<ProductVm>();
            using(var connection = _dapper.CreateConnection())
            {
                connection.Open();
                string sqlProcedureName = "GetAllProductsById";
                var command = new SqlCommand(sqlProcedureName, (SqlConnection)connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@start", SqlDbType.Int).Value = 1;
                command.Parameters.Add("@end", SqlDbType.Int).Value = limits.ObjectLimit;
                using(var reader = await command.ExecuteReaderAsync())
                {
                    while(await reader.ReadAsync())
                    {
                        var product = new ProductVm();
                        product.ProductId = reader.GetInt32(0);
                        product.ProductName = reader.GetString(1);
                        product.BrandName = reader.GetString(2);
                        product.CategoryName = reader.GetString(3);
                        product.ModelYear = reader.GetInt16(4);
                        product.Price = reader.GetDecimal(5);
                        list.Add(product);
                    }   
                }
                connection.Close();
                return list;
            }
        }

        public Task<ProductVm> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, ProductVm model)
        {
            throw new NotImplementedException();
        }
    }
}