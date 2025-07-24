using System;

public class Class1
{
	int test;   // belongs to object and have 
	static int test1;  // belongs to class and have single copy 

	public  static void Main(string[] args) // static method
	{
		//Console.WriteLine(Add(3, 4));
		//Console.WriteLine(Sub(3, 4));
		//Console.WriteLine(Div(3, 4));
		//Console.WriteLine(Mul(3, 4));

		int a = 343;
		int b = 454235;
		//Console.WriteLine("Before swap : a = {0} and b = {1} ",a,b); 
		//swap(ref a,ref  b);											// also here also give value by referance	
		//Console.WriteLine("After swap : a = {0} and b = {1} ",a,b);


		Console.WriteLine("Before out keyword: a = {0} and b = {1} ", a, b);
        Update(out a, out b);
        Console.WriteLine("After out keyword: a = {0} and b = {1} ", a, b);

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
	 
	static void swap(ref int a, ref int b)  // without ref this all be local varible that not work 
		// we need to give it by referacne to change the value of both
	{
		//int t = a;
		//a = b;
		//b = t;

		// let a=3,b=4
        a = a + b;  // a = 7
        b = a - b;	// b = 7-3 = 4
        a = a - b;  // a = 7-4 = 3
    }

	static void Update(out int a,out int b)  // without return type . with the use of out parameter we can return multiple value 

		
	{
		// when value from out parameter that is unassigned 

		a = 100;
		b = 200;   // we have to assign value in out parameter before living the current method 

		// because out keyword unassigned the passing parameter
	}
}

