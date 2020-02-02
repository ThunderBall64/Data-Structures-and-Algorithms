/*
 * Script       : radixsort.cs
 * Name         : billint
 * Date         : 20th August 2018
 * Objective    : non-comparative integer sorting algorithm that sorts data with integer keys by grouping keys by individual
 *                  digits which share same significant position and value
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            new Node().RaxixSort();
            Console.ReadLine();
        }
    }
}
