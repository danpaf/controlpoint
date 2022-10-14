namespace ControlPoint;

// See https://aka.ms/new-console-template for more information

public class Person
{
    private Tovar tovar;
    private static int currentID;
    public string FIO;
    public int ID;
    public int Age;
    
    public Person(string fio, int age, int id)
    {
        this.FIO = fio;
        this.Age = age;
        ID = GetNextID();
    }
    static Person()
    {
        currentID = 0;
    }
    public int GetNextID()
    {
        return ++currentID;
    }
    
    public void isTeenager()
    {
        if (this.Age >= 13 && Age <= 18)
            Console.WriteLine("тин");
        else
            Console.WriteLine("тини");
    }

    public void GetDiscont()
    {
     

    }
}