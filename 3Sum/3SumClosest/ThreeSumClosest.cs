namespace _3SumClosest
{
    public class ThreeSumClosestCalculator
    {
        public int GetThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int closest = nums[0] + nums[1] + nums[nums.Length - 1];
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;

                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (sum > target)
                        k--;
                    else
                        j++;

                    if (Math.Abs(sum - target) < Math.Abs(closest - target))
                        closest = sum;
                }
            }
            return closest;
        }
    }
}