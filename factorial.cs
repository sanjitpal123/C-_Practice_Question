using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int f=1;
        int n=5;
        int i=1;
        while(i<=n)
        {
            f=f*i;
            i++;
        }
        Console.WriteLine(f);
    }
}
