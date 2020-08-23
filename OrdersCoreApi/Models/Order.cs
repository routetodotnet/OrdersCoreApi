using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersCoreApi.Models
{
    public class Order
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
    }
}
