using System;
using System.Linq;


namespace _CSHARP_COLLECTIONS_EXERCISES_06
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] array1 = new object[] { 1, 2, "a", "b" };
            TrueTimes trueTimes = new TrueTimes();
            var result = trueTimes.ParseArray(array1);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public class TrueTimes
        {
            public string[] ParseArray(object[] array1)
            {
                var array2 = array1.Select(x => x.ToString()).ToArray();
                return array2;

                //var array2 = Array.ConvertAll(array1, x => x.ToString());
                //return array2;
            }
        }
    }
}
