using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLength
{
    public class UC1_Cartesian

    {
        public double x1, x2, y1, y2;
        public double UserCartesian()
        {
            Console.WriteLine("Enter First and second Number:x1 and y1");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter First and second Number:x2 and y2");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            return length();
            
        }

        public double length ()
        {
            double temp1 = Math.Pow(x2 - x1, 2);
            double temp2 = Math.Pow(y2 - y1, 2);

            double result = Math.Sqrt(temp1 + temp2);
            return result;
        }
    }
}
