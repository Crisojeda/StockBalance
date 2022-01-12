using NUnit.Framework;

namespace StockBalance.UnitTest
{
    [TestFixture]
    internal class SellTests
    {
        [Test]
        public void DecreaseBalance_ItemIsSold_BalanceIsDecreased()
        {
            //Arrange
            Balance.CurrentBalance = 0;
            var purchase = new Purchase();
            purchase.IncreaseBalance(20);

            var sell = new Sell();

            //Act
            sell.DecreaseBalance(8);

            //Assert
            Assert.That(Balance.CurrentBalance, Is.EqualTo(12));
        }
    }
}
