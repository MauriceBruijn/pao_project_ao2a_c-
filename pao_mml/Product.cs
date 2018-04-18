using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pao_mml
{
    public class Product
    {
        public string id { get; set; }

        public string name { get; set; }
        public  string brand { get; set; }
        public string color { get; set; }
        public string price { get; set; }
        public string description { get; set; }
        public string img { get; set; }
    }

    public class ProductList
    {
        public BindingList<Product> Products { get; set; }
    }
}
