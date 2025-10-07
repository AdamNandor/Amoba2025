using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amőba_feladat
{
    internal class Program
    {
        static string tabla_vonalai = "-";
        static string tabla_osszekoto_viz = "+";
        static string tabla_osszekoto_fugg = "|";
        static int nyereshez_karakter = 5;
        static string babu1 = " x ";
        static string babu2 = " y ";
        static string ellenor = "";
        static string meg_lenni_babu1 = string.Concat(Enumerable.Repeat(babu1, nyereshez_karakter));
        static string meg_lenni_babu2 = string.Concat(Enumerable.Repeat(babu2, nyereshez_karakter));
      

        static bool van_meg_hely(string[,] tabla)
        {
            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                for(int j = 0; j < tabla.GetLength(1); j++)
                {
                    if (tabla[i,j]=="   ")
                    {

                        return true;
                    }
                }
            }
            return false;
           

        }

     

        static void ellenorzo(string check)
        {
            if (check.Contains(meg_lenni_babu1))
            {
                Console.Clear();
                Console.WriteLine($"nyert: {babu1}");
                Console.ReadLine();
            }
            else if (check.Contains(meg_lenni_babu2))
            {
                Console.Clear();
                Console.WriteLine($"nyert: {babu2}");
                Console.ReadLine();
            }
            ellenor = "";
        }

        static void Main(string[] args)
        {
            bool uj_jatek = true;
            Console.WriteLine("Új játék(1-es gomb)\n Kilépés(2-es gomb) ");
            int bekeres = int.Parse(Console.ReadLine());
            if (bekeres == 1)
            {
                uj_jatek = true;
            }
            else if (bekeres == 2)
            {
                Environment.Exit(0);
            }
            while (uj_jatek)
            {
                string[,] tablazat = new string[10,10];

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
                bool lehet_oda = false;
                int tabla_mag = tablazat.GetLength(0);
                int tabla_szel = tablazat.GetLength(1);

                string vizszintes_vonal = "";
                for (int i = 0; i < tabla_mag; i++)
                {
                    vizszintes_vonal += tabla_osszekoto_viz;
                    vizszintes_vonal += tabla_vonalai;
                    vizszintes_vonal += tabla_vonalai;
                    vizszintes_vonal += tabla_vonalai;
                }

                

                while (van_meg_hely(tablazat))
                {
                    try
                    {
                        Console.Clear();
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
                            lehet_oda = false;
                            Console.WriteLine("ide már nem lehet tenni!");
                            Console.WriteLine("enterrel tovább");
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

                            //ellenőrzés átló   balfent-jobb lent
                            int x = koordinata_x - 1;
                            int y = koordinata_y - 1;

                            while (x > 0 && y > 0)
                            {
                                x--;
                                y--;
                            }

                            while (x < tabla_szel && y < tabla_mag)
                            {
                                ellenor += $"{tablazat[y, x]}";
                                x++;
                                y++;
                            }
                            ellenorzo(ellenor);

                            x = koordinata_x - 1;
                            y = koordinata_y - 1;

                            //ellenőrzés átló   balfent-jobb lent
                            while (x > 0 && y < tabla_mag - 1)
                            {
                                x--;
                                y++;
                            }

                            while (x < tabla_szel && y >= 0)
                            {
                                ellenor += $"{tablazat[y, x]}";
                                x++;
                                y--;
                            }
                            ellenorzo(ellenor);

                            y = koordinata_y - 1;
                            for (int i = 0; i < tabla_szel; i++)
                            {
                                ellenor += $"{tablazat[y, i]}";
                            }

                            x = koordinata_x - 1;
                            for (int i = 0; i < tabla_mag; i++)
                            {
                                ellenor += $"{tablazat[i, x]}";
                            }
                            ellenorzo(ellenor);
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
                        Console.ReadLine();
                    }
                 
                }

                if (!van_meg_hely(tablazat))
                {
                    uj_jatek = false;
                    Console.Clear();
                    Console.WriteLine("Nincs hely több hely! Itt a vége! szép volt?");
                    Console.WriteLine("Szeretne újat? (i/n)");
                    if (Console.ReadLine() == "i")
                    {
                        uj_jatek = true;
                    }
                }

            }
            Console.WriteLine("Új játék(1-es gomb)\n Kilépés(2-es gomb) ");
            int bekeres2 = int.Parse(Console.ReadLine());
            if (bekeres2 == 1)
            {
                uj_jatek = true;
            }
            else if (bekeres2 == 2)
            {
                Environment.Exit(0);
            }
        }
    }
}
