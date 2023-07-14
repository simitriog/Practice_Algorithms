using App_Test.Classes;
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
            Pointers objPointer = new Pointers();

            string cadena = "[{()}]";

            //int[] inputArray = { 10, 1, 2, 3, 4, 5, 6, 1 };
            //var res = objEdge.almostIncreasingSequence(inputArray);

            var resC = objPointer.validateChar(cadena);
        }
    }
}