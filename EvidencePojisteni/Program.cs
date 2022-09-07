using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
	class Program
	{

		static void Main(string[] args)
		{
			Evidence evidence = new Evidence();
			char volba = '0';
			///hlavní cyklus pro volbu operace
			///
			while (volba != '4')
			{
				evidence.HlavniMenu();

				volba = Console.ReadKey().KeyChar;
				Console.WriteLine("");
				Console.WriteLine("");

				switch (volba)
				{
					case '1':
						evidence.PridejZaznam();
						break;
					case '2':
						evidence.VyhledejZaznam();
						break;
					case '3':
						evidence.VypisVsechnyZaznamy();
						break;
					case '4':
						Console.WriteLine("Libovolnou klávesou program ukončíte");
						break;
					default:
						Console.WriteLine("Neplatná volba, operace jsou [1 - 4], stiskněte libovolnou klávesu a volbu opakujte");
						break;
				}
				Console.ReadKey();
			}
		}
	}
}

