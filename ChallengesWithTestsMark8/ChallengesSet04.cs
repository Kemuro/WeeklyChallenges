using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int res = 0;
            foreach(var num in numbers)
            {
                if(num % 2 == 0)
                {
                    res += num;
                }
                if(num % 2 != 0)
                {
                    res -= num;
                }
            }
            return res;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var arr = new string[4] { str1, str2, str3, str4 };
            int shortestString = str1.Length;
            foreach(var str in arr)
            {
                if(str.Length < shortestString)
                {
                    shortestString = str.Length;
                }
            }
            return shortestString;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var arr = new int[4] { number1, number2, number3, number4 };
            int smallestNum = number1;
            foreach(var num in arr)
            {
                if(num < smallestNum)
                {
                    smallestNum = num;
                }
            }
            return smallestNum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 <= sideLength3 ||
                    sideLength2 + sideLength3 <= sideLength1 ||
                    sideLength1 + sideLength3 <= sideLength2) ? false : true;
        }

        public bool IsStringANumber(string input)
        {
            if(input == null || input == "")
            {
                return false;
            }
            return input.All(char.IsDigit) ? true : false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int count = 0;
            int half = objs.Length / 2;
            foreach(var obj in objs)
            {
                if(obj == null)
                {
                    count++;
                }
            }
            return count > half ? true : false;
        }

        public double AverageEvens(int[] numbers)
        {
            var sum = 0;
            var count = 0;
            
            foreach(var num in numbers)
            {
                if(num % 2 == 0)
                {
                    sum += num;
                    count++;
                }
            }
            if(sum == 0 || numbers == null)
            {
                return 0;
            }
            var res = sum / count;
            if(sum % count != 0)
            {
                Convert.ToDouble(res);
                return res;
            }
            return res;
        }

        public int Factorial(int number)
        {
            int res = 1;
            if(number == 0)
            {
                return 1;
            }
            while(number != 1)
            {
                res = res * number;
                number--;
            }
            return res;
        }
    }
}
