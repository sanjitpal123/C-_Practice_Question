using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        int[] nums = new int[] { 1, 2, 3, 4, 5 };

      
        int min = nums[0];
        int max = nums[0];

      
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
            }
            if (nums[i] < min)
            {
                min = nums[i];
            }
        }

       
        Console.WriteLine("min: " + min);
        Console.WriteLine("max: " + max);
    }
}
