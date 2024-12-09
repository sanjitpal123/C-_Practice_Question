using System;

public class Employee {
  private string name;
  private int id;
  private double salary;
  public void setter(int id, double salary, string name)
  {
      this.id=id;
      this.salary=salary;
      this.name=name;
  }
  public int getid()
  {
      return this.id;
  }
  public string getname()
  {
      return this.name;
  }
  public double  getsalary()
  {
      return this.salary;
  }
    
}
public class MainOne{
    public static void Main(string [] args)
    {
        Employee e=new Employee();
        e.setter(1,25000,"sanjit");
        int id1=e.getid();
        string name1=e.getname();
        double salary1=e.getsalary();
        Console.WriteLine("name is "+name1+"salary is :"+salary1+"id is :"+id1);
        
    }
}
