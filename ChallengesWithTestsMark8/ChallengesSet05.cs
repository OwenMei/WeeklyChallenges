using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int tempNum = startNumber+1;
            while (tempNum % n != 0)
                tempNum++;
            return tempNum;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue <= 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0) return false;
            return numbers.SequenceEqual(numbers.OrderBy(x => x).ToArray());
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if(numbers == null) { return  0; }
            List<int> afterEvens = new List<int>();
            for(int i = 0; i < numbers.Length-1; i++) 
            {
                if (numbers[i] % 2 == 0)
                {
                    afterEvens.Add(numbers[i+1]);
                }
            }
            return afterEvens.Sum();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if(words == null) { return ""; }
            string[] modifiedWords = words.Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => x.Trim()).ToArray();
            if(modifiedWords.Length == 0) { return ""; }
            return string.Join(" ", modifiedWords) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if(elements == null) { return new double[] {} ; }
            List<double> returned = new List<double>();
            for(int i = 0; i < elements.Count;i++)
            {
                if((i+1)%4 == 0)
                {
                    returned.Add(elements[i]);
                }
            }
            return returned.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int i = 0; i < nums.Length; i++)
            {
               int first = nums[i];
               for(int j = i + 1; j < nums.Length; j++)
               {
                    int second = nums[j];
                    if (first + second == targetNumber)
                    {
                        return true;
                    }
               }
               
            }
            return false;
        }
    }
}
