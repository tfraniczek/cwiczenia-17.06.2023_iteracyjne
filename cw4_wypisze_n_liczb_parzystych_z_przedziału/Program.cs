using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw4_wypisze_n_liczb_parzystych_z_przedziału
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            //Przygotuj losowanie
            Random random = new Random();

            //Przygotuj licznik
            int liczniklosowan = 0;
            int iloscliczbDoWylosowania = n;


            //Losowac
            for (int iloscLiczWylosowanych = 0; iloscLiczWylosowanych < iloscliczbDoWylosowania; iloscLiczWylosowanych++)
            {
                int wylosowanaLiczba;
                do
                {
                    wylosowanaLiczba = random.Next(-4, 5);
                    wylosowanaLiczba *=2;
                    //inkrementuj licznik losowania
                    liczniklosowan++;
                } while (wylosowanaLiczba % 2 != 0);
                Console.Write(wylosowanaLiczba);
                
        //Sprawdź poprawność losowania
                if (iloscLiczWylosowanych < iloscliczbDoWylosowania-1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("\n Licznik liczb wylosowanych " + liczniklosowan);
            Console.ReadLine(); 
        }

        //Wyświetl

    }
    }

