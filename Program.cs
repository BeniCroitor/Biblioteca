using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClaseCarte;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string c;
            Carte carte1 = null;
            while (true)
            {
                Console.WriteLine("Alegeti o optiune: \n");
                Console.WriteLine("1. Introducere carte de la tastatura");
                Console.WriteLine("2. Salvare carte");
                Console.WriteLine("3. Afisare carte dupa ID");
                Console.WriteLine("4. Cautare carte");

                Console.WriteLine("x. Inchidere program");

                

                c = Console.ReadLine();
                switch (c)
                {
                    case "1":
                        carte1 = new Carte();
                        break;
                    case "2":
                        carte1.SalvareCarte();
                        break;
                    case "3":
                        Console.WriteLine("Dati ID-ul cartii pe care doriti sa o afisati: ");
                        string i = Console.ReadLine();
                        Carte cAfisare = new Carte(3);
                        cAfisare.ExtragereCarte(i);
                        cAfisare.AfisareCarte();
                        break;
                    case "4":
                        Carte carteSearch = new Carte(4);
                        carteSearch.Search();
                        carteSearch.AfisareCarte();
                        break;



                    case "x":
                        break;
                }

                if (c == "x")
                    break;
            }
        }
    }


    
}

