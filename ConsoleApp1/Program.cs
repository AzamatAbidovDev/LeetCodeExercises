using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Maximum Value of a String in an Array
            string[] text = new string[] { "ascscd", "yv", "22", "c", "5001", "928", "4003", "2" };
            int maxVal = MaximumValue(text);
            Console.WriteLine(maxVal);

            Console.ReadLine();
        }

        //Maximum Value of a String in an Array
        static int MaximumValue(string[] strs)
        {
            int value = 0;            
            List<int> values = new List<int>();

            foreach (string str in strs)
            {
                foreach (char item in str)
                {
                    if (Char.IsLetter(item))
                    {
                        value = str.Length;
                        break;
                    }
                }
                if(value == 0)
                {
                    value = int.Parse(string.Join("", str.Where(c => char.IsDigit(c))));
                }

                values.Add(value);
                value = 0;
            }
            return values.Max();
        }
    }
}
