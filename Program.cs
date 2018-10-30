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
            string str = "Geeks for Geeks";

            EnterString(str);
        }

        public static string EnterString(string value)
        {

            bool containsInt = value.Any(char.IsDigit); // checks if the string passed contains the digits or not

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


            //string[] lista = { value };
            //int listacount = lista.Count();
            //for (int i = 0; i < Math.Min(10, lista.Length); i++)

            //    Console.WriteLine(lista[i]);

            //string inputString = "Another One Bites The Dust And Another One Down";
            //string[] split = inputString.Split();
            //foreach (string s in split)
            //{
            //    Console.Write(s.Substring(0, 1)); //prints first and last letter of each substring


            //    "blabla".Distinct().Count()
            //}


            return value;
        }
    }


    }


