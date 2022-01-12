using System;

namespace StockBalance
{
    public class Program
    {
        static void Main(string[] args)
        {
            var display = new Display(new ConsoleWriter());
            var consoleWriter = new ConsoleWriter();
            var balance = new Balance(consoleWriter, new Sell(consoleWriter), new Purchase());

            display.InstructionsToConsole();
            balance.HandleUserInput();
        }
    }
}
