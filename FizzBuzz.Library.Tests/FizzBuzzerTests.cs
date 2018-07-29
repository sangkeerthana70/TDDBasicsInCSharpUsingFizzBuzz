using NUnit.Framework;
using FizzBuzz.Library;
using System;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
       
        [Test]
        //    public void SampleTest()
        //    {
        //        Assert.Pass();
        //    }
        //}

        public void Buzzer_When1_Returns1()
        {
            //Arrange
            int input = 1;

            //Act
            string output = FizzBuzzer.GetValue(input);
            Console.WriteLine(output);

            //Assert
            Assert.AreEqual("1", output);
        }

        [Test]
        public void Buzzer_When2_Returns2()
        {
            int input = 2;

            string output = FizzBuzzer.GetValue(input);
            Console.WriteLine(output);

            Assert.AreEqual("2", output);
        }
    }
}
