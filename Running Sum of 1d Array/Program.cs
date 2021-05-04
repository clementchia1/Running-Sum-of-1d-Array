using System;

namespace Running_Sum_of_1d_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {1, 2, 3, 4, 5};
            Program program = new Program();
            Console.Write("RunningSum(");
            Array.ForEach(nums, element=>Console.Write(element+ ", "));
            Console.WriteLine("):");
            Array.ForEach(program.RunningSum(nums), element => Console.Write(element + ", "));
            
        }
        public int[] RunningSum(int[] nums)
        {
            int[] result = new int[nums.Length];

            result[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = result[i - 1] + nums[i];
            }
            return result;
        }
    }
}
