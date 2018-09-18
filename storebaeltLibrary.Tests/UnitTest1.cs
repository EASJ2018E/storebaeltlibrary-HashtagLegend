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
        public void TestK�ret�j()
        {
            Assert.AreEqual("Bil", b.K�ret�jstype());
        }

        [TestMethod]
        public void TestMCPris()
        {
            Assert.AreEqual(125, m.Pris(false));
        }

        [TestMethod]
        public void TestK�ret�jstypeMc()
        {
            Assert.AreEqual("MC", m.K�ret�jstype());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestK�ret�jNummerpladel�ngde()
        {
            var b = new Bil("AZ512252", DateTime.Now);

            b.Nummerpladel�ngde();

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
