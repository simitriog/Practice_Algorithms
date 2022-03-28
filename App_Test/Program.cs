using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TheJourneyBegins objJourney = new TheJourneyBegins();
            EdgeOfTheOcean objEdge = new EdgeOfTheOcean();

            int[] inputArray = { 1, 3, 2, 1 };
            bool res = objEdge.almostIncreasingSequence(inputArray);
        }
    }
}

public class TheJourneyBegins
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

public class EdgeOfTheOcean
{
    public int adjacentElementsProduct(int[] inputArray)
    {
        int i = 0, valM = 0;

        while (i < inputArray.Count() - 1)
        {
            int oprA = 0;

            if (i == 0)
                valM = inputArray[i] * inputArray[i + 1];
            else
            {
                oprA = inputArray[i] * inputArray[i + 1];

                if (valM < oprA)
                    valM = oprA;
            }
            i++;
        }

        return valM;
    }

    #region Shape Area

    public int shapeArea(int n)
    {
        int res = 0;

        if (n == 1)
            return 1;
        else
        {
            res = squareLap(n);
        }

        return res;
    }

    int squareLap(int n)
    {
        int pA = 0, res = 0;
        for (int i = 1; i < n; i++)
        {
            if (i == 1)
            {
                pA = (4 * i) + 1;
                res = pA;
            }
            else
            {
                pA = (4 * i) + pA;
                res = pA;
            }

        }
        return res;
    }

    #endregion

    #region Make Array Consecutive 2

    public int makeArrayConsecutive(int[] statues)
    {
        if (statues.Count() == 1)
            return 0;

        Array.Sort(statues);

        return returnDistinctNumbersInArray(statues);
    }

    private int returnDistinctNumbersInArray(int[] array)
    {
        int c = 0, fP = 0, lP = 0, nI = 0, tV = 0;
        fP = array[0];
        tV = array.Count() - 1;
        lP = array[tV];
        nI = fP;

        int[] cStatues = new int[(lP - fP) + 1];

        while (c <= (lP - fP))
        {
            cStatues[c] = nI;
            nI++;
            c++;
        }

        IEnumerable<int> distinct = cStatues.Except(array);

        return distinct.Count();
    }

    #endregion

    public bool almostIncreasingSequence(int[] sequence)
    {
        bool res = false;
        int c = 0;

        Array.Sort(sequence);



        while (c < sequence.Count() - 1)
        {
            int[] tempArr = returnNewArray(sequence);

            //tempArr =  tempArr.Where

            if (sequence[c] < tempArr[c + 1])
                res = true;

            c++;
        }

        return res;
    }

    private int[] returnNewArray(int[] array)
    {
        int[] res = new int[array.Count()];
        int c = 0;

        while (c < array.Count())
        {
            res[c] = array[c];
            c++;
        }

        return res;
    }

    private bool removeNumber(int n, int nR)
    {
        return n != nR;
    }
}
