using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizovi
{
	class Program
	{
		static void Main(string[] args)
		{
			string tel1 = "12345678";
			string tel2 = "234234234";
			string tel3 = "235235234";

			string test = "Zdravo :) ";
			for (int dex = 0; dex < test.Length; dex++)
			{
				Console.WriteLine(test[dex]);
			}
			

			int x = 5;
			          //niz sa poznatim vrednostima
			int[] niz = { 5, 6, 7, 8 };
			string[] nizTxt = { "asd", "dsa", "asd" };

			char[] nizKaratera = { 'Z', 'd', 'r', 'a', 'v', 'o' }; 

			           //"prazan" niz od 4 elementa
			int[] niz2 = new int[4];

			int[,] matrica = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

			Console.WriteLine("Duzina matrice je: " + matrica.Length / 3);
			for (int red = 0; red < matrica.Length/3; red++)
			{
				for (int kol = 0; kol < matrica.Length / 3; kol++)
				{
					Console.Write($"  {matrica[red, kol]}  ");
				}
				Console.WriteLine();
			}
			                 
			for (int indeks = 0; indeks < niz.Length; indeks++)
			{
				//Console.WriteLine(niz[indeks]);
			}

			Console.ReadKey();
		}
	}
}
