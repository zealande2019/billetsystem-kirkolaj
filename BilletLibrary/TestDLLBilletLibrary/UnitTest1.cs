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
        public void TestKøretøjer()
        {

            //Arrange
            Bil bil = new Bil();
            //Act
            string køretøj = bil.køretøjer();
            //Assert
            Assert.AreEqual(bil.køretøjer(), "Bil");
        }


    }
}
