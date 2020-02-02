using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    public class PrintData
    {
        void print(int i)
        {
            Console.WriteLine("Print int: {0}", i);
        }

        internal void print(int v)
        {
            throw new NotImplementedException();
        }

        void print(double f)
        {
            Console.WriteLine("Print float: {0}", f);
        }
        void print(string s)
        {
            Console.WriteLine("Pring string: {0}", s);
        }
    }
}
