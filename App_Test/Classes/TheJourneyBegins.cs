using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Test.Classes
{
    internal class TheJourneyBegins
    {
        public int sumOfTwoNumbers(int number1, int number2)
        {
            return number1 + number2;
        }

        public int centuryFromYear(int year)
        {
            return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
        }

        public bool checkPalindrome(string inputString)
        {
            char[] arrO = inputString.ToCharArray();
            char[] arrI = inputString.ToCharArray();
            int i = 0;

            Array.Reverse(arrI);

            while (i < arrI.Count())
            {
                if (arrO[i] != arrI[i]) return false;
                i++;
            }

            return true;
        }
    }
}
