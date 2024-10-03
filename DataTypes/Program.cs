using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		static readonly string delimeter = "\n--------------------------------------------\n";
		static void Main(string[] args)
		{
			Console.WriteLine("Hello Data Types");
			 
			//Console.WriteLine(sizeof(bool));
			//Console.WriteLine(true);
			//Console.WriteLine(false);
			//Console.WriteLine(Boolean.FalseString);

			Console.WriteLine('+'.GetType());
			Console.WriteLine(sizeof(byte));
			Console.WriteLine(byte.MinValue);
			Console.WriteLine(byte.MaxValue);
			Console.WriteLine(delimeter);

			Console.WriteLine("SByte:");
			Console.WriteLine(sizeof(sbyte));
			Console.WriteLine(sbyte.MinValue);
			Console.WriteLine(sbyte.MaxValue);
			Console.WriteLine(delimeter);

			Console.WriteLine("Decimal:");
			Console.WriteLine(sizeof(decimal));
			Console.WriteLine(decimal.MinValue);
			Console.WriteLine(decimal.MaxValue);

			Console.WriteLine(5UL.GetType());
			int a = 2000000000;
			int b = 4;

	
			Console.WriteLine((a*b).GetType());
			Console.WriteLine("Вот и сказочке конец");



		}
	}
}
