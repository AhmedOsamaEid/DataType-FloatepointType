using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType_FloatepointType
{
    class Program
    {
        static void Main(string[] args)
        {
            float flmin = float.MinValue;
            float flmax = float.MaxValue;

            Console.WriteLine("min value{0}   max value{1}", flmin, flmax);

            float flvar = 1f / 3;
            double dlvar = 1d / 3;
            decimal dmvar = 1m / 3;

            Console.WriteLine("\nfloat value={0}\ndouble value={1}\ndecimal value={2}", flvar, dlvar, dmvar);
            Console.ReadKey();
        }
    }
}
