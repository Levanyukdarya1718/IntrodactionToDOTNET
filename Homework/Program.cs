using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n;
			Console.Write("Введите размеры прямоугольника:");
			n=int.Parse(Console.ReadLine());
			
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.WriteLine("Введите высоту треугольника 1:");
			n = int.Parse(Console.ReadLine());
			for (int i=1; i<=n; i++)
			{
				for(int j = 0;j<i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.Write("Введите высоту треугольника 2:");
			n=int.Parse(Console.ReadLine());
			for(int i=n; i >= 1; i--)
			{
				for(int j=0;j<i; j++)
				{
					Console.Write("*");
				}
					Console.WriteLine();
			}
			Console.Write("Введите высоту треугольника 3:");
			n=int.Parse(Console.ReadLine());
			for(int i=n;i>=1; i--)
			{
				for(int j = 0; j > i; j--)
				{
					Console.Write("  ");
				}
				for(int j = 0; j < i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();	
			}
			Console.WriteLine("Введите высоту треугольника 4:");
			n=int.Parse(Console.ReadLine());
			for(int i=1; i<=n; i++)
			{
				for(int j=n;j>i; j--)
				{
					Console.Write(" ");
				}
				for(int j = 0; j < i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine() ;
			}
			Console.WriteLine("Введите размер ромба:");
			n = int.Parse(Console.ReadLine());
			for(int i=0; i < n; i++)
			{
				for(int j=i; j<n;j++)
				{
					Console.Write(" ");
				}
				Console.Write("/");
				for (int j = 0; j < i * 2; j++) 
				{
					Console.Write(" ");
				}
				Console.Write("\\ ");
				Console.WriteLine();
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					Console.Write(" ");
				}
				Console.Write("\\");
				for (int j = (n - i - 1) * 2; j > 0; j--)
				{
					Console.Write(" ");
				}
				Console.Write("/");
				Console.WriteLine();
			}


			Console.Write("Введите размер фигуры:");
			n=int.Parse(Console.ReadLine());
			for(int i=0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if ((i+j)%2==0)
					{
						Console.Write("+");

					}
					else
					{

					Console.Write("-"); }
				}
				Console.WriteLine();
			}
			Console.Write("Введите размер доски: ");
			int boardSize = int.Parse(Console.ReadLine());
			Console.Write("Введите размер клетки: ");
			int cellSize = int.Parse(Console.ReadLine());

			for (int chessboardRow = 0; chessboardRow < boardSize; chessboardRow++)
			{
				for (int cellRow = 0; cellRow < cellSize; cellRow++) 
				{
					for (int chessboarCol = 0; chessboarCol < boardSize; chessboarCol++)
					{
						
						if ((chessboardRow + chessboarCol) % 2 == 0)
						{
							for (int cellCol = 0; cellCol < cellSize; cellCol++) 
							{
								Console.BackgroundColor = ConsoleColor.Gray;
								Console.ForegroundColor = ConsoleColor.Gray;
								Console.Write("* ");
								
								
							}
							Console.ResetColor();
						}
						else
						{
							for (int cellCol = 0; cellCol < cellSize; cellCol++) 
							{
								Console.Write("  ");
							}
						}
					}
					Console.WriteLine();
				}
			}


		}
	}
}
