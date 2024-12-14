// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Person{
    private string name;
    private int age;
    public void setName(string name)
    {
        this.name=name;
    }
    
    public void setAge(int age)
    {
        this.age=age;
    }
    
    public string getName()
    {
        return this.name;
    }
    public int getage()
    {
        return this.age;
    }
}

public class M{
    public static void Main(string[] args)
    {
        Person p=new Person();
        p.setName("sanjit");
        p.setAge(20);
        int age=p.getage();
        string name=p.getName();
        Console.WriteLine("name is "+name+" "+"age is "+age);
    }
}
