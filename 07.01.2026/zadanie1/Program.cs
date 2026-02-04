using System;

class Uczen
{
    private string imie;
    private string nazwisko;
    private double sredniaOcen;

    public Uczen(string imie, string nazwisko, double sredniaOcen)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.sredniaOcen = sredniaOcen;
    }

    public bool CzyZdany()
    {
        return sredniaOcen >= 2.0;
    }
    public void WyswietlDane()
    {
        Console.WriteLine("Imię: " + imie);
        Console.WriteLine("Nazwisko: " + nazwisko);
        Console.WriteLine("Średnia ocen: " + sredniaOcen);
        Console.WriteLine("Zdany: " + (CzyZdany() ? "Tak" : "Nie"));
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Uczen u1 = new Uczen("Jan", "Kowalski", 4);
        Uczen u2 = new Uczen("Bartek", "Janik", 1.5);

        u1.WyswietlDane();
        u2.WyswietlDane();
    }
}