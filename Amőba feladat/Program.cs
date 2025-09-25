using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amőba_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] tablazat = new string[10, 10];

            // Tábla inicializálása
            for (int i = 0; i < tablazat.GetLength(0); i++)
            {
                for (int j = 0; j < tablazat.GetLength(1); j++)
                {
                    tablazat[i, j] = "[]";
                }
            }

            while (true)
            {
                // Kiírás
                for (int i = 0; i < tablazat.GetLength(0); i++)
                {
                    for (int j = 0; j < tablazat.GetLength(1); j++)
                    {
                        Console.Write(tablazat[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                // Felhasználói input
                Console.WriteLine("Koordináta (x): ");
                int koordinata_x = int.Parse(Console.ReadLine());
                Console.WriteLine("Koordináta (y): ");
                int koordinata_y = int.Parse(Console.ReadLine());
                Console.WriteLine("Karakter x/o: ");
                string karakter = Console.ReadLine();

                // Tábla frissítése
                tablazat[koordinata_y - 1, koordinata_x - 1] = karakter;

                Console.Clear();
            }



        }
    }
}
