using System;

class KontoBankowe
{
    public string NumerKonta { get; set; }
    public double Saldo { get; set; }
    
    public KontoBankowe(string numerKonta, double saldo)
    {
        this.NumerKonta = numerKonta;
        this.Saldo = saldo;
    }

    public virtual void WyswietlSaldo()
    {
        Console.WriteLine("Numer konta: " + NumerKonta);
        Console.WriteLine("Saldo: " + Saldo + " zł");
    }
}
class KontoOszczednosciowe : KontoBankowe
{
    public double Oprocentowanie { get; set; }
    public KontoOszczednosciowe( string numerKonta, double saldo, double oprocentowanie):base(numerKonta, saldo)
    {
        this.Oprocentowanie = oprocentowanie;
    }
    public double ObliczOdsetki()
    {
        return Saldo * Oprocentowanie / 100;
    }
    public override void WyswietlSaldo()
    {
        base.WyswietlSaldo();
        Console.WriteLine("Oprocentowanie: " + Oprocentowanie + "%");
        Console.WriteLine("Odsetki: " + ObliczOdsetki() + " zŁ");
    }
}
class Program
{
    static void Main(string[] args)
    {
        KontoOszczednosciowe konto = new KontoOszczednosciowe("1234567890", 5000, 3.5);
        konto.WyswietlSaldo();
    }
}