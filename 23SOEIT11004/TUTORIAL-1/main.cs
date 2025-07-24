using System;

public class Class1
{
	public static void Main(string[] args)
	{
        int n = 9;
        for (int i = 0; i < n; i++)
        {
            int z;
            if (i > (n / 2))
            {
                z = n - i - 1;
            }
            else
            {
                z = i;
            }
            for (int k = n / 2; k > z; k--)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < (2 * z) + 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); 
    }



}
} 