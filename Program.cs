namespace Bingo
{
    internal class Program
    {
        static void Main(string[] args)
        {
			// 1. feladat
			// Konzolos alkalmazás létrehozása Bingo néven

			// 3. feladat
			// Játékosok beolvasása és eltárolása

			List<BingoJatekos> jatekosok = new List<BingoJatekos>();

			if (File.Exists("nevek.text"))
			{
				foreach (var fajl in File.ReadAllLines("nevek.text"))
				{
					if (File.Exists(fajl))
					{
						jatekosok.Add(new BingoJatekos(fajl));
					}
				}
			}
			else if (File.Exists("Andi.txt"))
			{
				jatekosok.Add(new BingoJatekos("Andi.txt"));
			}



		}
	}
}
