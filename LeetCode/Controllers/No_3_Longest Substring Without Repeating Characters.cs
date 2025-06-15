namespace LeetCode.Controllers
{
    public class No_3_Longest_Substring_Without_Repeating_Characters
    {
        public int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            int maxLength = 0;
            int left = 0;
            var set = new HashSet<char>();

            for (int right = 0; right < n; right++)
            {
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }

                set.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}
