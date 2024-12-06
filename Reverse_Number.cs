
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
     int n=5231;
     int rev=0;
     while(n!=0)
     {
         int r=n%10;
         rev=rev*10+r;
         n=n/10;
     }
     Console.WriteLine(rev);
    }
}
