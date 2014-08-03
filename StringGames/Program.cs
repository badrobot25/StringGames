using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringGames
{
    class Program
    {
        static void Main(string[] args)
        {
            var pali = new Palindrome();
            var isPali = pali.Check("ana");

            var fibbo = new Fibbo();
            var fibboNumber = fibbo.GetNthNumber("5");

            Console.WriteLine(isPali ? "Palindrome = true" : "Palindrome = false");
            Console.WriteLine("Fibbo no.: " + fibboNumber);
            Console.ReadKey();
        }
    }
}
