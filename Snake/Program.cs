
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	
	internal class Program
	{
		static void Main(string[] args)
		{
			////int x = 20, y = 10;
			////int posX = 80;
			////int posY = 26;
			//Console.BufferHeight = Console.WindowHeight;
			//Console.BufferWidth = Console.WindowWidth;
			//Console.CursorVisible = false;
			//Random rnd = new Random();
			////int x = rnd.Next(posX);
			////int y = rnd.Next(posY);
			//int x = rnd.Next(Console.BufferWidth);
			//int y = rnd.Next(Console.BufferHeight);
			//Console.SetCursorPosition(x, y);

			//char symbol = '*';


			//Console.WriteLine(symbol);
			////Console.Write(symbol);
			//ConsoleKey key;
			//do
			//{
			//	key = Console.ReadKey(true).Key;
			//	switch (key)
			//	{
			//		case ConsoleKey.S:

			//		case ConsoleKey.DownArrow:
			//			if (y < Console.BufferHeight - 1)
			//				y++; break;
			//		case ConsoleKey.W:
			//			if (y > 0)
			//				y--; break;
			//		case ConsoleKey.UpArrow:
			//			if (y > 0)
			//				y--; break;
			//		case ConsoleKey.A:
			//			if (x > 1)
			//				x--; break;
			//		case ConsoleKey.LeftArrow:
			//			if (x > 1)
			//				x--; break;
			//		case ConsoleKey.D:
			//			if (x < Console.BufferWidth - 1)
			//				x++; break;
			//		case ConsoleKey.RightArrow:
			//			if (x < Console.BufferWidth - 1)
			//				x++; break;
			//	}
			//	//if (x < 0) x = 0;
			//	//if (y < 1) y = 1;
			//	////if (x > posX - 1) x = posX - 1;
			//	////if (y > posY - 1) y = posY - 1;
			//	//if (x > Console.BufferWidth-1) x = Console.BufferWidth-1;
			//	//if (y > Console.BufferHeight-1) y = Console.BufferHeight-1;

			//	Console.Clear();
			//	Console.ResetColor();
			//	Console.WriteLine($"{(int)key}\t{key}");
			//	Console.SetCursorPosition(x, y);
			//	Console.Write(symbol);


			//} while (key != ConsoleKey.Escape);         ////int x = 20, y = 10;
			//											//int posX = 80;
			//											//int posY = 26;
			//Console.BufferHeight = Console.WindowHeight;
			//Console.BufferWidth = Console.WindowWidth;
			//Console.CursorVisible = false;
			//Random rnd = new Random();
			////int x = rnd.Next(posX);
			////int y = rnd.Next(posY);
			//int x = rnd.Next(Console.BufferWidth);
			//int y = rnd.Next(Console.BufferHeight);
			//Console.SetCursorPosition(x, y);

			//char symbol = '*';


			//Console.WriteLine(symbol);
			////Console.Write(symbol);
			//ConsoleKey key;
			//do
			//{
			//	key = Console.ReadKey(true).Key;
			//	switch (key)
			//	{
			//		case ConsoleKey.S:

			//		case ConsoleKey.DownArrow:
			//			if (y < Console.BufferHeight - 1)
			//				y++; break;
			//		case ConsoleKey.W:
			//			if (y > 0)
			//				y--; break;
			//		case ConsoleKey.UpArrow:
			//			if (y > 0)
			//				y--; break;
			//		case ConsoleKey.A:
			//			if (x > 1)
			//				x--; break;
			//		case ConsoleKey.LeftArrow:
			//			if (x > 1)
			//				x--; break;
			//		case ConsoleKey.D:
			//			if (x < Console.BufferWidth - 1)
			//				x++; break;
			//		case ConsoleKey.RightArrow:
			//			if (x < Console.BufferWidth - 1)
			//				x++; break;
			//	}
			//	//if (x < 0) x = 0;
			//	//if (y < 1) y = 1;
			//	////if (x > posX - 1) x = posX - 1;
			//	////if (y > posY - 1) y = posY - 1;
			//	//if (x > Console.BufferWidth-1) x = Console.BufferWidth-1;
			//	//if (y > Console.BufferHeight-1) y = Console.BufferHeight-1;

			//	Console.Clear();
			//	Console.ResetColor();
			//	Console.WriteLine($"{(int)key}\t{key}");
			//	Console.SetCursorPosition(x, y);
			//	Console.Write(symbol);


			//} while (key != ConsoleKey.Escape);
			//int x = 10;
			//int y = 10;

			ConsoleKey key;
			Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
			Random rand = new Random();
			int x = rand.Next(Console.WindowWidth);
			int y = rand.Next(Console.WindowHeight);
			Console.CursorVisible = false;
			//Console.BufferWidth= Console.WindowWidth;
			//Console.BufferHeight= Console.WindowHeight;
			do
			{
				
				Console.Clear();
				Console.SetCursorPosition(0,0);
				Console.ResetColor();
				Console.Write($"x={x}\tY={y}");
				Console.SetCursorPosition(x, y);
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine((char)2);
				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.UpArrow:
					case ConsoleKey.W: y--; break;
					case ConsoleKey.DownArrow:
					case ConsoleKey.S: y++; break;
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A: x--; break;
					case ConsoleKey.RightArrow:
					case ConsoleKey.D: x++; break;
				}
				if (x == 0 || y == 0 || 
					x == Console.WindowWidth || y == Console.WindowHeight
					) Console.Beep();
				if (x == 0) x = 1;
				if (x == Console.WindowWidth) x = Console.WindowWidth - 1;
				if (y == 0) y = 1;
				if (y == Console.WindowHeight) y = Console.WindowHeight - 1;

			}while(key != ConsoleKey.Escape);
			
		}
	}
}
