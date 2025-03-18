using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeTest
{
    public static class Tester
    {
        /// <summary>
        /// Function that take a string and returns true if the string is a palindrome
        /// </summary>
        /// <param name="input">string</param>
        /// <returns>bool</returns>
        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
                return true; 

            int left = 0;
            int right = input.Length - 1;
            while (left < right)
            {
                if (input[left] != input[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }

        /// <summary>
        /// Function that takes a string and returns the count of each character in the string
        /// </summary>
        /// <param name="inpput">input string</param>
        /// <returns>Dictionary with each character from the string as the key and the count of each character as the value</returns>
        public static Dictionary<char, int> CharacterCount(string inpput)
        {
            Dictionary<char, int> output = new Dictionary<char, int>();
            foreach (char c in inpput)
            {
                if (output.ContainsKey(c))
                    output[c]++;
                else
                    output[c] = 1;
            }
            return output;
        }


        /// <summary>
        /// Function that accepts two arrays of integers and returns an array of integers that are in both arrays.
        /// </summary>
        /// <param name="input1">an array of integers</param>
        /// <param name="input2">an array of integers</param>
        /// <returns>an array of integers</returns>
        public static int[] GetMatches(int[] input1, int[] input2)
        {
            HashSet<int> set1 = new HashSet<int>(input1);
            HashSet<int> set2 = new HashSet<int>(input2);
            set1.IntersectWith(set2);
            return set1.ToArray();
        }
    


        /// <summary>
        /// Function that accepts two arrays of integers and returns an array of integers that are not in both arrays.
        /// </summary>
        /// <param name="input1">an array of integers</param>
        /// <param name="input2">an array of integers</param>
        /// <returns>an array of integers</returns>
        public static int[] GetDiff(int[] input1, int[] input2)
        {
            HashSet<int> set1 = new HashSet<int>(input1);
            HashSet<int> set2 = new HashSet<int>(input2);
            IEnumerable<int> diff1 = set1.Except(set2);
            IEnumerable<int> diff2 = set2.Except(set1);
            return diff1.Union(diff2).ToArray();
        }
    }
}  
