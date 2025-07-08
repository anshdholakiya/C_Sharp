using System;

namespace BD
{
    internal class sum
    {
        static void Main(string[] args)
        {
            // a collection of elements
            // store mulitple values into a single var
            // elements are from the same type only
            // stores elements in cotiguous space
            // elements can be accessible through its index values
            // index values begin from 0 and its up to n-1 (n is numbers of elemetns)


            /* Types: 
                   - one dimensional 
                   - Multi dimensional 
                   - Jagged array


                data Type [] array Name = new data Type[size]

            */

            int[] ary = new int[5];

            ary[0] = 1;
            ary[4] = 3;

            //Console.WriteLine(ary[0]);

            //int[] ary2 = { 1, 2, 3, 4 };
            //foreach (int i in ary2)
            //{
            //    Console.WriteLine(i);
            //}

            int[] a = new int[5];

            Console.WriteLine("Enter array Elements : ");
            for (int i = 0; i < 5; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nthe Elements in array is :  ");
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }

            // Average of array
            int sum = 0 ;
            foreach(int i in a)
            {
                sum += i;
            }
            Console.WriteLine($"Average of Array is : {sum / a.Length} ");

        } 
    }
}
