using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharath
{

    class Program
    {
        public static void Main()
        {
            string str = "Sharath Vuttipalli";

            EnterString(str);
        }

        public static void EnterString(string value)
        {

            bool containsInt = value.Any(char.IsDigit); 

            var list = value.Split(' ');

            foreach (var namePart in list)
            {
                var distinctCount = namePart.Substring(1, namePart.Length - 2).ToArray().Distinct().Count();
                var finalValue = $"{namePart[0]}{distinctCount}{namePart[namePart.Length - 1]}";
                Console.Write(finalValue);
                Console.Write(" ");
            }

            var nameWithDigits = "S4e4th";

            var lastOneIsLetter = false;
            foreach (var c in nameWithDigits)
            {
                if (char.IsDigit(c))
                {
                    Console.Write(c);
                    lastOneIsLetter = false;
                }
                else
                {
                    if (lastOneIsLetter)
                    {
                        Console.Write(5);
                    }
                    Console.Write(c);
                    lastOneIsLetter = true;
                }

            }           
            
        }
    }


    }


