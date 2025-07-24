using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ary = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("MAX : " + ary.Max());
            Console.WriteLine("MIN : " + ary.Min());

            //Console.WriteLine(ary.Reverse());

            var reverse = ary.Reverse();
            foreach (int i in reverse)
            {

                Console.Write(i + " ");
            }





            Array.Sort(ary);
            foreach (int i in ary)
            {

                Console.Write(i + " ");
            }
        }
    }
}
