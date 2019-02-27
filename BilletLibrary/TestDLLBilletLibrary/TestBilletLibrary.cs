using System;
using System.Net.Sockets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;
namespace TestDLLBilletLibrary
{
    [TestClass]
    public class TestBilletLibrary
    {
        [TestMethod]
        public void TesTPrisMetode()
        {
            //Arrange 
            Bil bil = new Bil();
            //Act
            decimal pris = bil.Pris();
            //Assert
            Assert.AreEqual(240, pris );

     

        }

        [TestMethod]
        public void TestKøretøjer()
        {

            //Arrange
            Bil bil = new Bil();
            //Act
            string køretøj = bil.KøretøjStatus();
            //Assert
            Assert.AreEqual("Bil", køretøj);
        }

        [TestMethod]
        public void TesTPrisMetodeMC()
        {
            //Arrange 
            MC mc = new MC();
            //Act
            decimal pris = mc.Pris();
            //Assert
            Assert.AreEqual(125, pris );



        }

        [TestMethod]
        public void TestKøretøjMC()
        {

            //Arrange
            MC mc = new MC();
            //Act
            string køretøj = mc.KøretøjStatus();
            //Assert
            Assert.AreEqual("MC", køretøj);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNummerpladeForLang()
        {
            //Arrange
            Køretøj køretøj = new Bil(); 
            //Act
            køretøj.Nummerplade = "123456789";
            //Assert
            Assert.Fail();
        }
    }
}
