using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopApp
{
    class Shop
    {
        public string Name { set; get; }
        public string Addresss { set; get; }
        private Dictionary<string, Product> products;
        public Shop(string name, string address):this()
        {
            Name = name;
            Addresss = address;
        }
        public Shop()
        {
            products=new Dictionary<string, Product>();
        }

        public void AddItem(string id, Product aProduct)
        {
            if (products.ContainsKey(id))
                products[id].Quantity += aProduct.Quantity;
            else
                products.Add(id,aProduct);
        }

        public Product[] GetAllProducts()
        {
            return products.Values.ToArray();
        }
    }
}
