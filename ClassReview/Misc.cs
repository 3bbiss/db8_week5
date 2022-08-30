using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassReview
{
    public class Misc
    {
        public static bool CheckRange(int x)
        {
            // Return true if num in 10-20 inc.
            // Else return false
            // Tests: 9, 10, 15, 20, 21
            if (x >= 10 && x <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Let's write a method that takes an int
        // and returns -1 if neg. 0 if 0. 1 is pos.
        public static int PosNeg(int x)
        {
            // First attempt
            //if (x < 0) { return -1; }
            //else if (x > 0) { return 1; }
            //else { return 0; }

            // shortcut 
            return Math.Sign(x);
        }





    }
}
