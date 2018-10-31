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
            string str = "Sharath Vuttipalli"; // Enter the string here.

            EnterString(str);
        }

        public static void EnterString(string value)
        {
           /* Each word in the input string is replaced with the following: the first letter of the word, the
              count of distinct letters between the first and last letter, and the last letter of the word. For
              example, “Automotive parts&quot; would be replaced by &quot; A6e p3s&quot;.*/
            bool containsInt = value.Any(char.IsDigit); 

            var list = value.Split(' ');

            foreach (var namePart in list) // this method resolves the input that is
            {
                var distinctCount = namePart.Substring(1, namePart.Length - 2).ToArray().Distinct().Count();
                var finalValue = $"{namePart[0]}{distinctCount}{namePart[namePart.Length - 1]}";
                Console.Write(finalValue);
                Console.Write(" ");
            }
            /*6.A "word" is defined as a sequence of alphabetic characters, delimited by any non-alphabetic characters. 
              7.Any non-alphabetic character in the input string should appear in the output string in its original relative location. 
             */

            var nameWithDigits = "S4e4th"; // insert or replace the nameWithDigits with input values such as "SHA5ATH"

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


