//Write a C# Sharp program to compare two strings in following three different ways produce three different results

//Break the sentence into words (including spaces) and arrange from the end

using System;

namespace STRING01
{
    class STRING01
    {
        static void Main(string[] args)
        {
            string[] str = "Ala ma kota".Split(new[] { "" }, StringSplitOptions.None);
            string reversStr = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversStr += str[i].ToString();
            }
            Console.WriteLine(reversStr.ToString());
            Console.ReadLine();  
        }
    }
}
