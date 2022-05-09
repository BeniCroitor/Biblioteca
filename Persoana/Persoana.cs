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
        const string numeFisier = @"Persoane.txt";

        private static string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        private string pathPers = locatieFisierSolutie + "\\" + numeFisier;

        private string nume;
        private string prenume;
        private int ID;
        private string CNP;
        private int nrCartiImprumutate;
        private double nrCI;
        private string serieCI;


        // Constructor gol
        public Persoana()
        {
            
        }

        // Constructor cu parametrii
        public Persoana(int id = -1 , string Nume = "", string Prenume = "" , string Cnp = "" , string SerieCI = "" , double NrCI = 0 , int NrCartiImprumutate = 0)
        {
            this.ID = id;
            this.nume = Nume;
            this.prenume = Prenume;
            this.CNP = Cnp;
            this.serieCI = SerieCI;
            this.nrCI = NrCI;
            this.nrCartiImprumutate = NrCartiImprumutate;

        }


        // Functie ce pune toate persoanele din fisier intr-un array
        public void ExtragerePersoane()
        {
            List<Persoana> listaPersoane = new List<Persoana>();
            using (StreamReader sr = new StreamReader(pathPers))
            {
                sr.BaseStream.Position = 0;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] lineSplit = line.Split(';');

                    int.TryParse(lineSplit[0], out int ID);
                    double.TryParse(lineSplit[5], out double nrCI);
                    int.TryParse(lineSplit[6], out int nrCarti);

                    listaPersoane.Add(new Persoana(ID, lineSplit[1] , lineSplit[2], lineSplit[3] , lineSplit[4], nrCI , nrCarti));
                }
            }
        }

        // Salvare persoana in fisier text
        public void SalvarePersoana()
        {

            var lineCount = File.ReadLines(pathPers).Count();
            this.ID = lineCount + 1;
            using (StreamWriter sw = File.AppendText(pathPers))
            {
                string Linie = Convert.ToString(lineCount + 1) + ";" + this.nume + ";" + this.prenume + ";" + this.CNP + ";" + this.serieCI + ";" + this.nrCI + ";" + this.nrCartiImprumutate;
                sw.WriteLine(Linie);
            }
        }

    
    }
}
