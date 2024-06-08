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
        string[] map = new string[] { "═", "║", "╗", "╔", "╝", "╚" };
        Console.WriteLine("Ingresa numero de filas");
        int row, col;
        bool r = int.TryParse(Console.ReadLine(), out row);
        Console.WriteLine("Ingresas el numero de columnas");
        bool c = int.TryParse(Console.ReadLine(), out col);
        if (c && r)
        {
            string[,] ways = new string[row, col];
            int top = 0, bottom = row - 1, left = 0, right = col - 1;
            for (int count = 0; count < ways.GetLength(0); count++)
            {
                for (int j = 0; j < ways.GetLength(1) && i == 0; j++)/*1 fila caracol*/
                {
                    ways[i, j] = map[0];
                    if (j == (ways.GetLength(1) - 1))
                    {
                        ways[i, j] = map[2];
                    }
                }
                for (int j = 4; i < ways.GetLength(0); i++)/*1 columna caracol*/
                {
                    ways[i, j] = map[1];
                    if (i == (ways.GetLength(0) - 1))
                    {
                        ways[i, j] = map[4];
                    }
                }
                for (int j = 3; j >= 0; j--)/*2 fila caracol*/
                {
                    ways[i, j] = map[0];
                    if (j == 0)
                    {
                        ways[i, j] = map[5];
                    }
                }
                for (int j = 0; i > 0; i--)/*2 columna caracol*/
                {
                    ways[i, j] = map[1];
                    if (i == 1)
                    {
                        ways[i, j] = map[3];
                    }
                }
                for (int j = 1; j <= ways.GetLength(1) - 2; j++)/*3 fila caracol*/
                {
                    ways[i, j] = map[0];
                    if (j == 3)
                    {
                        ways[i, j] = map[2];
                    }
                }
                i++;
                for (int j = 3; i < ways.GetLength(0); i++) /*3 columna*/
                {
                    ways[i, j] = map[1];
                    if (i == 3)
                    {
                        ways[i, j] = map[4];
                    }
                }
                for (int j = 2; j > 1; j--) /*4 fila*/
                {
                    ways[i, j] = map[4];
                    if (j == 1)
                    {
                        ways[i, j] = map[5];
                    }
                }
            }

        }

    }
}
