namespace ContainerWithMostWaterCalculator
{
    public class ContainerWithMostWaterCalculator
    {
        public int MaxArea(int[] height)
        {
            var maxArea = 1;
            var area = 0;
            int j = height.Length - 1;
            for (int i = 0; i < j; i++)
            {
                var firstIndex = height[i];
                var lastIndex = height[j];
                var width = j - i;
                if (firstIndex > lastIndex)
                {
                    area = lastIndex * width;
                    j--;
                }
                else if (firstIndex < lastIndex)
                {
                    area = firstIndex * width;
                }
                maxArea = Math.Max(maxArea, area);
            }
            return maxArea;
        }
    }
}