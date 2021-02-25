using System;

namespace DateTime_01
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            DateTime dayForChildren = new DateTime(dt.Year, 5, 5);
            Console.WriteLine(dayForChildren);

            DateTime start = DateTime.Now;
            Sum();
            DateTime end = DateTime.Now;

            long gap = end.Ticks - start.Ticks;
            Console.WriteLine("Total Ticks : {0}", gap);
            Console.WriteLine("Millisecond : {0}", (gap / 10000));
            Console.WriteLine("Second : {0}", ((gap / 10000) / 1000));
        }

        private static long Sum()
        {
            long sum = 0;
            for (int i = 0; i < 1000000; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
