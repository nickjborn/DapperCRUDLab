using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_21_ProductsDapper.Models
{
    public class AddProductViewModel
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
