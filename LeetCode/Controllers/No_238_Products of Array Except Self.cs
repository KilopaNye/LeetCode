namespace LeetCode.Controllers
{
    using System;

    class Program
    {

        
        static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] answer = new int[n];

            //nums = [1, 2, 3, 4]
            //把最左邊填滿 *1 還是一樣 =>> answer[i - 1] 會用到 讓default不為0 避免全部變成0
            answer[0] = 1;
            for (int i = 1; i < n; i++)
            {
                answer[i] = answer[i - 1] * nums[i - 1];
            }
            //[1, 1, 2, 6]

            //nums = [1, 2, 3, 4]
            //right變化[24 <- 12 <- 4 <- 1]
            int right = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                answer[i] *= right;

                //保留右邊的相乘結果
                right *= nums[i];
            }
            //[24, 12, 8, 6]

            return answer;

        }


        public int[] ProductExceptSelfUseForeach(int[] nums)
        {
            int n = nums.Length;
            int[] answer = new int[n];

            for (int i = 0; i < n; i++)
            {
                int product = 1;
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        product *= nums[j];
                    }
                }
                answer[i] = product;
            }

            return answer;
        }
    }
}


//URL: https://leetcode.com/problems/product-of-array-except-self/description/

//238. Product of Array Except Self

//Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

//The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

//You must write an algorithm that runs in O(n) time and without using the division operation.

 
//Example 1:
//Input: nums = [1,2,3,4]
//Output: [24,12,8,6]
//Example 2:
//Input: nums = [-1,1,0,-3,3]
//Output: [0,0,9,0,0]

 
//Constraints:

//	2 <= nums.length <= 105
//	-30 <= nums[i] <= 30
//	The input is generated such that answer[i] is guaranteed to fit in a 32-bit integer.

 
//Follow up: Can you solve the problem in O(1) extra space complexity? (The output array does not count as extra space for space complexity analysis.)URL: https://leetcode.com/problems/product-of-array-except-self/description/

//238. Product of Array Except Self

//Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

//The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

//You must write an algorithm that runs in O(n) time and without using the division operation.

 
//Example 1:
//Input: nums = [1,2,3,4]
//Output: [24,12,8,6]
//Example 2:
//Input: nums = [-1,1,0,-3,3]
//Output: [0,0,9,0,0]

 
//Constraints:

//	2 <= nums.length <= 105
//	-30 <= nums[i] <= 30
//	The input is generated such that answer[i] is guaranteed to fit in a 32-bit integer.

 
//Follow up: Can you solve the problem in O(1) extra space complexity? (The output array does not count as extra space for space complexity analysis.)