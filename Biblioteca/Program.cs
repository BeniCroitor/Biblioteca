using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClasaCarte;
using ClasaPersoana;

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
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Alegeti o optiune: \n");
                Console.WriteLine("1. Introducere carte de la tastatura");
                Console.WriteLine("2. Afisare carte dupa ID");
                Console.WriteLine("3. Cautare carte");
                Console.WriteLine("4. Afisare toate cartile");
                Console.WriteLine("\n5. Introducere persoana");

                Console.WriteLine("x. Inchidere program");

                

                c = Console.ReadLine();
                switch (c)
                {
                    case "1":
                        carte1 = new Carte();
                        Console.WriteLine("\n\n----------------------------\n");
                        carte1.AfisareCarteFaraID();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\nDoriti sa salvati cartea?  (Y/N)");
                        string s = Console.ReadLine();
                        if (s.ToUpper() == "Y")
                            carte1.SalvareCarte();
                        else
                            if (s.ToUpper() == "N")
                            break;
                        else
                            Console.WriteLine("Incercati din nou...");
                        break;
                    case "2":
                        Console.WriteLine("Dati ID-ul cartii pe care doriti sa o afisati: ");
                        string i = Console.ReadLine();
                        Carte cAfisare = new Carte(3);
                        cAfisare.ExtragereCarte(i);
                        cAfisare.AfisareCarte();
                        break;
                    case "3":
                        Carte carteSearch = new Carte(4);
                        carteSearch.Search();
                        carteSearch.AfisareCarte();
                        break;
                    case "4":
                        Carte.AfisareCarti();
                        break;


                    case "5":
                        Persoana persoana = new Persoana();
                        persoana.SalvarePersoana();
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

