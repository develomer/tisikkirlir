using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tisikkirlirr;

namespace tisikkirlir_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            tisikkirlir tsk = new tisikkirlir();

            Console.Write(tsk.funcTsk(str));
            Console.ReadKey();
        }
    }
}
