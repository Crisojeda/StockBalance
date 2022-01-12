using NUnit.Framework;

namespace StockBalance.UnitTests
{
    [TestFixture]
    internal class PurchaseTests
    {
        [Test]
        public void PurchaseItem_PurchaseItemThroughConsoleInterface_BalanceIsIncreased()
        {
            //Arrange
            Balance.CurrentBalance = 0;
            var purchase = new Purchase();

            //Act
            purchase.IncreaseBalance(4);

            //Assert
            Assert.That(Balance.CurrentBalance, Is.EqualTo(4));
        }
    }
}