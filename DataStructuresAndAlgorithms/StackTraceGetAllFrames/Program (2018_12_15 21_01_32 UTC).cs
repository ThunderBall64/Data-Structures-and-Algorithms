using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StackTraceGetAllFrames
{
    class Program
    {
        public static void Main()
        {
            StackTrace stackTrace = new StackTrace();
            StackFrame[] stackFrames = stackTrace.GetFrames();

            /* write call stack method names */
            Console.WriteLine("Method Names : ");
            foreach (StackFrame stackFrame in stackFrames)
            {
                Console.WriteLine(stackFrame.GetMethod().Name);
            }

            Console.Read();
        }
    }
}
