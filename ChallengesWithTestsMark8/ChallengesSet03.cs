using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return ((numbers?.Where(x => x%2 != 0).Sum()) ?? 0)%2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {

            return (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit));
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[^1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return (divisor != 0)? dividend/divisor : 0;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(0,50).Select(x => x * 2 + 1).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i< words.Length; i++) 
            { 
                words[i] = words[i].ToUpper(); 
            }
        }
    }
}
