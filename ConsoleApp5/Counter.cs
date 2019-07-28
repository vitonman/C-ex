using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Counter
    {

        public int Value { get; set; }

        public static Counter operator +(Counter c1, Counter c2)
        {
            return new Counter { Value = c1.Value + c2.Value };
        }

        public static bool operator >(Counter c1, Counter c2)
        {
            return c1.Value > c2.Value;
        }

        public static bool operator <(Counter c1, Counter c2)
        {

            return c1.Value < c2.Value;

        }

        public static int operator +(Counter c1, int val)
        {
            return c1.Value + val;
        }

        public static Counter operator ++(Counter c1)
        {
            return new Counter { Value = c1.Value + 10 };
        }

    }
}
