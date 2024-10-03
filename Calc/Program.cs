﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("ВВедите арифметическое выражение:");
			string expression = Console.ReadLine();
			expression = expression.Replace('.', ',');
			Console.WriteLine(expression);
			//Console.WriteLine(expression);
			char[] delimiters = new char[] { '+', '-', '*', '/' };
			string[]numbers=expression.Split('+','-','*','/');
			try
			{
				double a = Convert.ToDouble(numbers[0]);
				double b = Convert.ToDouble(numbers[1]);
				#region IFcalc
				//if (expression.Contains('+')) Console.WriteLine($"{a}+{b}={a + b}");
				//else if (expression.Contains("-")) Console.WriteLine($"{a}-{b}={a - b}");
				//else if (expression.Contains("*")) Console.WriteLine($"{a}*{b}={a * b}");
				//else if (expression.Contains("/")) Console.WriteLine($"{a}/{b}={a /b}"); 
				#endregion

				switch (expression[expression.IndexOfAny(delimiters)])
				{
					case '+': Console.WriteLine($"{a} +{b}={a + b}"); break;
					case '-': Console.WriteLine($"{a} -{b}={a - b}"); break;
					case '*': Console.WriteLine($"{a} *{b}={a * b}"); break;
					case '/': Console.WriteLine($"{a} /{b}={a / b}"); break;
					default: Console.WriteLine("Error:No operation"); break;
				}
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
			Main(args);
		}
	}
}
