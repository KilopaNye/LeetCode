using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Xml;

namespace LeetCode.Controllers
{
    public class No_347_Top_K_Frequent_Elements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            //[1,1,1,2,2,3] => ["1":3, "2":2, "3":1]
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!dict.ContainsKey(num))
                    dict[num] = 0;
                dict[num]++;
            }


            var minHeap = new PriorityQueue<int, int>();

            foreach (var item in dict)
            {
                //加入並排續
                minHeap.Enqueue(item.Key, item.Value);


                //如果數量已經大於K就踢掉(取出) 保持大小只會有K個
                if (minHeap.Count > k)
                    minHeap.Dequeue();
            }


            List<int> result = new List<int>();
            while (minHeap.Count > 0)
            {
                result.Add(minHeap.Dequeue());
            }

            result.Reverse();
            return result.ToArray();
        }

    }
}



//URL: https://leetcode.com/problems/top-k-frequent-elements/description/

//347.Top K Frequent Elements

//Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.

 
//Example 1:
//Input: nums = [1, 1, 1, 2, 2, 3], k = 2
//Output: [1,2]
//Example 2:
//Input: nums = [1], k = 1
//Output: [1]

 
//Constraints:

//1 <= nums.length <= 105
//- 104 <= nums[i] <= 104

//    k is in the range[1, the number of unique elements in the array].
//	It is guaranteed that the answer is unique.

 
//Follow up: Your algorithm's time complexity must be better than O(n log n), where n is the array's size.