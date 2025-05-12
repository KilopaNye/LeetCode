namespace LeetCode.Controllers
{
    using System;

    class Program
    {
        //暴力解
        public int[] ProductExceptSelfUseForeach(int[] nums)
        {
            //nums = [1, 2, 3, 4]
            int n = nums.Length;
            int[] answer = new int[n];

            for (int i = 0; i < n; i++)
            {
                int product = 1;
                for (int j = 0; j < n; j++)
                {
                    if (i != j)//除了自己以外
                    {
                        product *= nums[j];
                    }
                }
                answer[i] = product;
            }

            return answer;
        }
        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] left = new int[n];
            int[] right = new int[n];
            int[] answer = new int[n];


            //nums = [1, 2, 3, 4]

            //把最左邊填滿 *1
            left[0] = 1;
            for (int i = 1; i < n; i++)
            {
                left[i] = left[i - 1] * nums[i - 1];
            }
            //[1, 1, 2, 6] = 紀錄目前index位置的所有左邊乘積

            right[n - 1] = 1;
            for (int i = n - 2; i >= 0; i--)
            {
                right[i] = right[i + 1] * nums[i + 1];
            }
            //right變化[24, 12, 4, 1]  = 紀錄目前index位置的所有右邊乘積

            //跑迴圈相乘
            for (int i = 0; i < n; i++)
            {
                answer[i] = left[i] * right[i];
            }

            return answer;
        }

        //優化版O(1)
        static int[] ProductExceptSelfOneArray(int[] nums)
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

            //nums = [1, 2, 3, 4]
            //[1, 1, 2, 6] = 紀錄目前index位置的所有左邊乘積

            //In-Place
            //right變化[24 <- 12 <- 4 <- 1]  = 紀錄目前index位置的所有右邊乘積
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