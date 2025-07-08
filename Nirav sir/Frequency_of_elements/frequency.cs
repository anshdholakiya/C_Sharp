using System;

public class Class1
{
	public static void Main(string[] args)
	{
		int[] a = { 1, 2, 2, 2, 1, 1, 2, 3 };

		bool[] b = new bool[a.Length];

		
		for(int i = 0; i < a.Length; i++)
		{
		sif (b[i] == true)
				continue;

			int cnt = 1;
			for(int j=i+1; j<a.Length; j++)
			{
				if (a[i] == a[j])
				{
					b[j] = true;
					cnt++;
				}
			}

			Console.WriteLine("Frequency of {0} is {1} times ", a[i], cnt);
		}
	}
}
