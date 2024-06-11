using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4. Interface Segregation Principle (ISP)
//Principle: Clients should not be forced to depend on interfaces they do not use.

namespace Solid
{
    // Interfaces
    public interface IPrinter
    {
        void Print(string content);
    }

    public interface IScanner
    {
        void Scan(string content);
    }

    // Class implementing only the IPrinter interface
    public class SimplePrinter : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine("Printing: " + content);
        }
    }

    // Class implementing both IPrinter and IScanner interfaces
    public class MultifunctionPrinter : IPrinter, IScanner
    {
        public void Print(string content)
        {
            Console.WriteLine("Multifunction Printer Printing: " + content);
        }

        public void Scan(string content)
        {
            Console.WriteLine("Multifunction Printer Scanning: " + content);
        }
    }

    // Class implementing only the IScanner interface
    public class SimpleScanner : IScanner
    {
        public void Scan(string content)
        {
            Console.WriteLine("Scanning: " + content);
        }
    }

}
