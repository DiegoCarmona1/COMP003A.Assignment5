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
            PrintSeparator("Triangle");
            Console.WriteLine("Please input single character into system.");
            string buildBlock = Console.ReadLine();
            char conBuildBlock = Convert.ToChar(buildBlock);
            Console.WriteLine("Plese input positive whole number");
            string wholeNumber = Console.ReadLine();
            int limit = Convert.ToInt32(wholeNumber);
            IsoscelesTriangleBuilder(conBuildBlock, limit);
            PrintSeparator("Favorite Characters");
            CharacterInfo("Gumball", 2004);
            CharacterInfo("Darwin", 2006);
            CharacterInfo("Wade", 1973);
            CharacterInfo("Mark", 1989);
            CharacterInfo("Evan", 1992);
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
            string conVert = Convert.ToString(inputCharacter);

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(conVert);
                conVert += inputCharacter;
            }
            for (int i = size - 1; i > 0; i--)
            {
                Console.WriteLine(conVert.Substring(0, i));
                
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
