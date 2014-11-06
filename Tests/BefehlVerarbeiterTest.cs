using NUnit.Framework;
using ProjektRechner.Klassen;

namespace ProjektRechner.Tests
{
    class BefehlVerarbeiterTest : TestBase
    {
    }

    [TestFixture]
    class WhenCallBefehlVerarbeiterGetAntwortAufBefehl : BefehlVerarbeiterTest
    {
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            ErgebnisBerechner.Setup(x => x.GetErgebnis("plus", 15, 5)).Returns(20);
        }
        [Test]
        public void Then_it_should_return_20()
        {
            Assert.AreEqual("20", new BefehlVerarbeiter().GetAntwortAufBefehl("15 plus 5"));
        }
    }
}
