using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringGames
{
    class StringWorker
    {
        public string GetCommonSubsequentCharacters(string a, string b)
        {
            string SubsOfA = a.Substring(0, (a.Length - 1 < 0) ? 0 : a.Length - 1);
            string SubsOfB = b.Substring(0, (b.Length - 1 < 0) ? 0 : b.Length - 1);

            if (a.Length == 0 || b.Length == 0)
                return "";
            else if (a[a.Length - 1] == b[b.Length - 1])
                return GetCommonSubsequentCharacters(SubsOfA, SubsOfB) + a[a.Length - 1];
            else
            {
                string x = GetCommonSubsequentCharacters(a, SubsOfB);
                string y = GetCommonSubsequentCharacters(SubsOfA, b);
                return (x.Length > y.Length) ? x : y;
            }
        }
    }
}
