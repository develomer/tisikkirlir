using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace tisikkirlirr
{
    public class tisikkirlir
    {
        public string funcTsk(string param)
        {
            string msg;
            string _LowerCase = "[aeıouü]";
            string _UpperCase = "[AEIOUÜ]";

            msg = Regex.Replace(param, _LowerCase, "i");
            msg = Regex.Replace(msg, _UpperCase, "İ");

            return msg;
        }
    }
}
