using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI_01.Models;

namespace DI_01.Models
{
    public class Repository : IRepository //Adding this interface is essential - it is linked to any model in the Startup file.
    {
        private IStorage storage;
        public Repository(IStorage repo) //IRepository object in turn depends upon IStorage object.
        {
            storage = repo;
            new List<Product> {
                new Product { Name = "Women Shoes", Price = 99M },
                new Product { Name = "Skirts", Price = 29.99M },
                new Product { Name = "Pants", Price = 40.5M }
            }.ForEach(p => AddProduct(p)); //Method AddProduct creates keys for valuaes in dictionary products.
        }

        public IEnumerable<Product> Products => storage.Items;

        public Product this[string name] => storage[name];

        public void AddProduct(Product product) => storage[product.Name] = product;

        public void DeleteProduct(Product product) => storage.RemoveItem(product.Name);
    }
}
