using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClasaCarte;
using ClasaPersoana;

namespace ClasaImprumut
{
    public class Imprumut
    {
        const string numeFisier = @"Imprumuturi.txt";
        const string numeFisierIstoric = @"IstoricImprumuturi.txt";

        private static string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        public static string pathImprumuturi = locatieFisierSolutie + "\\" + numeFisier;
        public static string pathIstoric = locatieFisierSolutie + "\\" + numeFisierIstoric;

        public int idImprumut { get; set; }
        public int idPers { get; set; }
        public int idCarte { get; set; }
        public string Date_out { get; set; }


        // Constructor fara param
        public Imprumut()
        { }


        // Constructor cu parametrii
        public Imprumut(int IDPERS, int IDCARTE)
        {
            idImprumut = Imprumut.GetLastID() + 1;
            idPers = IDPERS;
            idCarte = IDCARTE;
            Date_out = " ";

        }



        // Salvare imprumut in fisier
        public void SalvareImprumut()
        {
            string[] lines = File.ReadAllLines(pathImprumuturi);
            string imprumut = Convert.ToString(idImprumut) + ";" + Convert.ToString(idPers) + ";" + Convert.ToString(idCarte) + ";" + DateTime.Now.ToString("dd/MM/yyyy");
            using (StreamWriter sw = new StreamWriter(pathImprumuturi, true))
            {
                sw.WriteLine(imprumut);
            }
            using (StreamWriter sw = new StreamWriter(pathIstoric, true))
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
                    int.TryParse(lineSplit[0], out int idImprumut);
                    int.TryParse(lineSplit[1], out int idCarte);
                    int.TryParse(lineSplit[2], out int idPers);
                    imprumut.idPers = idPers;
                    imprumut.idCarte = idCarte;
                    imprumut.idImprumut = idImprumut;

                    imprumut.Date_out = lineSplit[3];
                    listaImprumuturi.Add(imprumut);
                }
                return listaImprumuturi;
            }
        }

        // Functie ce sterge un imprumut din fisier dupa id

        public static void ReturnCarte(int idImprumut , int idCarte, int idPers, string Data)
        {
            string[] lines = File.ReadAllLines(pathImprumuturi);
            int i = 0;
            foreach (string line in lines)
            {
                if( line == "")
                    continue;
                else
                {
                    i++;
                    string[] lineSplit = line.Split(';');
                    if (Convert.ToString(idCarte) == lineSplit[1] && Convert.ToString(idPers) == lineSplit[2] && Data == lineSplit[3] && lineSplit[0] == Convert.ToString(idImprumut))
                    {
                        for (int j = i - 1; j < lines.Length - 1; j++)
                        {
                            lines[j] = lines[j + 1];
                        }
                        lines[lines.Length - 1] = string.Empty;
                    }
                }
                
            }
            string[] newLines = new string[lines.Length - 1];
            for (int j = 0; j < lines.Length - 1; j++)
                newLines[j] = lines[j];
            File.WriteAllLines(pathImprumuturi, newLines);
        }


        // Returneaza true daca mai sunt exemplare ale cartii care nu au fost imprumutate
        public static bool Available(int idCarte)
        {
            int i = 0;

            string[] lines = File.ReadAllLines(pathImprumuturi);

            foreach (string line in lines)
            {
                string[] lineSplit = line.Split(';');
                if (lineSplit[1] == Convert.ToString(idCarte))
                    i++;
            }
            if (i < Carte.RetNrExemplare(idCarte))
                return true;
            return false;
        }

        // Returneaza true daca persoana a imprumutat deja 3 carti
        public static bool DepasitLimita(int idPers)
        {
            int i = 0;

            string[] lines = File.ReadAllLines(pathImprumuturi);

            foreach (string line in lines)
            {
                string[] lineSplit = line.Split(';');
                if (lineSplit[2] == Convert.ToString(idPers))
                    i++;
            }
            if (i >= 3)
                return true;
            return false;
        }

        // Returneaza nr de carti pre care le-a imprumutat o persoana
        public static int NrCartiImprumutate(int idPers)
        {
            int i = 0;

            string[] lines = File.ReadAllLines(pathImprumuturi);

            foreach (string line in lines)
            {
                string[] lineSplit = line.Split(';');
                if (lineSplit[2] == Convert.ToString(idPers))
                    i++;
            }
            return i;
        }

        // Primeste ID-ul unei carti si returneaza nr de exemplare imprumutate (unavailable)
        public static int NrExempalreValabile(int idCarte)
        {
            int i = 0;

            string[] lines = File.ReadAllLines(pathImprumuturi);

            foreach (string line in lines)
            {
                string[] lineSplit = line.Split(';');
                if (lineSplit[1] == Convert.ToString(idCarte))
                    i++;
            }
            return i;
        }

        // Functie ce primeste ID-ul cartii imprumutate si ID-ul persoanei si care marcheaza in istoric data returnarii cartii
        public static void SalvareReturnare(int idCarte, int idPers, int idImprumut)
        {
            string[] lines = File.ReadAllLines(pathIstoric);
            int i = 0;

            foreach(string line in lines)
            {
                string[] lineSplit = line.Split(';');
                if (lineSplit[1] == Convert.ToString(idCarte) && lineSplit[2] == Convert.ToString(idPers) && lineSplit[0] == Convert.ToString(idImprumut))
                    break;
                i++;
            }
            lines[i] = lines[i] + ";" + Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));

            File.WriteAllLines(pathIstoric, lines);
        }


        static public int GetLastID()
        {
            string[] lines = File.ReadAllLines(pathIstoric);
            if(lines.Length == 0)
                return 0;
            else
            {
                string line = lines[lines.Length - 1];
                string[] lineSplit = line.Split(';');
                return Convert.ToInt32(lineSplit[0]);
            }
            
        }

    }
}
