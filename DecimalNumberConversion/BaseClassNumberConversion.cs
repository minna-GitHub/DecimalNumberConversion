using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public abstract class BaseClassNumberConversion
	{
		public abstract  int NumberFormat { get;  }

		public virtual string DecimalConversion(int decimalNum)
		{

			if (decimalNum < 0) throw new ArgumentException("It supports positive number only. We will come up for negative no ASAP");
			int givenDecimalNo = decimalNum;
			int quotient, remainder;
			string result = string.Empty;
			if(decimalNum==0) result= decimalNum.ToString();

			while (givenDecimalNo != 0) {
				quotient = givenDecimalNo / this.NumberFormat;
				remainder = givenDecimalNo % this.NumberFormat;
				givenDecimalNo = quotient;
				result += AfterConversion(remainder);

			}
			

			return string.Join("",result.ToCharArray().Reverse());
		}
		protected virtual string AfterConversion(int remainder)
		{

			return remainder.ToString();
		}

	}
}
