using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _10_21_ProductsDapper.DAL;
using _10_21_ProductsDapper.DAL.Models;
using _10_21_ProductsDapper.Models;



namespace _10_21_ProductsDapper.NorthwindServices
{
   
    public class ProductsService : IProductsService
    {
        private readonly IProductsStore _productStore;
        public ProductsService(IProductsStore productStore)
        {
            _productStore = productStore;
        }
        public Product GetProduct(int productId)
        {
            var dalProducts = _productStore.SelectProductByProductId(productId);

            var customer = MapProduct(dalProducts);

            return customer;
        }

        private Product MapProduct(ProductsDALModel item)
        {
            var product = new Product();
            product.ProductName = item.ProductName;
            product.ProductID = item.ProductID;
            product.SupplierID = item.SupplierID;
            product.CategoryID = item.CategoryID;
            product.QuantityPerUnit = item.QuantityPerUnit;
            product.UnitPrice = item.UnitPrice;
            product.UnitsInStock = item.UnitsInStock;
            product.UnitsOnOrder = item.UnitsOnOrder;
            product.ReorderLevel = item.ReorderLevel;
            product.Discontinued = item.Discontinued;

            return product;
        }

        private ProductsViewModel MapProductViewModel(IEnumerable<ProductsDALModel> products)
        {
            var _products = new List<Product>();
            foreach (ProductsDALModel item in products)
            {
                var product = new Product();
                product.ProductName = item.ProductName;
                product.ProductID = item.ProductID;
                product.SupplierID = item.SupplierID;
                product.CategoryID = item.CategoryID;
                product.QuantityPerUnit = item.QuantityPerUnit;
                product.UnitPrice = item.UnitPrice;
                product.UnitsInStock = item.UnitsInStock;
                product.UnitsOnOrder = item.UnitsOnOrder;
                product.ReorderLevel = item.ReorderLevel;
                product.Discontinued = item.Discontinued;
                _products.Add(product);
            }

            var model = new ProductsViewModel();
            model.Products = _products;
            return model;

        }

        public ProductsViewModel GetProducts()
        {
            var dalProducts = _productStore.SelectAllProducts();
            var products = new List<Product>();
            foreach (var item in dalProducts)
            {
                var product = new Product();
                product.ProductName = item.ProductName;
                product.ProductID = item.ProductID;
                product.SupplierID = item.SupplierID;
                product.CategoryID = item.CategoryID;
                product.QuantityPerUnit = item.QuantityPerUnit;
                product.UnitPrice = item.UnitPrice;
                product.UnitsInStock = item.UnitsInStock;
                product.UnitsOnOrder = item.UnitsOnOrder;
                product.ReorderLevel = item.ReorderLevel;
                product.Discontinued = item.Discontinued;

                products.Add(product);
            }

            var productsViewModel = new ProductsViewModel();
            productsViewModel.Products = products;

            return productsViewModel;
        }

        public ProductsViewModel AddProduct(AddProductViewModel model)
        {
            var dalModel = MapToProductDALModel(model);

            _productStore.InsertNewProduct(dalModel);

            var dalProducts = _productStore.SelectAllProducts();

            return MapProductViewModel(dalProducts);
        }

        public ProductsViewModel RemoveProduct(int id)
        {
            _productStore.DeleteProduct(id);
            var dalProducts = _productStore.SelectAllProducts();
            return MapProductViewModel(dalProducts);
        }

        private ProductsDALModel MapToProductDALModel(AddProductViewModel model)
        {
            var dalProduct = new ProductsDALModel();
            dalProduct.ProductName = model.ProductName;
            dalProduct.UnitPrice = model.UnitPrice;
            dalProduct.UnitsInStock = model.UnitsInStock;
            dalProduct.Discontinued = false;
            //dalProduct.ProductID = Guid.NewGuid().ToString().Substring(0, 5);
            return dalProduct;
        }

        public ProductsViewModel UpdateProduct(int id, Product updatedProduct)
        {
            var isProductUpdated = _productStore.UpdateProduct(id, updatedProduct);
            var dalProducts = _productStore.SelectAllProducts();

            return MapProductViewModel(dalProducts);

        }
    }
}
