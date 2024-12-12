
using System;

public class DataPrinter{
    public void display(int value)
    {
        Console.WriteLine("hellow" +value);
    }
    public void display(string value)
    {
        Console.WriteLine("hellow" +value);
    }
    public void display(double value)
    {
        Console.WriteLine("hellow" +value);
    }
}

public class Dis{
    public static void Main(string[] args)
    {
        DataPrinter p=new DataPrinter();
        p.display(29);
        p.display("sanjit");
        p.display(31.5);
    }
}
