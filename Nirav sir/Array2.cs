using System;

public class Class1
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter element to search : ");
		int searchElement = Convert.ToInt32(Console.ReadLine());
		int[] a = { 10, 21, 2, 13, 1 };
		bool flag = false;

		for (int i = 0; i < a.Length; i++)
		{
			if (a[i] == searchElement)
			{
				flag = true;
				break;
			}
		}

		if (flag)
		{
			Console.WriteLine("ELements is found");
		}
		else
		{
			Console.WriteLine("ELements is found");
		}
	}
}
