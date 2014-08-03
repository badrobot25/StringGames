using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringGames
{
    class Fibbo
    {
        public string GetNthNumber(string input)
        {
            int number = Int32.Parse(input);
            if (number == 0 || number == 1)
                return input;
            int F1 = 0;
            int F2 = 1;

            for (int i = 1; i < number; i++)
            {
                var fibbotemp = F1;
                F1 = F2;
                F2 += fibbotemp;
            }
            return F2.ToString();
        }
    }
}
