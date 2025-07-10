using System;

public class Class1
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter a number: ");
		int n = int.Parse(Console.ReadLine());

		for (int i = 1; i <= n; i++)
		{
			for (int j = 1; j <= 10; j++)
			{
				Console.WriteLine($"{i} * {j} = {i*j}");
			}
			Console.WriteLine();
		}


		for(int i= 1; i <= 10; i++)
		{
            for(int j = 1; j <= n; j++)
			{
				Console.Write($"{j} x {i} = {i*j}   ");
			}
			Console.WriteLine();
        }
	}
}
