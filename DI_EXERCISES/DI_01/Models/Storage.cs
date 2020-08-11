using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using DI_01.Models;


// This class allows additionally add a key.
namespace DI_01.Models
{
    public class Storage : IStorage
    {
        private Dictionary<string, Product> items = new Dictionary<string, Product>();
        public Product this[string key]
        {
            get { return items[key]; }
            set { items[key] = value; }
        }
        public IEnumerable<Product> Items => items.Values;
        public bool ContainsKey(string key) => items.ContainsKey(key);
        public void RemoveItem(string key) => items.Remove(key);
    }
}

