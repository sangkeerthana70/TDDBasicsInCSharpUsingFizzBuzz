using NUnit.Framework;
using FizzBuzz.Library;
using System;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
       
        //[Test]
        //    public void SampleTest()
        //    {
        //        Assert.Pass();
        //    }
        //}

        [Test]
        public void Buzzer_WhenDefault_ReturnsInput([Values(1, 2, 4)] int input)
        {
 
            string output = FizzBuzzer.GetValue(input);
            Console.WriteLine(output);

            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Buzzer_When3_ReturnsFizz()
        {
            int input = 3;

            string output = FizzBuzzer.GetValue(input);
            Console.WriteLine(output);

            Assert.AreEqual("Fizz", output);
        }
    }
}
