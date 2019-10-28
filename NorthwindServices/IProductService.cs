using _10_21_ProductsDapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_21_ProductsDapper.NorthwindServices
{
    public interface IProductsService
    {
        ProductsViewModel GetProducts();
        Product GetProduct(int id);
        ProductsViewModel AddProduct(AddProductViewModel model);
        ProductsViewModel RemoveProduct(int id);
        ProductsViewModel UpdateProduct(int id, Product updatedProduct);
    }
}
