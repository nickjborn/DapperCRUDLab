using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_21_ProductsDapper.Models
{
    public class ProductsViewModel
    {
        public IEnumerable<Product> Products { get; set; }

        //public string ProductId { get; set; }
        //public string ProductName { get; set; }
    }

}
