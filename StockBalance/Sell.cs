using System;

namespace StockBalance
{
    public class Sell : ISell
    {
        private readonly IConsoleWriter _consoleWriter;

        public Sell(IConsoleWriter consoleWriter)
        {
            _consoleWriter = consoleWriter;
        }

        public int DecreaseBalance(int amount)
        {
            if (IsBalanceLessThanAmount(amount))
            {
                _consoleWriter.WriteLine("Balance will be less than zero if you sell that much");
                return 0;
            }

            return Balance.CurrentBalance -= amount;
        }

        private bool IsBalanceLessThanAmount(int amount)
        {
            return Balance.CurrentBalance < amount;
        }
    }
}