using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
	[TestClass]
	public class DecimalToHexaConversion_test
	{
		BaseClassNumberConversion _numConv = new DecimalToHexaConversion();
		[TestMethod]
		public void TestMethod1()
		{
			Assert.AreEqual("E", _numConv.DecimalConversion(15));
			Assert.AreEqual("5E", _numConv.DecimalConversion(95));
			Assert.AreEqual("65", _numConv.DecimalConversion(101));
		}
	}
}
