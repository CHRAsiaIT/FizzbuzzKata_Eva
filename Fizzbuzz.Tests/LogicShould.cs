using Fizzbuzz.Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace Fizzbuzz.Tests
{
    [TestClass]
    public class LogicShould
    {
        [TestMethod]
        public void When_Input1_ShouldReturn1()
        {
            var input = 1;
            input.ToFizzbuzz().ShouldBe("1");
        }

        [TestMethod]
        public void When_Input2_ShouldReturn2()
        {
            var input = 2;
            input.ToFizzbuzz().ShouldBe("2");
        }

        [TestMethod]
        public void When_Input3_ShouldReturnFizz()
        {
            var input = 3;
            input.ToFizzbuzz().ShouldBe(Logic.Fizz);
        }

        [TestMethod]
        public void When_Input6_ShouldReturnFizz()
        {
            var input = 6;
            input.ToFizzbuzz().ShouldBe(Logic.Fizz);
        }

        [TestMethod]
        public void When_Input5_ShouldReturnBuzz()
        {
            var input = 5;
            input.ToFizzbuzz().ShouldBe(Logic.Buzz);
        }

        [TestMethod]
        public void When_Input10_ShouldReturnBuzz()
        {
            var input = 10;
            input.ToFizzbuzz().ShouldBe(Logic.Buzz);
        }

        [TestMethod]
        public void When_Input15_ShouldReturnFizzBuzz()
        {
            var input = 15;
            input.ToFizzbuzz().ShouldBe(Logic.FizzBuzz);
        }

        [TestMethod]
        public void When_Input30_ShouldReturnFizzBuzz()
        {
            var input = 30;
            input.ToFizzbuzz().ShouldBe(Logic.FizzBuzz);
        }

        [TestMethod]
        public void When_Input9_ShouldReturnFizz()
        {
            var input = 9;
            input.ToFizzbuzz().ShouldBe(Logic.Fizz);
        }

        [TestMethod]
        public void When_Input25_ShouldReturnBuzz()
        {
            var input = 25;
            input.ToFizzbuzz().ShouldBe(Logic.Buzz);
        }

        [TestMethod]
        public void When_Input45_ShouldReturnFizzBuzz()
        {
            var input = 45;
            input.ToFizzbuzz().ShouldBe(Logic.FizzBuzz);
        }
    }
}
