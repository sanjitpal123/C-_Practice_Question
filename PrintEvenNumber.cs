using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter a number");
       int n = int.Parse(Console.ReadLine()); 
       
       for (int i = 1; i <= n; i++)
       {
           if (i % 2 == 0)
           {
               Console.WriteLine(i);
           }
       }
    }
}
