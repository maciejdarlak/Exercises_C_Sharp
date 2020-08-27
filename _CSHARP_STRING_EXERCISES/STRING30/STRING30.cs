//Write a C # program to reverse the strings contained in each pair of matching brackets in a given string, and also remove the brackets in that string.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRING30
{
    class STRING30
    {
        static void Main(string[] args)
        {
            static string reverse_remove_parentheses(string str)
            {
                //LastIndexOf () looks for the specified character from the end of the array.
                int lid = str.LastIndexOf('(');  //Zwraca nr indeksu '('

                if (lid == -1)
                {
                    return str;
                }
                else
                {
                    //IndexOf () searches for the specified character from the beginning
                    int rid = str.IndexOf(')', lid);  //Returns index number for ')': it is searched from the lid index to the right

                    //Recursion below - the mretoda calls itself but in the parameter it is trimmed by the content of the innermost brace
                    return reverse_remove_parentheses
                        (
                          str.Substring(0, lid)  //From to index before parenthesis
                        + new string(str.Substring(lid + 1, rid - lid - 1).Reverse().ToArray())  //Moving to another array using the Array () method
                        + str.Substring(rid + 1)  //From index outside the brace to the end of the string
                        );
                }
            }

            static void Main()
            {
                Console.WriteLine(reverse_remove_parentheses("1(2(3(45)6)7)8"));
                Console.ReadKey();
            }
        }
    }
}
