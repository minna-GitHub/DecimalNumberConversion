using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello! Welcome to Coding Practice.");
			Console.WriteLine("This program will convert number binary format. Please enter the number.");
			BaseClassNumberConversion numConv = new DecimalToBinaryConversion();
			int input = Convert.ToInt32( Console.ReadLine());
			Console.WriteLine("Binary conversion of {0} is {1};", input, numConv.DecimalConversion(input));

			numConv = new DecimalToHexaConversion();
			Console.WriteLine("Binary conversion of {0} is {1};", input, numConv.DecimalConversion(input));

			Console.ReadLine();
			Console.ReadKey();
		}
	}
}
