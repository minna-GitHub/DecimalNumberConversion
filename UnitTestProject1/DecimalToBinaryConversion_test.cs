using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
	[TestClass]
	public class DecimalToBinaryConversion_test
	{
		BaseClassNumberConversion _numConv = new DecimalToBinaryConversion();
		
		[TestMethod]
		public void TestMethod1()
		{
			Assert.AreEqual("100", _numConv.DecimalConversion(4));
			Assert.AreEqual("1001", _numConv.DecimalConversion(9));
		}
	}
}
