using System;

public class Class1
{
	public static void Main(string [] args)
	{
		int[] a = { 5, 3, 67, 23, 12, 652, 4, 32 };
		
		for (int i = 0; i < a.Length; i++)
		{
			for(int j = i+1; j <a.Length; j++)
			{
				if (a[i] > a[j])
				{
					int temp = a[i];
					a[i] = a[j];
					a[j] = temp;
				}
			}
		}

		Console.WriteLine("sorted array element is : ");
		foreach (int i in a)
		{
			Console.WriteLine(i);
		}
	}
}
