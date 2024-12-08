

using System;

public class Employee
{
    string name = "sanjit";
    double salary = 230;

    public void GiveRaise(double percentage)
    {
        this.salary = this.salary + (this.salary * (percentage / 100)); 
    }

    public void Display()
    {
        Console.WriteLine("Name is " + this.name + ", Salary is " + this.salary);
    }
}

public class MainOne
{
    public static void Main(string[] args)
    {
        Employee e = new Employee();
        e.GiveRaise(10); 
        e.Display();
    }
}

