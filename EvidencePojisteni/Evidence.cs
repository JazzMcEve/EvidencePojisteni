using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class Evidence
    {
        /// <summary>
        /// vložíme databázi do evidence pro zadávání uživatelských vstupů
        /// </summary>
        private Databaze databaze;
        public Evidence()
        {
            databaze = new Databaze();
        }
        /// <summary>
        /// pomocná metoda pro zadání celého jména pro přidání nového záznamu a key pro vyhledávání konkrétního záznamu
        /// </summary>
        /// <returns>vrací celeJmeno</returns>
        private string ZjistiCeleJmeno()
        {
            Console.WriteLine("");
            Console.WriteLine("Zadejte jméno:");
            String Jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení");
            string Prijmeni = Console.ReadLine();
            return string.Format("{0} {1}", Jmeno, Prijmeni);
        }
        /// <summary>
        /// vypisuje celý obsah kolekce do konzole
        /// </summary>
        public void VypisVsechnyZaznamy()
        {
            Console.WriteLine("");
            Console.WriteLine("Všechny záznamy:");
            List<Zaznam> zaznamy = databaze.VypisVsechnyZaznamy();
            foreach (Zaznam z in zaznamy)
                Console.WriteLine(z);
        }
        /// <summary>
        /// zjistí jestli je pojištěný v kolekci pomocí pomocné metody a vypíše ho
        /// </summary>
        public void VyhledejZaznam()
        {
            Console.WriteLine("Najdi pojištěného:");
            string celeJmeno = ZjistiCeleJmeno();
            HashSet<Zaznam> zaznamy = databaze.NajdiUzivatele(celeJmeno, false);
            if (zaznamy.Count() > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Nalezen pojištěnec: ");
                foreach (Zaznam z in zaznamy)
                    Console.WriteLine(z);
            }
            else
            {
                // nebo nevypíše, když kolekce celeJmeno neobsahuje 
                Console.WriteLine("");
                Console.WriteLine("Nebyl nalezen žádný pojištěnec");
            }
            
        }
        /// <summary>
        /// přidání nového pojištěného do kolekce s pomocnou metodou
        /// </summary>
        public void PridejZaznam()
        {
            Console.WriteLine("Přidat nového pojištěného:");
            string celeJmeno = ZjistiCeleJmeno();
            Console.WriteLine("zadejte věk:");
            byte vek = byte.Parse(Console.ReadLine());
            Console.WriteLine("zadejte telefon:");
            long telefon = long.Parse(Console.ReadLine());
            databaze.PridejZaznam(celeJmeno, vek, telefon);
            Console.WriteLine("Nový pojištěný uložen");
        }
        /// <summary>
        /// vymaže konzoli a vypíše hlavičku hlavního menu
        /// </summary>
        public void HlavniMenu()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine(" # *** EvidencePojištěných *** # ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Vítejte v hlavním menu");
            Console.WriteLine();
            Console.WriteLine("Vyberte akci:");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vyhledat pojištěného");
            Console.WriteLine("3 - Vypsat všechny pojištěné");
            Console.WriteLine("4 - Ukončit evidenci pojištěných");
        }
    }
}
