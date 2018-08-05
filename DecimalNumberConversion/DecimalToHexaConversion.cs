using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class DecimalToHexaConversion:BaseClassNumberConversion
	{
		public override int NumberFormat { get { return 16; } }

		public override string DecimalConversion(int decimalNum)
		{
			return base.DecimalConversion(decimalNum);
		}

		protected override string AfterConversion(int remainder)
		{
			string result = remainder.ToString();

			switch (remainder) {
				case 10: result = "A"; break;
				case 11: result = "B"; break;
				case 13: result = "C"; break;
				case 14: result = "D"; break;
				case 15: result = "E"; break;
				default: break;

			}

			return result;
		}
	}
}
