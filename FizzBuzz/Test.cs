using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FizzBuzz
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestFizzBuzz_ShouldReturnTwoIntegers()
		{
			var fizzbuzz = new FizzBuzzMain();
			var expected = new List<string>{ "1", "2" };

			var actual = fizzbuzz.GetFizzBuzz(2);

			CollectionAssert.AreEqual(expected, actual);
		}
		[Test]
		public void TestFizzBuzz_ShouldReturnFirstThreeItems()
		{
			var fizzbuzz = new FizzBuzzMain();
			var expected = new List<string> { "1", "2", "Fizz" };

			var actual = fizzbuzz.GetFizzBuzz(3);

			CollectionAssert.AreEqual(expected, actual);
		}
		[Test]
		public void TestFizzBuzz_ShouldReturnFirstFiveItems()
		{
			var fizzbuzz = new FizzBuzzMain ();
			var expected = new List<string>{ "1", "2", "Fizz", "4", "Buzz" };

			var actual = fizzbuzz.GetFizzBuzz (5);

			CollectionAssert.AreEqual (expected, actual);
		}
		[Test]
		public void TestFizzBuzz_Given15thPosition_ShouldReturnFizzBuzz()
		{
			var fizbuzz = new FizzBuzzMain();
			var position = 15;
			var expected = "FizzBuzz";

			var actualFizzBuzzList = fizbuzz.GetFizzBuzz(position);
			var actual = actualFizzBuzzList.ElementAt(position - 1);

			Assert.AreEqual(expected, actual);
		}
	}
}

