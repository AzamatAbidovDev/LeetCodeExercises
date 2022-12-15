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

            //Plus One
            int[] nums2 = new int[] { 4,3,9,9};
            nums2 = PlusOne(nums2);
            for (int i = 0; i < nums2.Length; i++)
            {
                Console.Write(nums2[i]);
            }
            Console.WriteLine();

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

        //Plus One
        static int[] PlusOne(int[] digits)
        {
            List<int> nums = new List<int>();
            bool isNine = false;
            int last = digits.Length - 1;

            if (digits[last] == 9)
            {
                nums.Add(0);
                isNine = true;
            }
            else nums.Add(digits[last] + 1);

            for (int i = last - 1; i >= 0; i--)
            {
                if (isNine)
                {
                    if (digits[i] == 9)
                        nums.Add(0);
                    else
                    {
                        nums.Add(digits[i] + 1);
                        isNine = false;
                    }
                }
                else nums.Add(digits[i]);              
            }

            if (isNine)
                nums.Add(1);

            var res = nums.ToArray();
            Array.Reverse(res);
            return res;
        }
    }
}
