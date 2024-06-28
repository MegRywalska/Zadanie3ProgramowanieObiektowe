using System;

namespace Zadanie3ProgramowanieObiektowe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie wektorów za pomocą różnych konstruktorów
            Wektor v1 = new Wektor(3);  // Wektor zerowy o wymiarze 3
            Wektor v2 = new Wektor(1.0, 2.0, 3.0);  // Wektor o współrzędnych (1, 2, 3)
            Wektor v3 = new Wektor(4.0, 5.0, 6.0);  // Wektor o współrzędnych (4, 5, 6)

            // Ustawianie wartości za pomocą indeksatora
            v1[0] = 1.0;
            v1[1] = 1.0;
            v1[2] = 1.0;

            // Wyświetlanie współrzędnych i wymiaru wektora
            Console.WriteLine("Wektor v1:");
            for (byte i = 0; i < v1.Wymiar; i++)
            {
                Console.WriteLine($"v1[{i}] = {v1[i]}");
            }
            Console.WriteLine($"Wymiar: {v1.Wymiar}");
            Console.WriteLine($"Długość: {v1.Dlugosc}");
            Console.WriteLine();

            // Operacje na wektorach
            Wektor suma = v2 + v3;
            Wektor roznica = v3 - v2;
            Wektor iloczynSkalar = v2 * 2;
            Wektor iloczynSkalarOdwrotny = 2 * v2;
            Wektor ilorazSkalar = v2 / 2;

            // Wyświetlanie wyników operacji
            Console.WriteLine("Suma v2 + v3:");
            for (byte i = 0; i < suma.Wymiar; i++)
            {
                Console.WriteLine($"suma[{i}] = {suma[i]}");
            }
            Console.WriteLine();

            Console.WriteLine("Różnica v3 - v2:");
            for (byte i = 0; i < roznica.Wymiar; i++)
            {
                Console.WriteLine($"roznica[{i}] = {roznica[i]}");
            }
            Console.WriteLine();

            Console.WriteLine("Iloczyn skalarny v2 * 2:");
            for (byte i = 0; i < iloczynSkalar.Wymiar; i++)
            {
                Console.WriteLine($"iloczynSkalar[{i}] = {iloczynSkalar[i]}");
            }
            Console.WriteLine();

            Console.WriteLine("Iloraz skalarny v2 / 2:");
            for (byte i = 0; i < ilorazSkalar.Wymiar; i++)
            {
                Console.WriteLine($"ilorazSkalar[{i}] = {ilorazSkalar[i]}");
            }
            Console.WriteLine();

            // Iloczyn skalarny dwóch wektorów
            double? iloczyn = Wektor.IloczynSkalarny(v2, v3);
            Console.WriteLine($"Iloczyn skalarny v2 i v3: {iloczyn}");
        }
    }
}
