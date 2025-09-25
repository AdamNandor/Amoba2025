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
            int koordinata_x = 0;
            int koordinata_y = 0;
            string karakter = "";

            string[,] tablazat = new string[10, 10];

            for (int i = 0; i < tablazat.GetLength(0); i++)
            {
                for (int j = 0; j < tablazat.GetLength(1); j++)
                {
                    tablazat[i, j] = "[]";
                    Console.Write(tablazat[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Koordináta (x): ");
            koordinata_x = int.Parse(Console.ReadLine());
            Console.WriteLine("Koordináta (y): ");
            koordinata_y = int.Parse(Console.ReadLine());
            Console.WriteLine("Karakter x/o: ");
            karakter = Console.ReadLine();
            tablazat[koordinata_x, koordinata_y] = karakter;
            Console.Clear();
            for (int i = 0; i < tablazat.GetLength(0); i++)
            {
                for (int j = 0; j < tablazat.GetLength(1); j++)
                {
                    Console.Write(tablazat[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
