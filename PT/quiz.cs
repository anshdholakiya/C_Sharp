using System;

public class quiz
{
    public static void Main(string[] args)
    {
        int a = 5;
        int b = 5;
        int c = 5;
        //int res = a++ + b++ + ++a;

        int res2 = ++a + b++ + b++ + a++ + ++a + ++b + a++;
        //Console.WriteLine(res);  // first assign than increament
        Console.WriteLine(res2);
    }
}
