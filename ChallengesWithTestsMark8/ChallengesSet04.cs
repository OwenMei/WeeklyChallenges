using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return (numbers.Where(x => x%2 == 0).Sum() - numbers.Where(x => x%2 != 0).Sum());
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return new int[] { str1.Length, str2.Length, str3.Length, str4.Length }.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return new int[] { number1, number2, number3, number4 }.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3 && sideLength3 + sideLength2 > sideLength1 && sideLength1 + sideLength3 > sideLength2);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double n);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(x => x == null).Count() > objs.Length/2;
        }

        public double AverageEvens(int[] numbers)
        {
            return (numbers != null && numbers.Any(x => x%2 == 0))? numbers.Where(x => x%2 == 0).Average() : 0;
        }

        public int Factorial(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int fact = 1;
            for(int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
