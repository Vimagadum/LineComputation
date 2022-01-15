using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLength
{
    public class LineCompare
    {
      public static void ComparingLines(double dis1,double dis2,double dis3)
        {
            if (dis1 > dis2 && dis1 > dis3 )
            {
                Console.WriteLine("Line 1 is greater than line 2 and line 3");
            }
            else if (dis2 > dis3)
            {
                Console.WriteLine("Line 2 is greater than line 3");
            }
            else
            {
                Console.WriteLine("Line 3 is greater than line 2");
            }

            if (dis1 < dis2 && dis1 < dis3 )
            {
                Console.WriteLine("Line 1 is lesser than line 2 and line 3");
            }
            else if (dis2 < dis3)
            {
                Console.WriteLine("Line 2 is lesser than line 3");
            }
            else
            {
                Console.WriteLine("Line 3 is lesser than line 2");
            }

        }

    }
}
