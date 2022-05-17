using Microsoft.VisualStudio.TestTools.UnitTesting;
using RossMcGlinchey_S00211744;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Rent_PercentIncrease()
        {
            //Arrange
            RentalProperty rp1 = new RentalProperty() { ID = 1, Price = 100000m };
            decimal expectedPrice = 110000m;

            //Act
            rp1.IncreaseRent(10);

            //Assert
            Assert.AreEqual(expectedPrice, rp1.Price);
        }
    }
}
