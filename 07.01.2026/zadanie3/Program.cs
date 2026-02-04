using System;
interface IPojazd
{
    void Jedz();
}
class Rower : IPojazd
{
    public void Jedz()
    {
        Console.WriteLine("Rower jedzie sigma 🤙🤙");
    }
}
class Samochod : IPojazd
{
    public void Jedz()
    {
        Console.WriteLine("Samochod jedzie sigma 🚎🎰");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IPojazd[] pojazdy = new IPojazd[2];
        pojazdy[0] = new Rower();
        pojazdy[1] = new Samochod();

        foreach (IPojazd p in pojazdy)
        {
            p.Jedz();
        }
    }
}