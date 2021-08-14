using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonDay8
{
   public class LineCompare
    {
        int x1, x2, y1, y2;
        public LineCompare(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;

        }
        public double Length()
        {
            double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return d;
        }
        public static void Equal(double Line1, double Line2)
        {
            if (Line1.Equals(Line2))
                Console.WriteLine("Lines are Equal");
            else
                Console.WriteLine("Lines Are Not Equal");
        }
        public static void CompareTo(double Line1, double Line2)
        {

            if (Line1.CompareTo(Line2) > 0)
                Console.WriteLine("Line1 is greater than Line2");
            else
                Console.WriteLine("Line1 is less than Line2");

        }
    }
}
