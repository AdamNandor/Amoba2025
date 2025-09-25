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
            bool x_y_lep = true;
            string karakter = "x";
            bool lehet_oda=false;
            while (true)
            {
                try
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
                    Console.WriteLine(x_y_lep ? "X következik" : "y következik");

                    // Felhasználói input
                    Console.WriteLine("Koordináta (x): ");
                    int koordinata_x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Koordináta (y): ");
                    int koordinata_y = int.Parse(Console.ReadLine());
                    if (tablazat[koordinata_y - 1, koordinata_x - 1] == "[]")
                    {
                        lehet_oda = true;
                    }
                    else
                    {

                        lehet_oda= false;
                        Console.WriteLine("ide már nem lehet tenni!");
                        Console.WriteLine("enterre tovább");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    if (lehet_oda)
                    {


                        if (x_y_lep)
                        {
                            karakter = "x";
                            x_y_lep = false;
                        }
                        else
                        {
                            karakter = "y";
                            x_y_lep = true;
                        }


                        // Tábla frissítése
                        tablazat[koordinata_y - 1, koordinata_x - 1] = karakter;

                        Console.Clear();
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine("hiba történt!");
                    Console.WriteLine("Szeretné látni a hibát? (i/n)");
                    string hiba = Console.ReadLine();
                    if (hiba == "i")
                    {
                        Console.WriteLine(ex);
                    }
                }
            }



        }
    }
}
