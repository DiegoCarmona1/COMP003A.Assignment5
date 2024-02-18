using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Diego Carmona
 * Course: COMP003A
 * Purpose: To practice and gain understanding and familiarity with methods, their manipulation, and XML comments.
 */

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        /// <summary>
        /// Method without parameters, only return value
        /// </summary>
        static void PrintSeparator()
        {
            Console.WriteLine("************************************************************");
        }

        /// <summary>
        /// Method Overload, one parameter is added, no return value.
        /// </summary>
        /// <param name="inputString">String Input</param>
        static void PrintSeparator(string inputString)
        {
            PrintSeparator();
            Console.WriteLine(inputString);
            PrintSeparator();
        }
    }
}
