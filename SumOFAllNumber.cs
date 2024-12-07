

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is the size of the array?");
        int n = int.Parse(Console.ReadLine()); 
        int[] nums = new int[n];
        
        Console.WriteLine("Enter " + n + " numbers:"); 
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        Console.WriteLine("Sum: " + sum); 
    }
}
