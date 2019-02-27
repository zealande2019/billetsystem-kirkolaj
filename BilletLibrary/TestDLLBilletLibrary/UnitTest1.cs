using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;
namespace TestDLLBilletLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesTPrisMetode()
        {
            //Arrange 
            Bil bil = new Bil();
            //Act
            decimal pris = bil.pris();
            //Assert
            Assert.AreEqual(bil.pris(), 240);

     

        }

        [TestMethod]
        public void TestK�ret�jer()
        {

            //Arrange
            Bil bil = new Bil();
            //Act
            string k�ret�j = bil.k�ret�jer();
            //Assert
            Assert.AreEqual(bil.k�ret�jer(), "Bil");
        }


    }
}
