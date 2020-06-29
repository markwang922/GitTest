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
        int[] Degree = new int[5];

        public void GetData()
        {
            Console.WriteLine("Please enter 5 int numbers:");
            //Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Degree[i] = Convert.ToInt16(Console.ReadLine());
                // Console.WriteLine("Show the array of Degree[{0}] is {1}:", i, Degree[i]);
            }
        }

        public void ShowMe()
        {
            foreach (int d in Degree)
            {
                Console.WriteLine(d);
            }
        }

        private double GetAverage(int[] arr, int n)
        {
            double ave;
            int sum = 0;

            foreach (int d in arr)
            {
                sum += d;
            }

            ave = (double)sum / n;
            return ave;
        }

        public void ShowAverage()
        {
            double average;

            average = GetAverage(Degree, 5);
            Console.WriteLine("The average of this array is {0}", average);
            Console.ReadKey();
        }
    }

    class ArrayParams
    {
        // declare a new array name Degree
        int[] Elements = new int[5];

        public void GetData()
        {
            Console.WriteLine("Please enter 5 int numbers:");
            //Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Elements[i] = Convert.ToInt16(Console.ReadLine());
                // Console.WriteLine("Show the array of Degree[{0}] is {1}:", i, Degree[i]);
            }
        }

        private int GetSummary(params int[] arr)
        {
            int sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }

            return sum;
        }

        public void ShowMe()
        {
            int summary;

            summary = GetSummary(Elements);

            Console.WriteLine("The summary is {0}", summary);
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
            

            // create a instace of array of Degree
            ArrayBasic newBasic = new ArrayBasic();
            newBasic.GetData();
            newBasic.ShowMe();
            newBasic.ShowAverage();

            */

            ArrayParams aTest = new ArrayParams();
            aTest.GetData();
            aTest.ShowMe();
            Console.ReadKey();
        }
    }
}
