using _10_21_ProductsDapper.DAL.Models;
using _10_21_ProductsDapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_21_ProductsDapper.DAL
{
    public interface IProductsStore
    {
        IEnumerable<ProductsDALModel> SelectAllProducts();
        ProductsDALModel SelectProductByProductId(int ProductId);
        bool InsertNewProduct(ProductsDALModel dalModel);
        bool DeleteProduct(int ProductId);
        bool UpdateProduct(int ProductId, Product updatedProduct);




    }
}
