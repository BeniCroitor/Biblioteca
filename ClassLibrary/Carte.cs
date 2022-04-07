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
        public string Nume;
        public string Editura;
        public string Autor;
        public string ISBN;
        public int anAparitie;
        public int anEditie;
        public int nrExemplare;
        public int id;


        //Metode:

        // Constructor gol

        public Carte(int g)
        { }

        //Constructor 
        public Carte(string nume = "", string autor = "", string editura = "", string isbn = "", int anaparitie = 0, int aneditie = 0, int nrexemplare = 0, int ID = 0)
        {
            Nume = nume;
            Autor = autor;
            Editura = editura;
            ISBN = isbn;
            anAparitie = anaparitie;
            anEditie = aneditie;
            nrExemplare = nrexemplare;
            id = ID;
        }

        // Citire carte de la tastatura

         public Carte()
        {
            Console.WriteLine("Dati titlul cartii: ");
            Nume = Console.ReadLine();
            Console.WriteLine("Dati autorul cartii: ");
            Autor = Console.ReadLine();
            Console.WriteLine("Dati editura cartii: ");
            Editura = Console.ReadLine();
            Console.WriteLine("Dati ISBN-ul cartii: ");
            ISBN = Console.ReadLine();
            Console.WriteLine("Dati anul aparitiei cartii: ");
            int.TryParse(Console.ReadLine(), out anAparitie);
            Console.WriteLine("Dati anul editiei cartii: ");
            int.TryParse(Console.ReadLine(), out anEditie);
            Console.WriteLine("Dati nr de exemplare: ");
            int.TryParse(Console.ReadLine(), out nrExemplare);
        }

        //Stocare carte in fisier

        public void SalvareCarte()
        {
            if (this.IsDuplicate() == 0)
            {

                string path = @"Biblioteca.txt";
                var lineCount = File.ReadLines(path).Count();

                using (StreamWriter sw = File.AppendText(path))
                {
                    string fileLine = Convert.ToString(lineCount + 1) + ";" + Convert.ToString(this.Nume) + ";" + Convert.ToString(this.Autor) + ";" + Convert.ToString(this.Editura) + ";" + Convert.ToString(this.ISBN) + ";" + Convert.ToString((this.anAparitie)) + ";" + Convert.ToString((this.anEditie)) + ";" + Convert.ToString((this.nrExemplare));
                    sw.WriteLine(fileLine);
                }
            }
            else
                if (this.IsDuplicate() == -1)
                    Console.WriteLine("Cartea nu a putut fi salvata");
            else
                IncExemplar();
        }


        // Extragere Carte

        public void ExtragereCarte(string ID)
        {
            string path = @"Biblioteca.txt";

            using (StreamReader sr = File.OpenText(path))
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
                        this.Nume = vs[1];
                        this.Autor = vs[2];
                        this.Editura = vs[3];
                        this.ISBN = vs[4];
                        this.anAparitie = Convert.ToInt16(vs[5]);
                        this.anEditie = Convert.ToInt16(vs[6]);
                        this.nrExemplare = Convert.ToInt16(vs[7]);
                        this.id = Convert.ToInt16(vs[0]);
                    }
                    
                }
                
            }
        }

        // Afisare Carte

        public void AfisareCarte()
        {
            Console.Write("\n\n------------------------\n\n");

            Console.WriteLine("Id Carte:  {0}", id);
            Console.WriteLine("Titlu:  {0}", Nume);
            Console.WriteLine("Autor:  {0}", Autor);
            Console.WriteLine("Editura:  {0}", Editura);
            Console.WriteLine("ISBN: {0}",ISBN);
            Console.WriteLine("Anul aparitiei:  {0}", anAparitie);
            Console.WriteLine("Nr exemplare:  {0}", nrExemplare);
            Console.WriteLine("Anul editiei:  {0}", anEditie);

            Console.Write("\n------------------------\n\n");
        }

        // Afisare fara ID

        public void AfisareCarteFaraID()
        {
            Console.Write("------------------------\n\n");

            Console.WriteLine("Titlu:  {0}", Nume);
            Console.WriteLine("Autor:  {0}", Autor);
            Console.WriteLine("Editura:  {0}", Editura);
            Console.WriteLine("ISBN: {0}", ISBN);
            Console.WriteLine("Anul aparitiei:  {0}", anAparitie);
            Console.WriteLine("Nr exemplare:  {0}", nrExemplare);
            Console.WriteLine("Anul editiei:  {0}", anEditie);

            Console.Write("\n------------------------\n\n");
        }

        public static void AfisareCarti()
        {

            string path = @"Biblioteca.txt";
            string[] lines = File.ReadAllLines(path);
            Console.WriteLine("\n\n\n@@@@@@@@@@@@@@   LISTA CARTILOR DIN BIBLIOTECA    @@@@@@@@@@@@@@@@\n\n");
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                Console.WriteLine("------------\nID: {0}",parts[0]);
                Console.WriteLine("Titlu: {0}", parts[1]);
                Console.WriteLine("Autor: {0}", parts[2]);
                Console.WriteLine("Editura: {0}", parts[3]);
                Console.WriteLine("ISBN: {0}", parts[4]);
                Console.WriteLine("Anul aparitiei: {0}", parts[5]);
                Console.WriteLine("Anul editiei curente: {0}", parts[6]);
                Console.WriteLine("Nr exemplare: {0}", parts[7]);
            }
            Console.WriteLine("\n\n\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n\n");
        }

        // Meniu cautare

        public void Search()
        {
            Console.WriteLine("Dupa ce criterii doriti sa cautati?\n");

            Console.WriteLine("1. Nume");
            Console.WriteLine("2. Autor");
            Console.WriteLine("Dupa ce criterii doriti sa cautati?");
            string c = Console.ReadLine();

            switch (c)
            {
                // Cautare dupa titlu
                case "1":
                    int idSearch = CautareCarte();
                    ExtragereCarte(Convert.ToString(idSearch));
                    break;
            }
        }


        // Cautare carte dupa nume

        private int CautareCarte()
        {

                Console.WriteLine("Dati titlul cartii pe care o cautati: ");

                string titlu = Console.ReadLine();
                string path = @"Biblioteca.txt";

                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] lineSplit = line.Split(';');
                        if (lineSplit[1] == titlu)
                        {
                            int.TryParse(lineSplit[0], out int result);
                            return result;
                        }
                    }
                }
                return 0;
        }


        // Verificare daca exista deja cartea:

        private int IsDuplicate()
        {
            string path = @"Biblioteca.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                sr.BaseStream.Position = 0;
                string line;
                int LineCounter = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] vs = line.Split(';');
                    LineCounter++;
                    int.TryParse (vs[5], out int anA);
                    int.TryParse(vs[6], out int anE);
                    if (Nume == vs[1] & Autor == vs[2] & Editura == vs[3] & ISBN == vs[4] & anAparitie == anA & anEditie == anE)
                        return LineCounter;
                    
                }
                return -1;

            }


        }


        // Adaugare exemplar

        private void IncExemplar()
        {
            string path = @"Biblioteca.txt";
            string[] lines = File.ReadAllLines(path);
            

            int idD = this.IsDuplicate();
            int ExemplNou = this.nrExemplare + this.GetExemplare(idD);
            string LineAmend = Convert.ToString(idD) + ";" + Convert.ToString(this.Nume) + ";" + Convert.ToString(this.Autor) + ";" + Convert.ToString(this.Editura) + ";" + Convert.ToString(this.ISBN) + ";" + Convert.ToString((this.anAparitie)) + ";" + Convert.ToString((this.anEditie)) + ";" + Convert.ToString((ExemplNou));

            lines[idD-1] = LineAmend;
            File.WriteAllLines(path, lines);

        }


        // Functie ce returneaza nr de exemplare

        private int GetExemplare(int id)
        {
            string path = @"Biblioteca.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] lineSplit = line.Split(';');
                    if (int.TryParse(lineSplit[0], out int ID) == true & ID == id)
                    {
                        int.TryParse(lineSplit[7], out int result);
                        return result;
                    }
                }
            }
            return -1;
        }

    }
}

