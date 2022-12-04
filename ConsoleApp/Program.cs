using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Longest Common Prefix
            string[] words = new string[3] { "flower", "flight", "flag" };
            string str = LongestCommonPrefix(words);
            Console.WriteLine(str);

            //Valid Parentheses
            string str1 = "({{}})";
            if (IsValid(str1))
                Console.WriteLine("RIGHT!");
            else Console.WriteLine("ERROR!");

            //Remove Element
            int[] nums = new int[] { 3,2,2,3 };
            int number = RemoveElement(nums, 3);
            Console.WriteLine(number);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
            }
            Console.ReadLine();
        }

        //Longest Common Prefix
        static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length > 1)
            {
                int prefixLength = 0;

                foreach (char c in strs[0])
                {
                    foreach (string s in strs)
                    {
                        if (s.Length <= prefixLength || s[prefixLength] != c)
                        {
                            return strs[0].Substring(0, prefixLength);
                        }
                    }
                    prefixLength++;
                }
            }
            return strs[0];           
        }

        //Valid Parentheses
        static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in s)
            {
                if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count > 0)
                    {
                        char chSt = stack.Pop();

                        if ((ch == ')' && chSt == '(') || (ch == '}' && chSt == '{') || (ch == ']' && chSt == '['))
                            continue;

                        else return false;
                    }
                    else return false;
                }
                else stack.Push(ch);
            }
            return stack.Count > 0 ? false : true;
        }

        //Remove Duplicates from Sorted Array
        static int RemoveDuplicates(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            nums[count++] = nums[nums.Length - 1];
            return count;
        }

        //Remove Element
        static int RemoveElement(int[] nums, int val)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[count] = nums[i];
                    count++;
                }
            }           
            return count;
        }
    }
}
