using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace HomeworkFactorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n;
			int t = 1;
			Console.Write("Введите число:");
			n = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				t *= i;
			}
			Console.WriteLine(t);

			//BigInteger k;
			//for (int i = 1; i <= n; i++)
			//{
			//	k *= i;
			//}
			do
			{
				double a, b;
				char symbol;
				double result = 0;
				Console.Write("Введите число a:");
				 a =Convert.ToDouble(Console.ReadLine());

				Console.Write("Введите число b:");
				b = Convert.ToDouble(Console.ReadLine());

				Console.Write("Введите символ +, =, *, / ");
				symbol= Console.ReadKey().KeyChar;

				switch(symbol)
				{
					case '+':
						result= a + b;
						break;
					case '-':
						result = a - b;
						break;
					case '*':
						result= a * b;
						break;
					case '/':
						if(b!=0)
						{
							result =a/ b;
						}
						else
						{
							Console.WriteLine("Делить на 0 нельзя!");
						}
						break;
					


				}
				Console.WriteLine("\n");
				Console.WriteLine($"{ a}{ symbol}{ b}={ result}");
			} while (true);
			

		}
	}
}
