using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingBinaryOperators
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class OverLoad
    {
        public int value;
        public static OverLoad operator +(OverLoad a, OverLoad b)
        {
            OverLoad loadPG = new OverLoad();
            loadPG.value = a.value + b.value;
            return loadPG;
        }

        public static OverLoad operator ++(OverLoad c)
        {
            overloadpgm d = new overloadpgm();
            d++;
            Console.WriteLine(d.value);
            d++;
            Console.WriteLine(d.value);
            overloadpgm g = new overloadpgm();
            g++;
            Console.WriteLine(g.value);
            overloadpgm t = d + g;
            Console.WriteLine(t.value);
            Console.ReadLine();
        }
    }
}
