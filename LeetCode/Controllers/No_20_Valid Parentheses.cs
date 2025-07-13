using System.Linq;

namespace LeetCode.Controllers
{
    public class No_20_Valid_Parentheses
    {

        //s = "()[]{}"
        public bool IsValid(string s)
        {
            var stackBox = new Stack<char>();
            var mapBox = new Dictionary<char, char>
            {
                { ')' , '(' },
                { ']' , '[' },
                { '}' , '{' }
            };
            foreach (char c in s)
            {
                if (mapBox.ContainsValue(c))
                {
                    stackBox.Push(c);
                }
                else if (mapBox.ContainsKey(c))
                {
                    if (stackBox.Count == 0 || stackBox.Pop() != mapBox[c])
                    {
                        return false;
                    }
                }
            }

            return stackBox.Count() == 0;
        }
    }
}


//URL: https://leetcode.com/problems/valid-parentheses/description/

//20.Valid Parentheses

//Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

//An input string is valid if:

//	Open brackets must be closed by the same type of brackets.
//	Open brackets must be closed in the correct order.
//	Every close bracket has a corresponding open bracket of the same type.

 
//Example 1:

//Input: s = "()"

//Output: true

//Example 2:

//Input: s = "()[]{}"

//Output: true

//Example 3:

//Input: s = "(]"

//Output: false

//Example 4:

//Input: s = "([])"

//Output: true



//Constraints:

//1 <= s.length <= 104

//    s consists of parentheses only '()[]{}'.