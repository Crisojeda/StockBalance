using System;

namespace StockBalance
{
    public class Display
    {
        private readonly IConsoleWriter _consoleWriter;

        public Display(IConsoleWriter consoleWriter)
        {
            _consoleWriter = consoleWriter;

        }

        public void InstructionsToConsole()
        {
            _consoleWriter.WriteLine("To purchase amount, type I + amount. e.g I3.");
            _consoleWriter.WriteLine("To sell amount type S + amount. e.g. S5");
            _consoleWriter.WriteLine("To show current balance type L + enter");
            _consoleWriter.WriteLine("Type Q to exit");
            _consoleWriter.WriteLine(" ");
        }
    }
}
