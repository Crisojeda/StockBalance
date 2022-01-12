
using System;

namespace StockBalance
{
    public class Balance
    {
        private readonly IConsoleWriter _consoleWriter;
        private readonly ISell _sell;
        private readonly IPurchase _purchase;

        public static int CurrentBalance { get; set; }

        public Balance(IConsoleWriter consoleWriter, ISell sell, IPurchase purchase)
        {
            _consoleWriter = consoleWriter;
            _sell = sell;
            _purchase = purchase;
        }

        public void HandleUserInput()
        {
            while (true)
            {
                _consoleWriter.Write("Command: ");
                var input = Console.ReadLine().ToUpper();

                if (input.StartsWith("S") && IsDigitsOnly(input.Substring(1)))
                {
                    _sell.DecreaseBalance(int.Parse(input.Substring(1)));
                    continue;
                }

                else if (input.StartsWith("I") && IsDigitsOnly(input.Substring(1)))
                {
                    _purchase.IncreaseBalance(int.Parse(input.Substring(1)));
                    continue;
                }
                else if (input.StartsWith("L") && input.Length == 1)
                {
                    _consoleWriter.WriteLine($"Balance is: {Balance.CurrentBalance}");
                    continue;
                }
                else if (input.StartsWith("Q"))
                {
                    _consoleWriter.WriteLine("Exiting program...");
                    break;
                }
                else
                {
                    _consoleWriter.WriteLine("You have typed something that is not allowed, please try again");
                    continue;
                }
            }
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}