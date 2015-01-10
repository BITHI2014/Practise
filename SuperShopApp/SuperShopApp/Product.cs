using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopApp
{
    class Product
    {
        public string Id { set; get; }
        public int Quantity { set; get; }

        public Product(string id,int quantity)
        {
            Id = id;
            Quantity = quantity;
        }
    }
}
