#define ARRAYS_1
#define ARRAYS_2
#define JAGGED_ARRAY
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq; //предоставляет методы для выполнения операций над массивом.
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static readonly string delimiter = "\n--------------------------------------\n";
		static void Main(string[] args)
		{
			Random rand = new Random(0);
#if ARRAYS_1
			Console.Write("Введите размер мавссива:");
			int n= Convert.ToInt32(Console.ReadLine());
			//int[] arr =  { 3, 5, 8, 13, 21 };
			int[] arr = new int[n];
			//Random rand= new Random(0);
			for(int i=0; i<arr.Length; i++)
			{
				arr[i] = rand.Next(100);
			}
			//for(int i=0; i<arr.Length; i++)
			//{
			//	Console.Write(arr[i] + "\t");
			//}
			//Console.WriteLine();

			foreach (int i in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();
			Console.WriteLine(delimiter);
			int sum_array1 = arr.Sum();
			Console.WriteLine($"сумма элементов одномерного массива: {sum_array1}");
			double avg_array1 = arr.Average();
			Console.WriteLine($"Седнее аифметичепское одномеронго массива: {avg_array1}");
			int min_array1 = arr.Min();
			Console.WriteLine($"Минимальное значение одномерного массива:{min_array1}");
			int max_array1 = arr.Max();
			Console.WriteLine($"Максимальное значение одномерного мкассива: {max_array1}");
			Console.WriteLine(delimiter);
			foreach (int i in arr)
			{
				Array.Sort(arr);
				Console.Write(i+"\t");
			}
			Console.WriteLine();
			Console.WriteLine(delimiter);
#endif

#if ARRAYS_2
			Console.Write("Введите количество строк: ");
			int rows = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите количество элементов строки: ");
			int cols = Convert.ToInt32(Console.ReadLine());

			int[,] i_arr_2 = new int[rows, cols];

			//Console.WriteLine(i_arr_2.Rank);

			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					i_arr_2[i, j] = rand.Next(100);
				}
			}
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);
			int sum_array2 = i_arr_2.Cast<int>().Sum();
			Console.WriteLine($"Сумма эхлементов двумерного массива: {sum_array2}");
			double avg_array2= i_arr_2.Cast<int>().Average();
			Console.WriteLine($"Среднеарифметическое элементов двумерного массива: {avg_array2}");
			int min_array2 = i_arr_2.Cast<int>().Min();
			Console.WriteLine($"Минимальное значение элементов двумерного массива: {min_array2}");
			int max_array2 = i_arr_2.Cast<int>().Max();
			Console.WriteLine($"Максимальное значение элементов двумерного массива: {max_array2}");
			Console.WriteLine(delimiter);
#endif

#if JAGGED_ARRAY
			int[][] arr_jagged = new int[][]
			{
				new int []{0, 1, 1, 2 },
				new int []{3, 5, 8, 13, 21 },
				new int []{ 34, 55, 89 },
				new int []{144, 233, 377, 610, 987 }
			};
			for (int i = 0; i < arr_jagged.Length; i++)
			{
				for (int j = 0; j < arr_jagged[i].Length; j++)
				{
					Console.Write(arr_jagged[i][j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);
			int sum_arrayJagged = arr_jagged.SelectMany(x => x).Sum();
			Console.WriteLine($"Сумма элементов зубчатого массива: {sum_arrayJagged}");
			double avg_arrayJagged = arr_jagged.SelectMany(x=>x).Average();
			Console.WriteLine($"Среднее арифметическое элементов зубчатого массива: {avg_arrayJagged}");
			int min_arrayJagged = arr_jagged.SelectMany(x => x).Min();
			Console.WriteLine($"Минимальное значение элементо зубчатого массива: {min_arrayJagged}");
			int max_arrayJagged = arr_jagged.SelectMany(x=>x ).Max();
			Console.WriteLine($"Максимальное значение элементов зубчатого массива: {max_arrayJagged}");
#endif
		}
	}
}
