using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppUsingLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Two Sum
            int[] numbers = new int[5] { 3, 4, 3, 4, 5 };
            Console.Write("Enter target = ");
            int result = int.Parse(Console.ReadLine());

            int[] index = TwoSum(numbers, result);
            for (int i = 0; i < index.Length; i++)
            {
                Console.Write(index[i] + " ");
            }

            Console.WriteLine();

            //Palindrome
            if (IsPalindrome(result))
                Console.WriteLine("It is palindrome!");
            else Console.WriteLine("It is not palindrome!");

            Console.WriteLine();

            //RomanNumbers
            Console.Write("Enter Roman number: ");
            string line = Console.ReadLine();
            int a = RomanToInt(line);

            Console.WriteLine("Result = " + a);

            Console.ReadLine();
        }

        //Two Sum
        static int[] TwoSum(int[] nums, int target)
        {
            int[] index1 = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        if (i != j)
                        {
                            index1[0] = i;
                            index1[1] = j;
                        }
                    }
                }
            }
            return index1;
        }

        //Palindrome Number
        static bool IsPalindrome(int x)
        {
            string line1 = Convert.ToString(x);
            string line2 = "";

            for (int i = line1.Length - 1; i >= 0; i--)
            {
                line2 += line1[i].ToString();
            }

            if (String.Equals(line1, line2))
                return true;

            return false;
        }

        //Roman to Integer
        static int RomanToInt(string s)
        {
            Dictionary<char, int> romanNums = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int number = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && romanNums[s[i]] < romanNums[s[i + 1]])
                {
                    number -= romanNums[s[i]];
                }
                else
                {
                    number += romanNums[s[i]];
                }
            }
            return number;
        }
    }
}
