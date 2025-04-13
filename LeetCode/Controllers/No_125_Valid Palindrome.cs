using System.Text;

namespace LeetCode.Controllers
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {

            var strBox = new StringBuilder();
            //空白不是英數字 排除
            foreach (var i in s)
            {
                if (char.IsLetterOrDigit(i))
                {
                    strBox.Append(char.ToLower(i));
                }
            }

            string str = strBox.ToString();

            //反轉字串 因為string(char[]) 所以加上.ToArray()
            string reversed = new string(str.Reverse().ToArray());

            return str == reversed;
        }

        public bool IsPalindrome2(string s)
        {
            var strBox = new StringBuilder();
            //空白不是英數字 排除
            foreach (var i in s)
            {
                if (char.IsLetterOrDigit(i))
                {
                    strBox.Append(char.ToLower(i));
                }
            }

            int left = 0;
            int right = strBox.Length - 1;

            for(int i=0; i< strBox.Length; i++)
            {
                string leftChar = strBox[left].ToString();
                string rightChar = strBox[right].ToString();

                if(leftChar != rightChar)
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}


//URL: https://leetcode.com/problems/valid-palindrome/description/

//125.Valid Palindrome

//A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

//Given a string s, return true if it is a palindrome, or false otherwise.

 
//Example 1:

//Input: s = "A man, a plan, a canal: Panama"
//Output: true
//Explanation: "amanaplanacanalpanama" is a palindrome.

//Example 2:

//Input: s = "race a car"
//Output: false
//Explanation: "raceacar" is not a palindrome.

//Example 3:

//Input: s = " "
//Output: true
//Explanation: s is an empty string "" after removing non-alphanumeric characters.
//Since an empty string reads the same forward and backward, it is a palindrome.

 
//Constraints:

//	1 <= s.length <= 2 * 105

//    s consists only of printable ASCII characters.