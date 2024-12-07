
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
     Console.WriteLine("Enter the size of array");
     int n=int.Parse(Console.ReadLine());
     int[]nums=new int[n];
     for(int i=0;i<n;i++)
     {
         nums[i]=int.Parse(Console.ReadLine());
     }
     int max=nums[0];
     int secondMax=nums[1];
     for(int i=0;i<nums.Length;i++)
     {
         if(nums[i]>max)
         {
             secondMax=max;
             max=nums[i];
         }
         if(nums[i]>secondMax && nums[i]<max)
         {
             secondMax=nums[i];
         }
         
     }
     Console.WriteLine("second largest number is"+secondMax);
    }
}
