using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class NullableTest
    {
        public void ShowNumber()
        {
            int? i = null;
            double? d = null;

            int j = 15;
            double f = 3.1415;

            char? s = null;
            bool? b = null;

            bool p = true;
            string t = "Happy New Year!";

            Console.WriteLine("There data for i, j, d, f, s, t, b, p are: {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", i, j, d, f, s, t, b, p);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // create a instance of NullableTest class
            NullableTest naTest = new NullableTest();

            // Show the numbers including nullable ones
            naTest.ShowNumber();
        }
    }
}
