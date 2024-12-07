public class person{
    int age=10;
    string name="sanjit";
    public void DisplayInfo()
    {
        Console.WriteLine("Name:"+this.name+"Age:"+this.age);
    }
    public  void Birthday()
    {
        this.age+=1;
        
    }
    public static void Main()
    {
        person b=new person();
        b.Birthday();
        b.Birthday();
        b.DisplayInfo();
    }
}
