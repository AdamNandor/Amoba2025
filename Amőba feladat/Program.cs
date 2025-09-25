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

          
            string tabla_vonalai = "-";
            string tabla_osszekoto_viz = "+";
            string tabla_osszekoto_fugg = "|";



            string[,] tablazat = new string[10, 10];

            // Tábla inicializálása
            for (int i = 0; i < tablazat.GetLength(0); i++)
            {
                for (int j = 0; j < tablazat.GetLength(1); j++)
                {
                    tablazat[i, j] = "   ";
                }
            }
            bool x_y_lep = true;
            string karakter = " x ";
            bool lehet_oda=false;
            int tabla_mag = tablazat.GetLength(0);
            int tabla_szel = tablazat.GetLength(1);

            string vizszintes_vonal = "";
            for (int i =0;i<=tabla_mag; i++)
            {
                vizszintes_vonal += tabla_osszekoto_viz;
                vizszintes_vonal += tabla_vonalai;
                vizszintes_vonal += tabla_vonalai;
                vizszintes_vonal += tabla_vonalai;
            }
            string babu1 = " x ";
            string babu2 = " y ";
            while (true)
            {
                try
                {
                   
                    
                    // Kiírás
                    for (int i = 0; i < tabla_mag; i++)
                    {
                        Console.WriteLine(vizszintes_vonal);
                        for (int j = 0; j < tabla_szel; j++)
                        {
                            Console.Write(tabla_osszekoto_fugg);
                            if (tablazat[i, j] == babu1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else if (tablazat[i, j] == babu2)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                           
                             Console.Write(tablazat[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        Console.Write(tabla_osszekoto_fugg);
                        Console.WriteLine();

                    }
                    Console.WriteLine(vizszintes_vonal);
                    Console.WriteLine(x_y_lep ? "X következik" : "y következik");

                    // Felhasználói input
                    Console.WriteLine("Koordináta (x): ");
                    int koordinata_x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Koordináta (y): ");
                    int koordinata_y = int.Parse(Console.ReadLine());
                    if (tablazat[koordinata_y - 1, koordinata_x - 1] == "   ")
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
                            karakter = babu1;
                            x_y_lep = false;
                        }
                        else
                        {
                            karakter = babu2;
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
