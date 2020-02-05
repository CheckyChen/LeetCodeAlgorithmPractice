using System;
using System.Collections;
using System.Collections.Generic;

namespace _0001.两数之和
{
    class Program
    {
        static void Main(string[] args)
        {

            var nums = new int[] { 2, 7, 11, 15 };
            var target = 18;

            int[] ret = TwoSum(nums, target);

            Console.WriteLine(ret);

            Console.WriteLine("Hello World!");
        }


        //给定一个整数数组 nums和一个目标值 target，请你在该数组中找出和为目标值的那 两个整数，并返回他们的数组下标。
        //你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。

        //示例:

        //给定 nums = [2, 7, 11, 15], target = 9

        //因为 nums[0] + nums[1] = 2 + 7 = 9
        //所以返回[0, 1]


        public static int[] TwoSum(int[] nums, int target)
        {
            var hs = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                hs.Add(i, nums[i]);
            }

            int firstNum, secondNum;
            foreach (int index in hs.Keys)
            {
                firstNum = (int)hs[index];
                secondNum = target - firstNum;

                if (hs.ContainsValue(secondNum))
                {                                        
                    foreach (int item in hs.Keys)
                    {
                        if (index == item)
                            continue;

                        if ((int)hs[item] == secondNum)
                        {
                            return new int[] { index, item };
                        }
                    }
                }
            }
            throw new Exception("no such sum num");
        }
    }
}
