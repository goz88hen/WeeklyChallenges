using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return false;
            }

            foreach (var items in vals)
            {
                if (items == false)
                {
                    return true;
                }
            }
            return false;
            //return vals != null && vals.Length != 0 && vals.Contains(false);
        }

        public object ChangeAllElementsToUppercase(string[] values)
        {
            for (int i = 0; i < values.Length; i++) 
            {
                values[i] = values[i].ToUpper();  
            }
            return values;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend/ divisor;
            }
        }

        public char GetFirstLetterOfString(string str)
        {
            return str.FirstOrDefault();
        }

        public char GetLastLetterOfString(string str)
        {
            return str.LastOrDefault();
        }

        public int[] GetOddsBelow100()
        {
            
            return Enumerable.Range(1,100).Where(x => x % 2 != 0).ToArray();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            {
                if (numbers == null)
                {
                    return false;
                }

                int sum = 0;
                foreach (var number in numbers)
                {
                    if (number % 2 != 0)
                    {
                        sum += number;
                    }
                }
                return sum % 2 != 0;

            }
        }

        public int LastMinusFirst(int[] numbers)
        {
            return numbers[numbers.Length -1]- numbers[0] ;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsUpper) && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber);

            //bool isLetter = false;
            //bool isDigit = false;
            //bool isUpper = false;

            //foreach (var letter in password)
            //{
            // if (char.IsLower(letter))
            // {
            // isLetter = true;
            // }
            // if (char.IsDigit(letter))
            // {
            //     isDigit = true;
            // }
            // if (char.IsUpper(letter))
            // {
            //     isUpper = true;
            // }
            // return isUpper && isLetter && isDigit;
        }
    }
}





