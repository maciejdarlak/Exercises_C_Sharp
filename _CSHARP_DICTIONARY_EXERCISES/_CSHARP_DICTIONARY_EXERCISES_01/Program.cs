using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CSHARP_DICTIONARY_EXERCISES_01
class Program
{
    static void Main(string[] args)
    {
        Package p = new Package();
        Console.WriteLine(p.ToString());
        Console.ReadKey();
    }

    public class Package
    {
        public string Company { get; set; }
        public double Weight { get; set; }
        public long TrackingNumber { get; set; }
    }

    public void ToDictionary()
    {
        List<Package> packages =
            new List<Package>
                {
                    new Package { Company = "Coho Vineyard", Weight = 25.2, TrackingNumber = 89453312L },
                    new Package { Company = "Lucerne Publishing", Weight = 18.7, TrackingNumber = 89112755L },
                    new Package { Company = "Wingtip Toys", Weight = 6.0, TrackingNumber = 299456122L },
                    new Package { Company = "Adventure Works", Weight = 33.8, TrackingNumber = 4665518773L }
                };

        Dictionary<long, Package> dictionary = packages.ToDictionary(p => p.TrackingNumber);

        foreach (KeyValuePair<long, Package> kvp in dictionary)
        {
            Console.WriteLine(
                "Key {0}: {1}, {2} pounds",
                kvp.Key,
                kvp.Value.Company,
                kvp.Value.Weight);
        }
    }
}
}
