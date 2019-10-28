using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _10_21_ProductsDapper.DAL.Models;
using _10_21_ProductsDapper.Models;
using _10_21_ProductsDapper.NorthwindServices;
using Microsoft.AspNetCore.Mvc;

namespace _10_21_ProductsDapper.Controllers
{
    public class NorthwindController : Controller
    {
        private readonly IProductsService _productsService;

        public NorthwindController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        public IActionResult ProductsView()
        {
            var result = _productsService.GetProducts();
            return View(result);
        }

        public IActionResult UpdateProductView(int id)
        {
            var product = _productsService.GetProduct(id);
            return View(product);
        }

        public IActionResult UpdateProductViewResult(int id, Product product)
        {
            var updatedProduct = _productsService.UpdateProduct(id, product);
            var view = _productsService.GetProducts();
            return View("ProductsView", view);
        }

        public IActionResult ProductView(int id)
        {
            var product = _productsService.GetProduct(id);
            return View(product);
        }

        public IActionResult AddProduct()
        {

            return View();
        }

        public IActionResult DeleteProductResult(int id)
        {
            var productsViewModel = _productsService.RemoveProduct(id);
            
            return View("ProductsView", productsViewModel);
        }

        public IActionResult AddProductResult(AddProductViewModel model)
        {
            var productsViewModel = _productsService.AddProduct(model);

            return View("ProductsView", productsViewModel);

        }

        private ProductsDALModel MapToDALProduct(AddProductViewModel src)
        {
            var productsDALModel = new ProductsDALModel();
            productsDALModel.ProductName = src.ProductName;
            productsDALModel.UnitPrice = src.UnitPrice;
            productsDALModel.UnitsInStock = src.UnitsInStock;
            return productsDALModel;

        }
    }
}