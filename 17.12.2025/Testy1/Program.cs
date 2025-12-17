using System;

namespace Zadanie
{
    public class Wpisy
    {
        static void Main(string[] args)
        {
            Wpisy wpisy = new Wpisy();
            Console.WriteLine("Podaj wpis ==");
            string tekst = Console.ReadLine();
            Console.WriteLine(wpisy.sprawdzenie10liter(tekst));
            Console.WriteLine(wpisy.sprawdzCzyInt(tekst));

            Console.WriteLine("Podaj wpis ==");
            string tekst2 = Console.ReadLine();
            Console.WriteLine(wpisy.sprawdzenie10_20liter(tekst2));
            Console.WriteLine(wpisy.sprawdzCzyString(tekst2)); 
            

        }
        public string sprawdzenie10liter(string wpis)
        {
            if(wpis.Length == 10)
            {
                return "10 liter";
            }
            else
            {
                return "inna liczba liter";
            }
        }
        public string sprawdzenie10_20liter(string wpis)
        {
            if (wpis.Length >= 10 && wpis.Length <= 20)
            {
                return "1020 liter";
            }
            else
            {
                return "nie jest pomiedzy 10-20";
            }
        }
        public string sprawdzCzyString(string wpis)
        {
            if (int.TryParse(wpis, out int wynik))
            {
                return "inny typ danych";
            }

            return "string instance";
        }

        public string sprawdzCzyInt(string wpis)
        {
            if (int.TryParse(wpis,out int wynik))
            {
                return "int instance";
            }

            return "inny typ danych";
        }


    }
}