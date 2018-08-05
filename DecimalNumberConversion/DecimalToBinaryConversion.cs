using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class DecimalToBinaryConversion:BaseClassNumberConversion
	{
		public override int NumberFormat { get { return 2; } }

		public override string DecimalConversion(int decimalNum)
		{
			return base.DecimalConversion(decimalNum);
		}
	}
}
