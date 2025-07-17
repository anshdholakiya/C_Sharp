using System;

public class Class1
{
	public static void Main(string[] args)
	{

		/*
		 333
		 313
		 323
		 
		 */
		//int n = 5;
		//for (int i = 0; i <= n; i++)
		//{

		//	for (int j = 0; j < 3; j++)
		//	{
		//		if(i > 0 && j==1)
		//		{
		//			Console.Write(i);
		//		}
		//		else
		//		{
		//			Console.Write(n);
		//		}
		//	}
		//	Console.WriteLine();
		//}



		/*
		 
		*
		#*
		*#*
		#*#*

		 */

		int n = 4;
		char star = '*';
		char hash = '#';

		bool is_star = true;
		bool is_hash = false;	

		for(int i=0; i<n; i++)
		{
			if (i % 2 == 0)
				is_star = true;
			else
				is_hash = true;
			

			for (int j = 0; j < i + 1; j++){

				if (is_star){
					Console.Write(star);
					is_star = false;
					is_hash = true;
				}else{
					Console.Write(hash);
					is_hash = false;
					is_star = true;
				}
			}

			Console.WriteLine();
        }
	}
}
