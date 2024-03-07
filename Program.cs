using System;
using System.Runtime.InteropServices;

namespace cc3_1b_garciaja_twosum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3,3 };
            int target = 6;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        break;
                    }
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"[ {i}, {j} ]");
                    }                   
                }
            }


            //foreach (int x in nums)
            //{
                
                
            //    foreach (int y in nums)
            //    {
            //        int index1 = Array.IndexOf(nums, x);
            //        int index2 = Array.IndexOf(nums, y);

            //        if (index1 == index2) 
            //        {
            //            break;
            //        }   
            //        else if (x + y == target)
            //        {
                        
            //            Console.WriteLine($"[ {index1}, {index2} ]");
                        
            //        }  
            //    }     
            //}
        }
    }
}