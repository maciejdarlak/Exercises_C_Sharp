//Write a C # program to find a pair of adjacent items that have the largest product of a given array that is equal to the given requested value.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*In the arrayProduct method, find the product of the largest value of the array with the neighbor.
The method returns the variable "product".

Now you need to complete the form:
value to compare
loam. array elements
initialization of the array with the above value as an index
adding value to array elements (for loop is used when creating a collection, it is better than foreach - fewer rows, has a start and end delimiter)

Now you have to compare the value entered with the product of the arrayProduct method.

It is important that to use a method outside the Main () method, you must initialize the entire class.
The same with the board.*/

namespace STRING25
{
    class STRING25
    {
        static void Main(string[] args)
        {
            //Entering the value for the final comparison
            Console.WriteLine("Please write a desireable volume.");
            int desireableValue = Convert.ToInt32(Console.ReadLine());

            //Required number of array elements
            Console.WriteLine("\nPlease write how many numbers do you want to input in Array. You have to write more than two.");
            int arrayNumber = Convert.ToInt32(Console.ReadLine());

            //Initialization of the array with the required number of elements
            int[] array = new int[arrayNumber];

            //Giving value to each element of the array
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("\nPlease write an input.");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Compare the values to compare with the largest array value
            Console.WriteLine("\n");
            STRING25 necessaryObject = new STRING25();
            Console.WriteLine(desireableValue == necessaryObject.arrayProduct(array) ? true : false);
            Console.ReadKey();
        }
    }

    public int arrayProduct(int[] array)
    {
        int array_index = 0;
        int product = array[array_index] * array[array_index + 1];

        array_index++;
        while (array_index + 1 < array.Length)
        {
            product = ((array[array_index] * array[array_index + 1]) > product) ?
                       (array[array_index] * array[array_index + 1]) :
                        product;
            array_index++;
        }
        return product;
    }
}
