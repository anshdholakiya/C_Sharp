using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class file2
    {
        static void Main(string[] args)
        {
            string str1, str2, str3;
            Console.WriteLine("Enter String 1 : ");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter String 2 : ");
            str2 = Console.ReadLine();

            int len = str1.Length;
            Console.WriteLine("Length of string is :" + len);

            str3 = str1.ToLower();
            Console.WriteLine("string 1 in Lowercase : " + str3);
            str3 = str2.ToUpper();
            Console.WriteLine("string 2 in Lowercase : " + str3);

            str3 = str1 + str2;
            Console.WriteLine("Combine string is : " + str3);

            //using concat method
            str3 = string.Concat(str1, str2);
            Console.WriteLine(str3);

            //interpolation of string
            int no = 100;
            str3 = $"mulitplication of number is : {no * 10}";
            Console.WriteLine("string 3 is : " + str3);
        }
    }
}
