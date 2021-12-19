using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class TwoSumCalculator
    {
        public int[] GetTwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            int index;
            var temp = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                var isComplementPresent = temp.TryGetValue(complement, out index);
                if (isComplementPresent == false)
                {
                    temp[nums[i]] = i;
                }
                else
                {
                    result[0] = i;
                    result[1] = index;
                    return result;
                }
            }
            return result;
        }
    }
}
