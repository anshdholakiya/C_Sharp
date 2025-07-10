using System;

public class Class1
{
	public static void Main(string[] args)
	{
		for (int i = 0; i < 10; i++)
		{
			int k = i <= 5 ? i : 10 - i;
			for (int j = 0; j < k; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
