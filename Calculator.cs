

using System;

public class calculator{
    public void add(int a, int b)
    { 
        Console.WriteLine(a+b);
    } 
    public void substact (int a, int b)
    {
        Console.WriteLine(a-b);
    }
    public void multiply(int a, int b)
    {
        Console.WriteLine(a*b);
    }
}

public class Mainclass{
    public static void Main(string[] args)
    {
        calculator c=new calculator();
        c.add(10,20);
        c.substact(30,10);
        c.multiply(40,10);
    }
}
