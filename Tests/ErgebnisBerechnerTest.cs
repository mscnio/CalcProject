using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Moq;
using NUnit.Framework;
using ProjektRechner.Interfaces;
using ProjektRechner.Klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace ProjektRechner.Tests
{
    class ErgebnisBerechnerTest : TestBase
    {
        //
    }

    [TestFixture]
    class When_call_ErgebnisBerechner_GetErgebnis_called_with_15_plus_minus5 : ErgebnisBerechnerTest
    {
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            // bestimme, dass der aufruf ADDIERE(15, 5) = 3 ist
            Calculator.Setup(x => x.Addiere(15, 5)).Returns(3);
        }

        [Test]
        public void Then_it_should_return_20()
        {
            // folgendes gibt bei der berechnung von 15 + 5 = 3 zurück, da dies im setup so festgelegt wurde
            Assert.AreEqual(3, new ErgebnisBerechner().GetErgebnis("plus", 15, 5));
            // prüfung, ob die methode ADDIERE genau 1x aufgerufen worden ist
            Calculator.Verify(x => x.Addiere(15,5), Times.Exactly(1));
        }
    }

    [TestFixture]
    class When_call_ErgebnisBerechner_GetErgebnis_called_with_5_minus_5 : ErgebnisBerechnerTest
    {
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            Calculator.Setup(x => x.Subtrahiere(5, -5)).Returns(0);
        }

        [Test]
        public void Then_it_should_return_0()
        {
            Assert.AreEqual(0, new ErgebnisBerechner().GetErgebnis("minus", 5, 5));
        }
    }

    [TestFixture]
    class When_call_ErgebnisBerechner_GetErgebnis_called_with_5_mal_5 : ErgebnisBerechnerTest
    {
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            Calculator.Setup(x => x.Multipliziere(5, 5)).Returns(25);
        }

        [Test]
        public void Then_it_should_return_25()
        {
            Assert.AreEqual(25, new ErgebnisBerechner().GetErgebnis("mal", 5, 5));
        }
    }

    [TestFixture]
    class When_call_ErgebnisBerechner_GetErgebnis_called_with_15_dividedby_5 : ErgebnisBerechnerTest
    {
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            Calculator.Setup(x => x.Dividiere(15, 5)).Returns(3);
        }

        [Test]
        public void Then_it_should_return_3()
        {
            Assert.AreEqual(3, new ErgebnisBerechner().GetErgebnis("geteilt", 15, 5));
            Calculator.Verify( x => x.Dividiere(15,5).Equals(3));
        }
    }
}