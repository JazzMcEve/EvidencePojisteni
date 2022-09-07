using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class Databaze
    {
        /// <summary>
        /// privátní List s kolekcí pojištěných
        /// </summary>
        private List<Zaznam> zaznamy;
        public Databaze()
        {
            zaznamy = new List<Zaznam>();
        }
        public void PridejZaznam(string celeJmeno, byte vek, long telefon)//přidání nového pojištěného
        {
            zaznamy.Add(new Zaznam(celeJmeno, vek, telefon));
        }
        /// <summary>
        /// vypisuje obsah celé kolekce zaznamy
        /// </summary>
        /// <returns>vrací výpis kolekce zaznamy</returns>
       public List<Zaznam> VypisVsechnyZaznamy()
        {
            List<Zaznam> vsechnyZaznamy = new List<Zaznam>();
            foreach (Zaznam z in zaznamy)
            {
                vsechnyZaznamy.Add(z);
            }
            return zaznamy;
        }
        /// <summary>
        /// množina do které se vloží Zaznam z kolekce zaznamy pomocí pomocné metody
        /// </summary>
        /// <param name="celeJmeno"></param>
        /// <param name="podleJmena"></param>
        /// <returns>vrací výpis množiny nalezenyUzivatel</returns>
        public HashSet<Zaznam> NajdiUzivatele(string celeJmeno, bool podleJmena)
        {
            HashSet<Zaznam> nalezenyUzivatel = new HashSet<Zaznam>();
            foreach (Zaznam z in zaznamy)
            {
                if ((!podleJmena) && (z.CeleJmeno == celeJmeno))
                    nalezenyUzivatel.Add(z);
            }
            return nalezenyUzivatel;
        }
        
    }
}

