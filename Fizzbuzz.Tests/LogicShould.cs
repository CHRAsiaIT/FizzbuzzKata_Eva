using System;
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
    }
}
