
using System;

public class HelloWorld
{ 
    public static void Main(string[] args)
    { 
     int c=0;
     Console.WriteLine("Enter a number");
     int n = int.Parse(Console.ReadLine());
     for(int i=1;i<=n;i++)
     {
         if(n%i==0)
         {
             c++;
         }
     }
     if(c==2)
     {
         Console.WriteLine("Prime number");
     }
     else
    {
        Console.WriteLine("Not Prime Number");
    }
     
    }
}
