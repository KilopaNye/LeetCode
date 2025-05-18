namespace LeetCode.Controllers
{
    public class No_15_3SUM
    {
        
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            //[-4, -1, -1, 0, 1, 2]

            var result = new List<IList<int>>();
            //一定要有三個值才能成立，所以index只做到-2的位子，最後兩個 index 是 left 和 right的位子
            for (int i = 0; i < nums.Length - 2; i++)
            {
                //當前nums[i]的數值跟前一位重複就跳過，避免index重複當頭
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        //跳過重複 從下一個數字開始
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;

                        left++;
                        right--;
                    }
                    else if (sum < 0) //負的表示還需要更多 往右邊較大的繼續
                    {
                        left++;
                    }
                    else //sum值太多 往左邊找小的組合看看
                    {
                        right--;
                    }
                }
            }

            return result;
        }

    }
}


//keyword : 比大小 、two pointer、
//
//

//URL: https://leetcode.com/problems/3sum/description/

//15. 3Sum

//Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

//Notice that the solution set must not contain duplicate triplets.

 
//Example 1:

//Input: nums = [-1,0,1,2,-1,-4]
//Output: [[-1,-1,2],[-1,0,1]]
//Explanation: 
//nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
//nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
//nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
//The distinct triplets are [-1,0,1] and [-1,-1,2].
//Notice that the order of the output and the order of the triplets does not matter.

//Example 2:

//Input: nums = [0,1,1]
//Output: []
//Explanation: The only possible triplet does not sum up to 0.

//Example 3:

//Input: nums = [0,0,0]
//Output: [[0,0,0]]
//Explanation: The only possible triplet sums up to 0.

 
//Constraints:

//	3 <= nums.length <= 3000
//	-105 <= nums[i] <= 105URL: https://leetcode.com/problems/3sum/description/

//15. 3Sum

//Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

//Notice that the solution set must not contain duplicate triplets.

 
//Example 1:

//Input: nums = [-1,0,1,2,-1,-4]
//Output: [[-1,-1,2],[-1,0,1]]
//Explanation: 
//nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
//nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
//nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
//The distinct triplets are [-1,0,1] and [-1,-1,2].
//Notice that the order of the output and the order of the triplets does not matter.

//Example 2:

//Input: nums = [0,1,1]
//Output: []
//Explanation: The only possible triplet does not sum up to 0.

//Example 3:

//Input: nums = [0,0,0]
//Output: [[0,0,0]]
//Explanation: The only possible triplet sums up to 0.

 
//Constraints:

//	3 <= nums.length <= 3000
//	-105 <= nums[i] <= 105