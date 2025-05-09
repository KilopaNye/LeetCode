﻿using System.ComponentModel;
using System.Text;

namespace LeetCode.Controllers
{
    public class Class
    {
        //["neet","code","love","you"]
        public string Encode(List<string> strs)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var str in strs)
            {
                sb.Append(str.Length).Append('#').Append(str);
            }
            return sb.ToString();
            //sb = "4#neet4#code4#love3#you"
        }

        public List<string> Decode(string s)
        {
            List<string> result = new List<string>();
            int i = 0;
            //[100#neet123100#c###ode4#love3#you"]
            while (i < s.Length)
            {
                int j = i;
                // 找到 # 前面的數字(長度  等於#的話代表分隔  因為每次的開始 必定為數字加一個# 數字可能為兩到三位數

                //1.取數字:
                while (s[j] != '#')
                {
                    j++;
                    //j = 這次字串的數字
                }

                
                // - i = J跟i差多少位子 決定哪幾位為這次的數字
                int length = int.Parse(s.Substring(i, j - i));//0 ~ (1-0) = 4 ==> length = int.Parse("4");


                //2.取字串:
                //從跳過#的下一個位子開始取字。 所以 j = 數字最後一位的位子 , + 1 會從#後面開始算分割字串
                //(4)#neet => 從#開始取4 = neet
                string str = s.Substring(j + 1, length);
                result.Add(str);

                // 更新 i 到下一串資料，i = 這次字串結束的下一個位置 i = 6
                i = j + 1 + length;
            }

            return result;
        }
    }
}

//public string Encode(List<string> strs)
//{
//    StringBuilder sb = new StringBuilder();
//    foreach (var str in strs)
//    {
//        sb.Append('#').Append(str);
//    }
//    return sb.ToString();
//}

//public List<string> Decode(string s)
//{
//    return s.Split('#');
//}
//["", "hello", "wor", "ld", "test"] X

//Encode and Decode Strings
//Solved 
//Design an algorithm to encode a list of strings to a single string. The encoded string is then decoded back to the original list of strings.

//Please implement encode and decode

//Example 1:

//Input: ["neet","code","love","you"]

//Output: ["neet","code","love","you"]
//Example 2:

//Input: ["we","say",":","yes"]

//Output: ["we","say",":","yes"]
//Constraints:

//0 <= strs.length < 100
//0 <= strs[i].length < 200
//strs[i] contains only UTF-8 characters.