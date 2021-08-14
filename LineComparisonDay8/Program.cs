using System;

namespace LineComparisonDay8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LineComparison Problem");
            LineCompare obj = new LineCompare(5, 9, 10, 21);
            double LineOne = obj.Length();
            Console.WriteLine("Length of Line1:" + LineOne);

            LineCompare obj1 = new LineCompare(1, 3, 1, 3);
            double LineTwo = obj1.Length();
            Console.WriteLine("Length of Line2:" + LineTwo);
            LineCompare.Equal(LineOne, LineTwo);
        }
    }
}
