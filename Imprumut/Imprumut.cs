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
        int idPers;
        int idCarte;
        DateTime Date_out;

        // Constructor cu parametrii
        public Imprumut(int IDPERS, int IDCARTE)
        {
            idPers = IDPERS;
            idCarte = IDCARTE;
            Date_out = DateTime.Now;
        }



        // Salvare imprumut in fisier
        public void SalvareImprumut()
        {
            string path = @"Imprumuturi.txt";
            string[] lines = File.ReadAllLines(path);
            string imprumut = "#" + Convert.ToString(idCarte) + "|" + Convert.ToString(Date_out);
            if (SearchImprumut(idPers) == true)
            {
                int idImp = 0;
                int contor = 0;
                foreach (string line in lines)
                {
                    string[] lineSpl = line.Split(';');
                    if (lineSpl[0] == Convert.ToString(idPers))
                    {
                        idImp = contor;
                        break;
                    }
                    contor++;
                }
                lines[idImp] = imprumut;
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(Convert.ToString(idPers) + ";" + imprumut);
                }
            }
        }

        // Cauta daca persoana exista deja in fisierul de imprumuturi
        private static bool SearchImprumut(int IDPERS)
        {
            string path = @"Imprumuturi.txt";
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] lineSplit = line.Split(';');
                if (Convert.ToString(IDPERS) == lineSplit[0])
                    return true;
            }
            return false;
        }





    }
}
