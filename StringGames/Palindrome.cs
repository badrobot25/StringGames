using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringGames
{
    class Palindrome
    {
        public bool Check(string input)
        {
            var length = input.Length;
            var skipMid = 1;
            if (length % 2 == 0) skipMid = 0;

            var left = input.Remove(length / 2);
            var right = input.Remove(0, length / 2 + skipMid);
            var reverseright = "";
            for (var i = right.Length - 1; i >= 0; i--)
            {
                reverseright += right[i];
            }
            if (!left.Equals(reverseright)) return false;
            return true;
        }
    }
}
