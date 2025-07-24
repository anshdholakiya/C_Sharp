using System;

public class Class1
{
	int test;   // belongs to object and have 
	static int test1;  // belongs to class and have single copy 

	public  static void Main(string[] args) // static method
	{
		Console.WriteLine(Add(3, 4));
		Console.WriteLine(Sub(3, 4));
		Console.WriteLine(Div(3, 4));
		Console.WriteLine(Mul(3, 4));
	}

	// can not use non-static members within static methods
	 
	 static int Add(int a,int b)   
	{ 
		return a + b;
    }
	 static int Sub(int a,int b)   
	{ 
		return a - b;
    }
	 static float Div(int a,int b)   
	{ 
		return a / b;
    }
	 static int Mul(int a,int b)   
	{ 
		return a * b;
    }
	 
}

