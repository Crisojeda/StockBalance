
namespace StockBalance
{
    public class Purchase : IPurchase
    {
        public void IncreaseBalance(int amount)
        {
            Balance.CurrentBalance += amount;
        }
    }
}