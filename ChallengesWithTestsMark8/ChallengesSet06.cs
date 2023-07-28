using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if(words == null) { return  false; }
            return (ignoreCase)? words.Where(x => x != null).Select(x => x.ToLower()).Contains(word.ToLower()) : words.Contains(word);
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i < num - 1; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
            
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach(char c in str)
            {
                if (dict.ContainsKey(c))
                    dict[c]++;
                else dict[c] = 1;
            }
            int[] uniques = dict.Where(x => x.Value == 1).Select(x => x.Key).Select(x => str.IndexOf(x)).ToArray();
            if (uniques.Length == 0)
                return -1;
            return uniques.Max();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxCons = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                int tempCons = 0;
                for(int j = i; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                        tempCons++;
                    else break;
                }
                if (tempCons > maxCons)
                    maxCons = tempCons;
            }
            return maxCons;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (n <= 0 || elements == null)
                return new double[] { };
            List<double> result = new List<double>();
            for(int i = 0; i < elements.Count; i++)
            {
                if((i+1)%n == 0)
                {
                    result.Add(elements[i]);
                }
            }
            return result.ToArray();
        }
    }
}
