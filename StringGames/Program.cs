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
            Console.WriteLine(isPali ? "Palindrome = true" : "Palindrome = false");

            var fibbo = new Fibbo();
            var fibboNumber = fibbo.GetNthNumber("5");
            Console.WriteLine("Fibbo no.: " + fibboNumber);

            // $string1;$string2
            string line = "XMJYAUZ;MZJAWXU";
            var left = line.Split(';').First();
            var right = line.Split(';').Last();
            var stringW = new StringWorker();
            string[] TwoStrings = new[] { left, right };
            Console.WriteLine(stringW.GetCommonSubsequentCharacters(left, right));

            Console.ReadKey();
        }
    }
}
