using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_21_ProductsDapper
{
    public class DapperConfiguration
    {
        public Database Database { get; set; }
    }

    public class Database
    {
        public string ConnectionString { get; set; }
    }
}
