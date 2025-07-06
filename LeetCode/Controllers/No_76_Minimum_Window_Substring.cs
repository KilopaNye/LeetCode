namespace LeetCode.Controllers
{
    public class No_76_Minimum_Window_Substring
    {
        public string MinWindow(string s, string t)
        {
            if (s.Length == 0 || t.Length == 0)
                return "";

            Dictionary<char, int> need = new Dictionary<char, int>();
            Dictionary<char, int> window = new Dictionary<char, int>();
            int left = 0, right = 0;
            int matchCharType = 0;
            int resultStart = 0;
            int resultLen = int.MaxValue;
            bool hasResult = false;

            foreach (char c in t)
            {
                if (!need.ContainsKey(c))
                    need[c] = 0;
                need[c]++;
            }


            while (right < s.Length)
            {
                char c = s[right];
                right++;

                if (need.ContainsKey(c))
                {
                    if (!window.ContainsKey(c))
                        window[c] = 0;
                    window[c]++;
                    if (window[c] == need[c])
                        matchCharType++; 
                }

                while (matchCharType == need.Count)
                {
                    if (right - left < resultLen)
                    {
                        resultStart = left;
                        resultLen = right - left;
                        hasResult = true;
                    }

                    char d = s[left];
                    left++;

                    if (need.ContainsKey(d))
                    {
                        if (window[d] == need[d])
                            matchCharType--;
                        window[d]--;
                    }
                }
            }

            if (hasResult)
                return s.Substring(resultStart, resultLen);
            else
                return "";
        }
    }
}
