// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class order{
    private  int orderId;
    private int orderDate;
    private int totalamount;
    private int discount;
    public void setorderDate(int date)
    {
        this.orderDate=date;
    }
    public void setTotalamount(int totalamount)
    {
        this.totalamount=totalamount;
    }
    
    public void Calculate()
    {
        if(totalamount>1000){
        discount=totalamount*10/100;
        Console.WriteLine("Discount"+discount);
            
        }
        else{
            Console.WriteLine("No discount available");
            Console.WriteLine("TotalAmount",totalamount);
        }
        
        
    }
}
public  class m{
    public static void Main(string[] arg)
    {
        order o=new order();
        o.setorderDate(2020);
        o.setTotalamount(10000);
        o.Calculate();
    }
}
