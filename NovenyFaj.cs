using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UveghazProjekt
{
	internal class NovenyFaj
	{
		//o	Azonosito, Nev o IdealTalajnedvesseg, IdealHomersekleto MinSuruseg, OptimalisSuruseg, MaxSuruseg
		
		string nev;
		int vizigeny; // max 100, azon tul egészségi allapota romik
		int egeszsegiAllapot; // 0-10, ahol 0: elpusztult 
		int optimalisSuruseg;

		public NovenyFaj(string nev, int vizigeny, int egeszsegiAllapot, int optimalisSuruseg)
		{
			
			this.nev = nev;
			this.vizigeny = vizigeny;
			this.egeszsegiAllapot = egeszsegiAllapot;
			this.optimalisSuruseg = optimalisSuruseg;
		}

		public string Azonosito { get => this.nev.Substring(0,3); }
		public string Nev { get => nev; set => nev = value; }
		public int Vizigeny { get => vizigeny; set => vizigeny = value; }
		public int EgeszsegiAllapot { get => egeszsegiAllapot; set => egeszsegiAllapot = value; }
		public int OptimalisSuruseg { get => optimalisSuruseg; set => optimalisSuruseg = value; }


		public override string ToString()
		{
			return $"{this.nev} ({this.Azonosito}) {this.vizigeny} {this.egeszsegiAllapot}";
		}
	}
}
