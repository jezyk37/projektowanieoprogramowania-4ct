using System;

namespace Kalkulator
{
    public class Kalkulator
    {
        public double Dodawanie(double a, double b) => a+b;
        public double Odejmowanie(double a, double b) => a-b;
        public double Mnozenie(double a, double b) => a*b;
        
        public double Dzielenie(double a, double b)
        {
            if(b == 0)
            {
                throw new ArgumentException("Nie dziel przez zero");
            }
            else
            {
                return a/b;
            }
        }
    }
}