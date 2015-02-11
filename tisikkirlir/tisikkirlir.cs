using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace tisikkirlirr
{
    public static class tisikkirlir
    {
        public static string tskkir(this string msg)
        {
            string _LowerCase = "[aeıouü]";
            string _UpperCase = "[AEIOUÜ]";

            return Regex.Replace(Regex.Replace(msg, _LowerCase, "i"), _UpperCase, "İ");
        }
    }
}