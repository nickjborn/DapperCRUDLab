using _10_21_ProductsDapper.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace _10_21_ProductsDapper.DAL.Models
{
    public class ProductsStore : IProductsStore
    {
        private readonly Database _config;
        public ProductsStore(DapperConfiguration config)
        {
            _config = config.Database;
        }
        public IEnumerable<ProductsDALModel> SelectAllProducts()
        {
            var sql = @"SELECT * FROM Products";
            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Query<ProductsDALModel>(sql) ?? new List<ProductsDALModel>();
                return result;
            }
        }

        public ProductsDALModel SelectProductByProductId(int ProductId)
        {
            var sql = @"select * from Products where ProductID = @ProductId";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.QueryFirstOrDefault<ProductsDALModel>(sql, new { ProductID = ProductId });
                return result;
            }
        }

        public bool DeleteProduct(int ProductId/*, IEnumberable<ProductsDALModel> dalModel*/)
        {
            var sql = @"delete from Products where ProductID = @ProductId";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Execute(sql, new {ProductID = ProductId});
                return true;
            }
        }

        public bool UpdateProduct(int ProductId, Product updatedProduct)
        {
            updatedProduct.ProductID = ProductId;

            var sql = @"update Products Set ProductName = @ProductName, 
                                            QuantityPerUnit = @QuantityPerUnit,
                                            UnitPrice = @UnitPrice,
                                            UnitsInStock = @UnitsInStock,
                                            UnitsOnOrder = @UnitsOnOrder,
                                            ReorderLevel = @ReorderLevel,
                                            Discontinued = @Discontinued
                                            where ProductID = @ProductId";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Execute(sql, updatedProduct);
                return true;
            }
        }

        public bool InsertNewProduct(ProductsDALModel dalModel)
        {
            var sql = $@"Insert INTO Products (ProductName, UnitPrice, UnitsInStock, Discontinued) 
                        Values (@{nameof(dalModel.ProductName)}, @{nameof(dalModel.UnitPrice)}, @{nameof(dalModel.UnitsInStock)}, @{nameof(dalModel.Discontinued)})"; // @{nameof(dalModel.ProductID)}

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Execute(sql, dalModel);

                return true;
            }
        }
    }
}
