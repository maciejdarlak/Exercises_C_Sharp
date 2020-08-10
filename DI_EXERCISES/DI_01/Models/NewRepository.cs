using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_01.Models
{
    public class NewRepository : IRepository //Adding this interface is essential - it is linked to any model in the Startup file.
    {
        private Dictionary<string, Product> products;
        public NewRepository()
        {
            products = new Dictionary<string, Product>();
            new List<Product>
            {
                 new Product { Name = "Dog Shoes", Price = 1M },
            }.ForEach(p => AddProduct(p)); //Method AddProduct creates keys for valuaes in dictionary products.
        }
        public IEnumerable<Product> Products => products.Values;
        public Product this[string name] => products[name];
        public void AddProduct(Product product) => products[product.Name] = product;
        public void DeleteProduct(Product product) => products.Remove(product.Name);
    }
}
