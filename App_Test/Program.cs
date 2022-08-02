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

            int[] inputArray = { 10, 1, 2, 3, 4, 5, 6, 1 };
            var res = objEdge.almostIncreasingSequence(inputArray);
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
        if (n == 1)
            return 1;

        return squareLap(n);
    }

    private int squareLap(int n)
    {
        int pA = 0, res = 0;
        for (int i = 1; i < n; i++)
        {
            if (i == 1)
            {
                pA = (4 * i) + 1;
                res = pA;
            }

            if (i != 1)
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

    #region Almost Increasing Sequence

    public bool almostIncreasingSequence(int[] sequence)
    {

        if (sequence.Count() == 2)
            return true;

        bool res = true;
        int c = 0, d = 0, e = 0;

        Array.Sort(sequence);

        while (c < sequence.Count())
        {
            int[] tempArr = returnNewArray(sequence, c);

            d = 0;

            while (d < tempArr.Count() - 1)
            {
                if (tempArr.Count() < 4) if (tempArr[d] == tempArr[d + 1]) return false;

                if (tempArr[d] == tempArr[d + 1])
                {
                    if (d == 0 && tempArr[d] == tempArr[d + 1])
                        return false;

                    int[] tempArr2 = returnNewArray(tempArr, d);

                    e = 0;

                    while (e < tempArr2.Count() - 1)
                    {
                        if (tempArr2[e] == tempArr2[e + 1])
                            return false;

                        e++;
                    }
                }

                if (tempArr[d] > tempArr[d + 1]) return false;

                d++;
            }

            c++;
        }

        return res;
    }

    private int[] returnNewArray(int[] array, int position)
    {
        int[] res = new int[array.Count() - 1];
        int c = 0, d = 0;

        while (c < array.Count())
        {
            if (c != position)
                res[d] = array[c]; d++;

            c++;
        }

        return res;
    }

    #endregion

    #region Test Solutions

    /*
     * string[] A = { "sander", "amy", "ann", "michael" };
       string[] B = { "123456789", "234567890", "789123456", "123123123" };
       string P = "1";
     */

    public bool returnValidation(int[] array, int number, int times)
    {
        int valCount = 0, c = 0;

        Array.Sort(array);

        while (c < array.Count())
        {
            if (array[c] == number)
            {
                valCount++;
            }

            c++;
        }

        if (valCount == times || valCount > times)
            return true;
        else
            return false;
    }

    public int returnDiference(int[] array)
    {
        int res = 0, c = 0, d = 0, e = 0;

        Array.Sort(array);

        if (array.Count() <= 3)
        {
            res = array[array.Count() - 1] - array[0];

            return res;
        }
        else
        {
            while (c < array.Count())
            {
                if (evenNumber(array[c]) != true)
                    d++;

                c++;
            }
        }
        int[] objArr = new int[d];

        c = 0;
        while (c < array.Count())
        {
            if (evenNumber(array[c]) != true)
            {
                objArr[e] = array[c];

                e++;
            }


            c++;
        }

        if (objArr.Count() <= 2)
        {
            res = objArr[0];
        }
        else
        {
            res = objArr[objArr.Count() - 1];
        }


        return res;
    }

    private bool evenNumber(int number)
    {
        if ((number % 2) == 0)
            return true;
        else
            return false;
    }

    public bool returnSameSizeVal(double[] array)
    {
        int c = 0, countD = 0;
        double sizeS = 0;
        bool res = true;

        Array.Sort(array);

        if (array.Count() < 2)
            return true;

        while (c < array.Count() - 1)
        {
            if (c == 0)
            {
                sizeS = Math.Round(array[c + 1] - array[c], 1);
            }
            else
            {
                if ((Math.Round(array[c + 1] - array[c], 1)) != sizeS)
                {
                    if (array[c] == array[c + 1])
                    {
                        sizeS = Math.Round(array[c + 1] - array[c], 1);
                    }
                    else if (countD < 2)
                    {
                        sizeS = Math.Round(array[c + 1] - array[c], 1);

                        countD++;
                    }
                    else return false;
                }


            }

            c++;
        }

        return res;
    }

    public int returnSmallInteger(int[] array)
    {
        int c = 1, d = 0, res = 0;
        int[] arrOp = new int[array.Count()];

        Array.Sort(array);

        if (array[array.Count() - 1] < 0)
            return 1;
        else if (array.Count() < 4 && array[array.Count() - 1] < 4)
            return 4;
        else
        {
            while (d < array.Count())
            {
                arrOp[d] = c;

                c++;
                d++;
            }

            c = 0;
            d = 0;

            while (c < array.Count())
            {
                if (array[c] != arrOp[d])
                {
                    d++;

                    if (array[c] != arrOp[d])
                        res = arrOp[d];
                }

                c++;
            }
        }

        return res;
    }

    public string returnContactName(string[] A, string[] B, string P)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        bool band = false;
        int c = 0, d = 0, e = 0;
        string res = string.Empty;
        string[] objArr = new string[d];

        while (c < B.Count())
        {
            if (B[c].Contains(P) && A.Count() <= 2) res = A[c];
            else if (B[c].Contains(P))
            {
                d++;
                band = true;
            }
            else
                res = "NO CONTACT";

            c++;
        }

        if (band)
        {
            c = 0;

            objArr = new string[d];

            while (c < B.Count())
            {
                if (B[c].Contains(P))
                {
                    objArr[e] = A[c];
                    e++;
                }

                c++;
            }

            res = A[returnPositionName(A, objArr)];
        }



        return res;
    }

    private int returnPositionName(string[] array, string[] compArr)
    {
        int res = 0, c = 0;

        Array.Sort(compArr);

        while (c < array.Count())
        {
            if (array[c] == compArr[0])
                res = c;

            c++;
        }


        return res;
    }

    #endregion


}
