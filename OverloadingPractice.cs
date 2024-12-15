public class Calculator{
    public int sum(int a,int b)
    {
        return a+b;
        
    }
    public int sum(int a,int b, int c)
    {
        return a+b+c;
    }
    public double sum(double a, double b)
    {
        return a+b;
    }
    
}
 class Program{
     static void Main(string[] args)
     {
         Calculator c=new Calculator();
         int s1=c.sum(10,20);
         int s2=c.sum(10,20,30);
         double s3=c.sum(10.20,30.40);
         Console.WriteLine("sum1"+s1+"sum2"+s2+"sum3"+s3);
     }
 }
