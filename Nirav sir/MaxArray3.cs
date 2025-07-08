using System;

public class Class1
{
	public static void Main(string [] args)
	{
		int[] a = { 1, 2, 3, 4, 5, 6, 7 };

		int max = 0 ;
		foreach (int i in a)
		{
			if (i > max)
			{
				max = i;
			}
		}
		Console.WriteLine(max);
	}
}
