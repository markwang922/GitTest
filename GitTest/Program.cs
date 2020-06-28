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

    class NullableAtShow
    {
        public void ShowMe()
        {
            double? num1 = null;
            double? num2 = 3.14157;
            double num3;

            num3 = num1 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);

            num3 = num2 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);
            Console.ReadLine();
        }
    }

    class FurnitureDesign
    {
        void DesignBasic()
        {
            Console.WriteLine("The basic design of a new furniture");
            Console.ReadLine();
        }
    }

    class ArrayBasic
    {
        // declare a new array name Degree
        double[] Degree = new Double[5];

        public void GetData()
        {
            Console.WriteLine("Please enter 5 double numbers:");
            //Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Degree[i] = Convert.ToDouble(Console.ReadLine());
                // Console.WriteLine("Show the array of Degree[{0}] is {1}:", i, Degree[i]);
            } 
        }

        public void ShowMe()
        {
            foreach (double d in Degree)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine("Done...");
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            // create a instance of NullableTest class
            NullableTest naTest = new NullableTest();

            // Show the numbers including nullable ones
            naTest.ShowNumber();

            NullableAtShow newShow = new NullableAtShow();

            newShow.ShowMe();
            */

            // create a instace of array of Degree
            ArrayBasic newBasic = new ArrayBasic();
            newBasic.GetData();
            newBasic.ShowMe();

        }
    }
}
