using System;

public class Class1
{
	public class Employee()
	{
		int empId; // this is knowns as instance variable in the class
		string empName;
		double salary;

		public void getData(int empId , string empName , double salary)
		{
			this.empId = empId;
			this.empName = empName;
			this.salary = salary;
		}

		public double getSalary()
		{
			return this.salary;
		}

		public void showData()
		{
			Console.WriteLine(empId);
			Console.WriteLine(empName);
			Console.WriteLine(salary);
		}

	}


	public class Time
	{
		int hour;
		int min;
		int sec;

		public void setData(int hour, int min, int sec)
		{
			this.hour = hour;
			this.min = min;
			this.sec = sec;
		}
		public void increment()
		{
			if(this.sec == 59) {
				this.sec = 0;
				if (this.min == 59){
					this.min = 0;
					if (this.hour == 24) {
						this.hour = 1;
					}
					else
					{
						this.hour++;
					}
				}
				else
				{
					this.min++;
				}
			}
			else
			{
				this.sec++;
			}
		}
		
		public void getData()
		{
			Console.WriteLine("Time is {0}:{1}:{2}", this.hour, this.min, this.sec);
		}

	}

	public static void Main(string[] args)
	{
		Employee e1 = new Employee();
		e1.getData(2,"ksihan",10); 

		Employee e2 = new Employee();
		e2.getData(3,"jay",13200);

		//if (e1.getSalary() > e2.getSalary()) 
		//	e1.showData();
		//else
		//	e2.showData();
		 
		//employee.empId = 234; // we can't do it because of encapsulation

		Time time = new Time();
		time.setData(11, 59, 59);
		time.increment();
		time.getData();
	}
}
