using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return(Char.IsLetter(c));
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0) ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0)? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0) ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double maxNum = double.MinValue;
            double minNum = double.MaxValue;
            if(numbers == null) { return 0; }
            foreach (double num in numbers) 
            {
                if(num > maxNum)
                {
                    maxNum = num;
                }
                if(num < minNum)
                {
                    minNum = num;
                }
            }
            return maxNum + minNum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return Math.Min(str1.Length, str2.Length);
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if(numbers == null ) { return 0; } 
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null) { return 0; }
            foreach (int num in numbers)
            {
                if(num%2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if (numbers == null) { return false; }
            foreach (int num in numbers)
            {
                sum += num;
            }
            return (sum%2 != 0)? true: false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return (number > 0) ? number / 2 : 0;
        }
    }
}
