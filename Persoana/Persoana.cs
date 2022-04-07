using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClasaPersoana
{
    public class Persoana
    {

        private string nume;
        private string prenume;
        private int ID;
        private string CNP;
        private int nrCartiImprumutate;


        // Constructor cu citire de la tastatura
        public Persoana()
        {

            Console.WriteLine("Nume: ");
            nume = Console.ReadLine();
            Console.WriteLine("Prenume: ");
            prenume = Console.ReadLine();
            Console.WriteLine("CNP: ");
            CNP = Console.ReadLine();

        }


        // Salvare persoana in fisier text
        public void SalvarePersoana()
        {

            string path = @"Persoane.txt";
            var lineCount = File.ReadLines(path).Count();
            using (StreamWriter sw = File.AppendText(path))
            {
                string Linie = Convert.ToString(lineCount + 1) + ";" + nume + ";" + prenume + ";" + CNP;
                sw.WriteLine(Linie);
            }
        }

    
    }
}
