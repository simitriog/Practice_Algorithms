using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Test.Classes
{
    internal class Pointers
    {
        public string[] arrParentecis = { "(", ")" };
        public string[] arrLlaves = { "{", "}" };
        public string[] arrCorchetes = { "[", "]" };

        public bool validateChar(string obj)
        {
            bool res = false, bandP = false, bandK = false, bandC = false;
            int cP = 0, cK = 0, cC = 0, cB = 0;

            foreach (char c in obj)
            {
                if (c.ToString() == arrCorchetes[0])
                {
                    cC++;
                    foreach (var d in obj)
                        if (d.ToString() == arrCorchetes[1]) { bandC = true; break; }
                }

                if (c.ToString() == arrLlaves[0])
                {
                    cK++;
                    foreach (var e in obj)
                        if (e.ToString() == arrLlaves[1]) { bandK = true; break; }
                }

                if (c.ToString() == arrParentecis[0])
                {
                    cP++;
                    foreach (var f in obj)
                        if (f.ToString() == arrParentecis[1]) { bandP = true; break; }
                }
            }

            if (cP > 0)
            {
                if (bandC == true) cB++;
                else return false;
            }

            if (cK > 0)
            {
                if (bandK == true) cB++;
                else return false;
            }

            if (cP > 0)
            {
                if (bandP == true) cB++;
                else return false;
            }

            if (cB > 0)
                res = true;

            return res;
        }
    }
}
