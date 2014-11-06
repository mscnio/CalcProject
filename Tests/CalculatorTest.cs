using NUnit.Framework;
using ProjektRechner.Klassen;

namespace ProjektRechner.Tests
{
    class CalculatorTest : TestBase
    {
        //
    }

    [TestFixture]
    class WhenCallCalculatorAddiererWith5Plus6 : CalculatorTest
    {
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
        }

        [Test]
        public void Then_it_should_return_11()
        {
            Assert.AreEqual(11, new Calculator().Addiere(5,6));
        }
    }

    [TestFixture]
    class WhenCallCalculatorSubtrahiererWithMinus1Minus5 : CalculatorTest
    {
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
        }

        [Test]
        public void Then_it_should_return_minus_6()
        {
            Assert.AreEqual(-7, new Calculator().Subtrahiere(-1, 6));
        }
    }

    [TestFixture]
    class WhenCallCalculatorMultipliziererWith5MalMinus6 : CalculatorTest
    {
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
        }

        [Test]
        public void Then_it_should_return_minus_30()
        {
            Assert.AreEqual(-30, new Calculator().Multipliziere(5, -6));
        }
    }

    [TestFixture]
    class When_call_Calculator_dividierer_with_10_dividedby_5 : CalculatorTest
    {
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
        }

        [Test]
        public void Then_it_should_return_2()
        {
            Assert.AreEqual(2,new Calculator().Dividiere(10,5));
        }
    }
}
