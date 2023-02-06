using System;

namespace Basketbol
{
    class Program
    {
        static void Main(string[] args)
        {
            double razhodi = double.Parse(Console.ReadLine());
            double kecove = razhodi * 0.6;
            double ekip = kecove * 0.8;
            double topka = ekip * 0.25;
            double aksesoari = topka * 0.2;
            double cena = razhodi + kecove + ekip + topka + aksesoari;
            Console.WriteLine($"{cena:F2}");

        }
    }
}
