using System;

public class Class1
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the term :  ");
		int t = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the Number :  ");
		string n = Console.ReadLine();


		string s = "";
		int final_ans = 0;

		for(int i=0; i<t; i++)
		{
			for(int j=i; j < i+1; j++)
			{
                s = s + n;
            }	

			int a = int.Parse(s);
			final_ans += a;
		}

        Console.WriteLine("\nFinal ans is : " +final_ans);

    }
}
