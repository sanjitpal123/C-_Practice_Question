using System;

public class Stringmanipulation{
     public string reverseString(string input)
     {
         string st="";
         for(int i=input.Length-1;i>=0;i--)
         {
             st+=input[i]+"";
         }

         return st;
     }
}
public class Mainfdf{
    public static void Main(string[] args)
    {
        Stringmanipulation s=new Stringmanipulation();
         Console.WriteLine(s.reverseString("san"));
    }
}
