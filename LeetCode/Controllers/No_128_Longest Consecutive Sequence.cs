namespace LeetCode.Controllers
{
    public class No_128_Longest_Consecutive_Sequence
    {
        public int LongestConsecutive(int[] nums)
        {
            //if (nums.Length == 0) return 0;

            HashSet<int> numSet = new HashSet<int>();
            foreach (int num in nums)
            {
                if (!numSet.Contains(num))
                {
                    numSet.Add(num);
                }
            }

            int maxCon = 0;

            foreach (int num in numSet)
            {
                // 如果沒有 num - 1，代表連續的起點
                if (!numSet.Contains(num - 1))
                {
                    int itemNum = num;
                    
                    int conStart = 1;//起始值

                    while (numSet.Contains(itemNum + 1))
                    {
                        itemNum++;
                        conStart++;
                    }

                    // Update最大值
                    if (conStart > maxCon)
                    {
                        maxCon = conStart;
                    }
                }
            }

            return maxCon;
        }
    }
}


//URL: https://leetcode.com/problems/longest-consecutive-sequence/description/

//128. Longest Consecutive Sequence

//Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.

//You must write an algorithm that runs in O(n) time.

 
//Example 1:

//Input: nums = [100,4,200,1,3,2]
//Output: 4
//Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.

//Example 2:

//Input: nums = [0,3,7,2,5,8,4,6,0,1]
//Output: 9

//Example 3:

//Input: nums = [1,0,1,2]
//Output: 3

 
//Constraints:

//	0 <= nums.length <= 105
//	-109 <= nums[i] <= 109URL: https://leetcode.com/problems/longest-consecutive-sequence/description/

//128. Longest Consecutive Sequence

//Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.

//You must write an algorithm that runs in O(n) time.

 
//Example 1:

//Input: nums = [100,4,200,1,3,2]
//Output: 4
//Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.

//Example 2:

//Input: nums = [0,3,7,2,5,8,4,6,0,1]
//Output: 9

//Example 3:

//Input: nums = [1,0,1,2]
//Output: 3

 
//Constraints:

//	0 <= nums.length <= 105
//	-109 <= nums[i] <= 109