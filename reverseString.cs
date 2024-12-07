using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
     Console.WriteLine("Enter a String");
     string st=Console.ReadLine();
     string st1="";
     for(int i=st.Length-1;i>=0;i--)
     {
      st1+=st[i]+"";
     }
     Console.WriteLine(st1);
     
    }
} 
