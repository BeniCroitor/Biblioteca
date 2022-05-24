using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClasaCarte
{

    public class Carte
    {
        // Date:
        public string Titlu;
        public string Editura;
        public string Autor;
        public string ISBN;
        public int anAparitie;
        public int nrExemplare;
        public int id;

        const string numeFisier = @"Biblioteca.txt";

        private static string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        public static string pathBiblioteca = locatieFisierSolutie + "\\" + numeFisier;

        //Metode:

        // Constructor gol

        public Carte()
        { }

        //Constructor 
        public Carte(string titlu = "", string autor = "", string editura = "", string isbn = "", int anaparitie = 0, int nrexemplare = 0, int ID = 0)
        {
            Titlu = titlu;
            Autor = autor;
            Editura = editura;
            ISBN = isbn;
            anAparitie = anaparitie;
            nrExemplare = nrexemplare;
            id = ID;
        }

        //// Citire carte de la tastatura

        // public Carte()
        //{
        //    Console.WriteLine("Dati titlul cartii: ");
        //    Titlu = Console.ReadLine();
        //    Console.WriteLine("Dati autorul cartii: ");
        //    Autor = Console.ReadLine();
        //    Console.WriteLine("Dati editura cartii: ");
        //    Editura = Console.ReadLine();
        //    Console.WriteLine("Dati ISBN-ul cartii: ");
        //    ISBN = Console.ReadLine();
        //    Console.WriteLine("Dati anul aparitiei cartii: ");
        //    int.TryParse(Console.ReadLine(), out anAparitie);
        //    Console.WriteLine("Dati anul editiei cartii: ");
        //    int.TryParse(Console.ReadLine(), out anEditie);
        //    Console.WriteLine("Dati nr de exemplare: ");
        //    int.TryParse(Console.ReadLine(), out nrExemplare);
        //}

        //Stocare carte in fisier

        public void SalvareCarte()
        {
            if (this.IsDuplicate() == 0 || this.IsDuplicate() == -1) 
            {

                var lineCount = File.ReadLines(pathBiblioteca).Count();

                using (StreamWriter sw = File.AppendText(pathBiblioteca))
                {
                    string fileLine = Convert.ToString(lineCount + 1) + ";" + Convert.ToString(this.Titlu) + ";" + Convert.ToString(this.Autor) + ";" + Convert.ToString(this.Editura) + ";" + Convert.ToString(this.ISBN) + ";" + Convert.ToString((this.anAparitie)) + ";" + Convert.ToString((this.nrExemplare));
                    sw.WriteLine(fileLine);
                }
            }
            else
                     this.IncExemplar();

        }


        // Extragere Carte

        public void ExtragereCarte(string ID)
        {
            using (StreamReader sr = File.OpenText(pathBiblioteca))
            {
                sr.BaseStream.Position = 0;
                string line;
                int LineCounter = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] vs = line.Split(';');
                    LineCounter++;
                    if (Convert.ToString(LineCounter) == ID)
                    {
                        this.Titlu = vs[1];
                        this.Autor = vs[2];
                        this.Editura = vs[3];
                        this.ISBN = vs[4];
                        this.anAparitie = Convert.ToInt16(vs[5]);
                        this.nrExemplare = Convert.ToInt16(vs[6]);
                        this.id = Convert.ToInt16(vs[0]);
                    }
                    
                }
                
            }
        }

        // Afisare Carte

        //public void AfisareCarte()
        //{
        //    Console.Write("\n\n------------------------\n\n");

        //    Console.WriteLine("Id Carte:  {0}", id);
        //    Console.WriteLine("Titlu:  {0}", Titlu);
        //    Console.WriteLine("Autor:  {0}", Autor);
        //    Console.WriteLine("Editura:  {0}", Editura);
        //    Console.WriteLine("ISBN: {0}",ISBN);
        //    Console.WriteLine("Anul aparitiei:  {0}", anAparitie);
        //    Console.WriteLine("Nr exemplare:  {0}", nrExemplare);

        //    Console.Write("\n------------------------\n\n");
        //}

        // Afisare fara ID

        //public void AfisareCarteFaraID()
        //{
        //    Console.Write("------------------------\n\n");

        //    Console.WriteLine("Titlu:  {0}", Titlu);
        //    Console.WriteLine("Autor:  {0}", Autor);
        //    Console.WriteLine("Editura:  {0}", Editura);
        //    Console.WriteLine("ISBN: {0}", ISBN);
        //    Console.WriteLine("Anul aparitiei:  {0}", anAparitie);
        //    Console.WriteLine("Nr exemplare:  {0}", nrExemplare);
        //    Console.WriteLine("Anul editiei:  {0}", anEditie);

        //    Console.Write("\n------------------------\n\n");
        //}

                
        // Returneaza ID-ul cartii cu titlul acela

        //private int CautareCarte()
        //{

        //        Console.WriteLine("Dati titlul cartii pe care o cautati: ");

        //        string titlu = Console.ReadLine();
        //        string path = @"Biblioteca.txt";

        //        using (StreamReader sr = new StreamReader(path))
        //        {
        //            while (!sr.EndOfStream)
        //            {
        //                string line = sr.ReadLine();
        //                string[] lineSplit = line.Split(';');
        //                if (lineSplit[1] == titlu)
        //                {
        //                    int.TryParse(lineSplit[0], out int result);
        //                    return result;
        //                }
        //            }
        //        }
        //        return 0;
        //}


        // Verificare daca exista deja cartea:

        private int IsDuplicate()
        {
            using (StreamReader sr = File.OpenText(pathBiblioteca))
            {
                sr.BaseStream.Position = 0;
                string line;
                int LineCounter = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] vs = line.Split(';');
                    LineCounter++;
                    int.TryParse (vs[5], out int anA);
                    if (Titlu == vs[1] & Autor == vs[2] & Editura == vs[3] & ISBN == vs[4] & anAparitie == anA)
                        return LineCounter;
                    
                }
                return -1;

            }


        }


        // Adaugare exemplar

        private void IncExemplar()
        {
            string[] lines = File.ReadAllLines(pathBiblioteca);
            

            int idD = this.IsDuplicate();
            int ExemplNou = this.nrExemplare + this.GetExemplare(idD);
            string LineAmend = Convert.ToString(idD) + ";" + Convert.ToString(this.Titlu) + ";" + Convert.ToString(this.Autor) + ";" + Convert.ToString(this.Editura) + ";" + Convert.ToString(this.ISBN) + ";" + Convert.ToString((this.anAparitie)) + ";" + Convert.ToString((ExemplNou));

            lines[idD-1] = LineAmend;
            File.WriteAllLines(pathBiblioteca, lines);

        }


        // Functie ce returneaza nr de exemplare

        private int GetExemplare(int id)
        {

            using (StreamReader sr = new StreamReader(pathBiblioteca))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] lineSplit = line.Split(';');
                    if (int.TryParse(lineSplit[0], out int ID) == true & ID == id)
                    {
                        int.TryParse(lineSplit[6], out int result);
                        return result;
                    }
                }
            }
            return -1;
        }


        // Returneaza lista cu toate cartile din fisier

        static public List<Carte> ReturnCarti()
        {
            List<Carte> listaCarti = new List<Carte>();
            using (StreamReader sr = new StreamReader(pathBiblioteca))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] lineSplit = line.Split(';');
                    Carte carte = new Carte();
                    carte.Titlu = lineSplit[1];
                    carte.Autor = lineSplit[2];
                    carte.Editura = lineSplit[3];
                    carte.ISBN = lineSplit[4];
                    int.TryParse(lineSplit[5], out carte.anAparitie);
                    int.TryParse(lineSplit[6], out carte.nrExemplare);
                    int.TryParse(lineSplit[0], out carte.id);
                    listaCarti.Add(carte);
                }
                return listaCarti;
            }
        }



        // Returneaza lista cu numele cartilor

        static public List<string> ListaNumeCarti()
        {
            List<string> listaNumeCarti = new List<string>();
            using (StreamReader sr = new StreamReader(pathBiblioteca))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] lineSplit = line.Split(';');

                    listaNumeCarti.Add(lineSplit[1] + " - " + lineSplit[2]);
                }
                return listaNumeCarti;
            }
        }

        // Functie ce returneaza ID ul unei carti dupa nume si autor

        static public int SearchTitlu(string titlu)
        {
            using (StreamReader sr = new StreamReader(pathBiblioteca))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] lineSplit = line.Split(';');
                    string[] titluSplit = titlu.Split('-');

                    if (lineSplit[1] == titluSplit[0].Trim() && lineSplit[2] == titluSplit[1].Trim())
                    {
                        int.TryParse(lineSplit[0], out int result);
                        return result;
                    }

                }
                return -1;
            }
        }

        //      REVERSE::  Functie ce returneaza ID ul unei carti dupa nume si autor

        static public string SearchID(int id)
        {
            using (StreamReader sr = new StreamReader(pathBiblioteca))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] lineSplit = line.Split(';');

                    if (lineSplit[0] == Convert.ToString(id))
                    {
                        return lineSplit[1] + " - " + lineSplit[2];
                    }

                }
                return "Eroare";
            }
        }

    }
}

