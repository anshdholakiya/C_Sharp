# all tut code
```c#
  Console.WriteLine("Hello, World!");



  Console.WriteLine($"Name: ANSH DHOLAKIYA");
        Console.WriteLine($"DOB: 13/11/2003");
        Console.WriteLine($"DHARPARA BABRA\n" +
            $"         Kalawad Road");
        Console.WriteLine($"City: AMRELI");
        Console.WriteLine($"Pincode: 360004");
        Console.WriteLine($"State: Gujarat");
        Console.WriteLine($"Country: India");
        Console.WriteLine($"Email: adholakiya398@rku.ac.in");





     Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number == 0)
        {
            Console.WriteLine($"Number {number} is zero.");
        }
        else if (number % 2 == 0)
        {
            Console.WriteLine($"Number {number} is even.");
        }
        else
        {
            Console.WriteLine($"Number {number} is odd.");
        }




        int x;
        Console.WriteLine("Enter Number : ");
        string str = Console.ReadLine();
        x = Convert.ToInt32(str);
        if (x % 2 == 0)
        {
            Console.WriteLine("Number is Even");
        }
        else
        {
            Console.WriteLine("Number is Odd");
        }
        Console.Read(); 



         int n, fact = 1;    // Declare an integer 'n' for user input, and 'fact' to store factorial, starting with 1
            Console.WriteLine("Enter Number : ");   // Ask the user to enter a number
            string str = Console.ReadLine();    // Read the input from the user as a string
            n = Convert.ToInt32(str);   // Convert the string input to an integer and store it in 'n'
            for (int i = 1; i <= n; i++)    // Loop from 1 to n
            {
                fact = fact * i;    // Multiply 'fact' with current 'i' to compute factorial step by step
            }
            Console.WriteLine("Factorial : {0}", fact);    // Print the result using string formatting
            Console.Read();    // Wait for user to press any key before closing the console



              int a, b, c, result;
            Console.Write("Enter Number   1: ");
            string str = Console.ReadLine();
            a = Convert.ToInt32(str);
            Console.Write("Enter Number  2 : ");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);
            Console.Write("Enter Number   3 : ");
            str = Console.ReadLine();
            c = Convert.ToInt32(str);
            result = Sum(a, b, c);
            Console.WriteLine($"Sum : {result}");
            Console.Read();
        }
        static int Sum(int x, int y, int z)
        {
            int res;
            res = x + y + z;
            return res;
        }










        using System;

public class Class1
{
	public static void Main(string[] args)
	{

        int a, b, c, result;
        Console.Write("Enter Number   1: ");
        string str = Console.ReadLine();
        a = Convert.ToInt32(str);
        Console.Write("Enter Number  2 : ");
        str = Console.ReadLine();
        b = Convert.ToInt32(str);
        Console.Write("Enter Number   3 : ");
        str = Console.ReadLine();
        c = Convert.ToInt32(str);
        result = Sum(a, b, c);
        Console.WriteLine($"Sum : {result}");
        Console.Read();
    }
    static int Sum(int x, int y, int z)
    {
        int res;
        res = x + y + z;
        return res;
    } 

}
} 




 int a, b, c, result;
        Console.Write("Enter Number   1: ");
        string str = Console.ReadLine();
        a = Convert.ToInt32(str);
        Console.Write("Enter Number  2 : ");
        str = Console.ReadLine();
        b = Convert.ToInt32(str);
        Console.Write("Enter Number   3 : ");
        str = Console.ReadLine();
        c = Convert.ToInt32(str);
        result = Sum(a, b, c);
        Console.WriteLine($"Sum : {result}");
        Console.Read();
    }
    static int Sum(int x, int y, int z)
    {
        int res;
        res = x + y + z;
        return res;
    } 


    Console.Write("INPUT: ");
        string str = Console.ReadLine();
        Console.Write($"OUTPUT: {str.ToUpper()}"); 



        Console.Write("INPUT:");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            String outString = "";
            foreach(char character in str)
            {
                if (char.IsUpper(character))
                {
                    outString += char.ToLower(character);
                }
                else
                {
                    outString += char.ToUpper(character);
                }
            }
            Console.Write($"{outString}");




             Console.Write("INPUT: ");
            string str = Console.ReadLine();
            string outString = "";
            for (int i = 0; i < 5; i++) 
            {
                outString = outString + str[i];
            }
            outString = outString + "XXXXX";
            Console.WriteLine($"OUTPUT: {outString}");


              Console.Write("NAME: ");
            string name = Console.ReadLine();
            Console.Write("GENDER: ");
            string genderStr = Console.ReadLine();
            char gender = genderStr.ToLower()[0];
            if(gender == 'f')
            {
                Console.WriteLine($"Ms. {name}");
            }else
            {
                Console.WriteLine($"Mr. {name}");



                 Console.Write("INPUT: ");
            Console.WriteLine($"OUTPUT: {Console.ReadLine()}");



             Console.WriteLine("Enter count: ");
            int count  = int.Parse(Console.ReadLine());
            int[] arr = new int[count];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i < count; i++)
            {
                arr[i] = arr[i-1]+arr[i-2];
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{arr[i]} ");
            }



             string[] arr = {"Zero","One","Two","Three","Four","Five","Six","Seven","Eight","Nine"};
            Console.Write("INPUT: ");
            int number = int.Parse(Console.ReadLine());
            string outputStr = "";
            while (number > 0)
            {
                int reminder = number % 10;
                outputStr = $"{arr[reminder]} " + outputStr;
                number = number / 10;
            }
            Console.WriteLine($"OUTPUT: {outputStr}");

```