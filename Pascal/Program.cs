using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj n: ");
        int n = int.Parse(Console.ReadLine());

        int[][] t = new int[n][];
        for (int i = 0; i < n; i++)
        {
            t[i] = new int[i + 1];
            for (int j = 0; j <= i; j++)
                t[i][j] = (j == 0 || j == i) ? 1 : t[i - 1][j - 1] + t[i - 1][j];
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
                Console.Write(t[i][j] + " ");
            Console.WriteLine();
        }

        int s = n / 2;
        Console.WriteLine($"\nŚrodkowy wiersz: ");
        for (int j = 0; j <= s; j++)
            Console.Write(t[s][j] + " ");

        int suma = 0;
        for (int j = 0; j <= s; j++) suma += t[s][j];
        Console.WriteLine($"\nSuma: {suma}");

        Console.Write("Podaj A: ");
        double A = double.Parse(Console.ReadLine());
        Console.Write("Podaj B: ");
        double B = double.Parse(Console.ReadLine());

        double wynik = 0;
        for (int j = 0; j <= s; j++)
            wynik += t[s][j] * Math.Pow(A, s - j) * Math.Pow(B, j);

        Console.WriteLine($"(A + B)^{s} = {wynik}");
    }
}
