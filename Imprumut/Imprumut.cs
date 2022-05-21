using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClasaImprumut
{
    public class Imprumut
    {
        const string numeFisier = @"Imprumuturi.txt";

        private static string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        public static string pathImprumuturi = locatieFisierSolutie + "\\" + numeFisier;

        public int idPers;
        public int idCarte;
        public string Date_out;


        // Constructor fara param
        public Imprumut()
        { }


        // Constructor cu parametrii
        public Imprumut(int IDPERS, int IDCARTE)
        {
            idPers = IDPERS;
            idCarte = IDCARTE;
            Date_out = " ";
            
        }



        // Salvare imprumut in fisier
        public void SalvareImprumut()
        {
            string[] lines = File.ReadAllLines(pathImprumuturi);
            string imprumut = Convert.ToString(idPers) + ";" + Convert.ToString(idCarte) + ";" + DateTime.Now.ToString("dd/MM/yyyy");
            using (StreamWriter sw = new StreamWriter(pathImprumuturi, true))
            {
                sw.WriteLine(imprumut);
            }
        }


        // Functie ce returneaza o lista cu toate imprumuturile din fisier

        public static List<Imprumut> ReturnImprumuturi()
        {
            List<Imprumut> listaImprumuturi = new List<Imprumut>();
            using (StreamReader sr = new StreamReader(pathImprumuturi))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] lineSplit = line.Split(';');
                    Imprumut imprumut = new Imprumut();
                    int.TryParse(lineSplit[0], out imprumut.idCarte);
                    int.TryParse(lineSplit[1], out imprumut.idPers);
                    imprumut.Date_out = lineSplit[2];
                    listaImprumuturi.Add(imprumut);
                }
                return listaImprumuturi;
            }
        }
       

    }
}
