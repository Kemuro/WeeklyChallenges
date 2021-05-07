using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false) ? true : false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var sum = 0;
            if(numbers == null)
            {
                return false;
            }
            foreach(var num in numbers)
            {
                if(num % 2 != 0)
                {
                    sum += num;
                }
            }
            return sum % 2 == 0 ? false : true;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var count = 0;
            if (password.Any(char.IsUpper))
            {
                count++;
            }
            if (password.Any(char.IsLower))
            {
                count++;
            }
            if (password.Any(char.IsNumber))
            {
                count++;
            }
            return count == 3 ? true : false;
        }

        public char GetFirstLetterOfString(string val)
        {
            var arr = val.ToArray();
            return arr[0];
        }

        public char GetLastLetterOfString(string val)
        {
            var arr = val.ToArray();
            return arr[arr.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for(int i = 0; i < 100 ; i++)
            {
                if(i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            var arr = list.ToArray();
            return arr;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                
                words[i] = words[i].ToUpper();
            }
            
        }
    }
}
