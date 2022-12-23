using System;
using System.Collections;
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

            //Merge Sorted Array
            int[] numbers1 = new int[5] { 1,1,1,4,6};
            int[] numbers2 = new int[5] { 1,1,2,2,5};
            int[] nums = Intersect(numbers1, numbers2);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
            }
            Console.WriteLine();

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

        //Sqrt(x)
        static int MySqrt(int x)
        {
            double result = Math.Sqrt(x);
            return (int)result;
        }
        //Pow(x, n)
        static double MyPow(double x, int n)
        {
            return Math.Pow(x, n);
        }

        //Climbing Stairs
        static int ClimbStairs(int n)
        {
            if (n == 0 || n == 1) return 1;

            return ClimbStairs(n - 1) + ClimbStairs(n - 2);
        }

        //Merge Sorted Array
        static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m; i < nums1.Length; i++)
            {
                if (nums1[i] == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        nums1[i] = nums2[j];
                        i++;
                    }
                }
            }
            Array.Sort(nums1);
        }

        //Intersection of Two Arrays II
        static int[] Intersect(int[] nums1, int[] nums2)
        {
            int count1;
            int count2;
            List<int> nums = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums2.Contains(nums1[i]))
                {
                    if(!nums.Contains(nums1[i]))
                    {
                        count1 = nums1.Count(x => x == nums1[i]);
                        count2 = nums2.Count(x => x == nums1[i]);
                        if(count1<count2)
                        {
                            for (int j = 0; j < count1; j++)
                            {
                                nums.Add(nums1[i]);
                            }
                        }
                        else
                        {
                            for (int j = 0; j < count2; j++)
                            {
                                nums.Add(nums1[i]);
                            }
                        }
                    }
                }
            }
            return nums.ToArray();
        }

        //3Sum
        //static IList<IList<int>> ThreeSum(int[] nums)
        //{
        //    List<int> nums1 = new List<int>(); 
        //    List<IList<int>> numbers = new List<IList<int>>();
        //    for (int j = 0; j < nums.Length; j++)
        //    {
        //        for (int i = 1; i < nums.Length; i++)
        //        {
        //            for (int k = 2; k < nums.Length; k++)
        //            {
        //                if(j!=i && j!=k && i!=k)
        //                {
        //                    if (nums[i] + nums[j] + nums[k] == 0)
        //                    {
        //                        nums1.Add(nums[j]);
        //                        nums1.Add(nums[i]);
        //                        nums1.Add(nums[k]);
        //                        nums1.Sort();
        //                        if (numbers.Count > 0)
        //                        {
        //                            for (int n = 0; n < numbers.Count; n++)
        //                            {
        //                                if(numbers[n].SequenceEqual(nums1))
        //                                {
        //                                    numbers[n] = nums1;
        //                                    nums1 = new List<int>();
        //                                }
        //                            }
        //                        }
        //                        if(numbers.Count == 0 || nums1.Count != 0)
        //                        {
        //                            numbers.Add(nums1);
        //                            nums1 = new List<int>();
        //                        }                              
        //                    }
        //                }
        //            }
        //        }
        //    }           
        //    return numbers;
        //}
    }
}
