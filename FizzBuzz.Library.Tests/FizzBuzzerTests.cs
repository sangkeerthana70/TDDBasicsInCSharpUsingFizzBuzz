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
        public void Buzzer_WhenDiv3_ReturnsFizz([Values(3,6)] int input)
        {
            Console.WriteLine(input);
            string output = FizzBuzzer.GetValue(input);
            Console.WriteLine(output);

            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Buzzer_When5_ReturnsBuzz()
        {
            int input = 5;
            string output = FizzBuzzer.GetValue(input);
            Console.WriteLine(output);

            Assert.AreEqual("Buzz", output);
        }
    }
}
