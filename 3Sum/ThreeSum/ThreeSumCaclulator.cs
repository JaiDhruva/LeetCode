namespace ThreeSum
{
    public class ThreeSumCalculator
    {
        public List<List<int>> GetThreeSum(List<int> nums)
        {
            var result = new List<List<int>>();
            nums.Sort();

            for (int i = 0; i < nums.Count - 1; i++)
            {
                int j = i + 1;
                int k = nums.Count - 1;

                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                while (j < k)
                {
                    if (k < nums.Count - 1 && nums[k] == nums[k + 1])
                    {
                        k--;
                        continue;
                    }

                    if (nums[i] + nums[j] + nums[k] > 0)
                    {
                        k--;
                        continue;
                    }
                    else if (nums[i] + nums[j] + nums[k] < 0)
                    {
                        j++;
                        continue;
                    }
                    List<int> triplet = new List<int>();
                    triplet.Add(nums[i]);
                    triplet.Add(nums[j]);
                    triplet.Add(nums[k]);
                    result.Add(triplet);
                    j++;
                    k--;
                }
            }
            return result;
        }

    }
}