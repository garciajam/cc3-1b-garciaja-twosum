using System;
using System.Runtime.InteropServices;

namespace cc3_1b_garciaja_twosum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of the array: ");
            int nos = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[nos];

            for (int x = 0; x < nos; x++)
            {
                Console.Write($"Enter index[{x}]: ");
                nums[x] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter Target: ");
            int target = Convert.ToInt32(Console.ReadLine());
            bool solution = false;

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
                        Console.WriteLine($"Output: [ {j}, {i} ]");
                        solution = true;
                        break;
                    }   
                }

                if (solution == true)
                {
                    break;
                }
            }
            if (solution == false)
            {
                Console.WriteLine("No solution found!");
            }
        }
    }
}