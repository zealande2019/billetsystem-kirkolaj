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
        public void TestK�ret�jer()
        {

            //Arrange
            Bil bil = new Bil();
            //Act
            string k�ret�j = bil.K�ret�jStatus();
            //Assert
            Assert.AreEqual("Bil", k�ret�j);
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
        public void TestK�ret�jMC()
        {

            //Arrange
            MC mc = new MC();
            //Act
            string k�ret�j = mc.K�ret�jStatus();
            //Assert
            Assert.AreEqual("MC", k�ret�j);
        }
    }
}
