namespace Consola;

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
class Program
{
	public static void Main(string[] args)
	{
		//string[] map = new string[] { "═", "║", "╗", "╔", "╝", "╚" };
		Console.WriteLine("Ingresa numero de filas");
		int row, col;
		bool r = int.TryParse(Console.ReadLine(), out row);
		Console.WriteLine("Ingresas el numero de columnas");
		bool c = int.TryParse(Console.ReadLine(), out col);
		if (c && r)
		{
			string[,] ways = new string[row, col];
			int a = 0, b = col - 1;
			for (int count = 0; count < ways.GetLength(0); count++)
			{
				for (int i = a; i <= b; i++)
				{
					ways[a, i] = "═";
					if (i == b)
					{
						ways[a, i] = "╗";
					}
				}
				for (int i = a + 1; i <= b; i++)
				{
					ways[i, b] = "║";
					if (i == b)
					{
						ways[i, b] = "╝";
					}
				}
				for (int i = b - 1; i >= a; i--)
				{
					ways[b, i] = "═";
					if (i == a)
					{
						ways[b, i] = "╚";
					}
				}
				for (int i = b - 1; i >= a + 1; i--)
				{
					ways[i, a] = "║";
					if (i == a + 1)
					{
						ways[i, a] = "╔";
					}
				}
				a++; b--;
			}
			for (int i = 0; i < ways.GetLength(0); i++)
			{
				for (int j = 0; j < ways.GetLength(1); j++)
				{
					Console.Write(ways[i, j]);
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}
