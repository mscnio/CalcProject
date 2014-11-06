using Moq;
using NUnit.Framework;
using ProjektRechner.Interfaces;
using StructureMap;

namespace ProjektRechner.Tests
{
    class TestBase
    {
        public Mock<ICalculator> Calculator = new Mock<ICalculator>();
        public Mock<IErgebnisBerechner> ErgebnisBerechner = new Mock<IErgebnisBerechner>();

        [SetUp]
        public virtual void SetUp()
        {
            ObjectFactory.Initialize(x => { });
            ObjectFactory.Configure(x =>
                {
                    x.For<ICalculator>().Use(Calculator.Object);
                    x.For<IErgebnisBerechner>().Use(ErgebnisBerechner.Object);
                });
        }

    }
}
