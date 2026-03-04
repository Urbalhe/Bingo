using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
	internal class BingoJatekos
	{
		string name;
		int kartya;

		public BingoJatekos(string name, int kartya)
		{
			this.name = name;
			this.kartya = kartya;
		}

		public string Name { get => name; set => name = value; }
		public int Kartya { get => kartya; set => kartya = value; }

		public override string? ToString()
		{
			return $"{name} - {kartya}";
			
			
		}
	}

	
}
