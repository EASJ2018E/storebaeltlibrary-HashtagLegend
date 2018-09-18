using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace storebaeltLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {

        Bil b = new Bil("2222111", DateTime.Now);
        MC m = new MC("3355222", DateTime.Now);

        [TestMethod]
        public void TestWeekendRabat()
        {
            Bil b = new Bil("AZ51225", new DateTime(2018,9,23));

            b.Pris(true);

            Assert.AreEqual(182.4m, b.Pris(true));

        }

        [TestMethod]
        public void TestBilPris()
        {
            Assert.AreEqual(240, b.Pris(false));
        }

        [TestMethod]
        public void TestKøretøj()
        {
            Assert.AreEqual("Bil", b.Køretøjstype());
        }

        [TestMethod]
        public void TestMCPris()
        {
            Assert.AreEqual(125, m.Pris(false));
        }

        [TestMethod]
        public void TestKøretøjstypeMc()
        {
            Assert.AreEqual("MC", m.Køretøjstype());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestKøretøjNummerpladelængde()
        {
            var b = new Bil("AZ512252", DateTime.Now);

            b.Nummerpladelængde();

            Assert.Fail();
        }

        [TestMethod]
        public void TestBilPrisMedBrobizz()
        {
            Assert.AreEqual(228, b.Pris(true));
        }

        [TestMethod]
        public void TestMCPrisMedBrobizz()
        {
            Assert.AreEqual(118.75m, m.Pris(true));
        }
    }
}
