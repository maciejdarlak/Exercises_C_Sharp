using System;

/* The key is the Linq: Count () method.
Linq is shorter than the loop (here foreach for example).
The method returns the number of elements in the sequence, so all you have to do is assign it to some variable.
Later, the classic conditional notation:
condition? option 1 if the condition is met: option 2 if not */

namespace STRING12
{
    class STRING12
    {
        static void Main(string[] args)
        {
            Console.WriteLine(""Please input a string."");
            string input = Console.ReadLine();
            int count = input.Count(x => x == 'w');
            Console.WriteLine(count >= 1 && count <= 3 ? ""True"" : ""False"");
            Console.ReadKey();
        }
    }
}
