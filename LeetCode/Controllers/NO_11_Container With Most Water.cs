namespace LeetCode.Controllers
{
    public class NO_11_Container_With_Most_Water
    {
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;

            while (left < right)
            {
                int h = Math.Min(height[left], height[right]);
                int w = right - left;
                int area = h * w;
                maxArea = Math.Max(maxArea, area);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                } 
            }

            return maxArea;
        }
    }
}
