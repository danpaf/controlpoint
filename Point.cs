using ControlPoint;

class Point
{
    private Person pok;
    public string nazvanie;
    public int zena;
    public int n;
    public int itog;
    public string hotim;

    public void Print()
    {
        Console.WriteLine($" ( Ваш товар:{nazvanie} , Его колличество:{n},Итого:{zena})");
    }

}
 