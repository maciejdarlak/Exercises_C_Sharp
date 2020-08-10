using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_01.Models
{
    public interface IStorage
    {
        IEnumerable<Product> Items { get; }
        Product this[string key] { get; set; }
        bool ContainsKey(string key);
        void RemoveItem(string key);
    }
}
