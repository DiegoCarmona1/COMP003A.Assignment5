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

        /// <summary>
        /// Two parameters, 2 return values.
        /// First for loop adds characters to line until it reaaches level of i
        /// Second for loop lowers the value of i to lower the number of characters shown from the substring coordinates.
        /// </summary>
        /// <param name="inputCharacter"> Character Input</param>
        /// <param name="size">Integer Input</param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            for (int i = 0; i <= size; i++)
            {
                inputCharacter += inputCharacter;
                Console.Write(inputCharacter);
            }
            for (int i = size - 1; i >= 1; i--)
            {
                string fallingStaircase = Convert.ToString(inputCharacter);
                string substr1 = fallingStaircase.Substring(0, i);
                Console.WriteLine(substr1);
            }
        }

        /// <summary>
        /// Calculates the birth year of inputted person based on age.
        /// Two parameters and one return
        /// </summary>
        /// <param name="year">Integer Input</param>
        /// <returns>Birth Year based on persons age</returns>
        static int AgeCalculator(int year)
        {
            return 2024 - year;
        }

        /// <summary>
        /// Method to give a character name and age.
        /// </summary>
        /// <param name="name">String Input</param>
        /// <param name="birthYear">Integer Input</param>
        static void CharacterInfo(string name, int birthYear)
        {
            int age = AgeCalculator(birthYear);
            Console.WriteLine(name);
            Console.WriteLine(age);
        }
    }
}
