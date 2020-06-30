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

    class MyArray
    {
        public int[] AcceptData()
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            // int[] temp = list;
            return list;
        }

        public void ShowOriginal(params int[] myList)
        {
            Console.Write("Original Array: ");

            foreach (int i in myList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public void ShowReverse(params int[] myTemp)
        {
            // reverse the array
            Array.Reverse(myTemp);
            Console.Write("Reversed Array: ");

            foreach (int i in myTemp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public void ShowSorted(params int[] mySort)
        {
            //sort the array
            Array.Sort(mySort);
            Console.Write("Sorted Array: ");

            foreach (int i in mySort)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }

    class MyString
    {
        public void ShowString()
        {
            //from string literal and string concatenation
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };

            string fullname = fname + " " + lname;
            Console.WriteLine("Full Name: {0}", fullname);

            //by using string constructor { 'H', 'e', 'l', 'l','o' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            //methods returning string { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            //formatting method to convert a value
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);
        }

        public string AcceptData()
        {
            string aMessage;

            Console.WriteLine("Please enter the message:");
            aMessage = Console.ReadLine();

            return aMessage;
        }

        public void CompareMessage(string imessage, string jmessage)
        {
            if (String.Compare(imessage, jmessage) == 0)
            {
                Console.WriteLine(imessage + " and " + jmessage + " are equal.");
            }
            else
            {
                Console.WriteLine(imessage + " and " + jmessage + " are not equal.");
            }
        }

        // Check whether word existed in a message or not
        public void ContainWord(string cMessage, string wMessage)
        {
            if (cMessage.Contains(wMessage))
            {
                Console.WriteLine("'{0}' exists in '{1}'.", wMessage, cMessage);
            }
            else
            {
                Console.WriteLine("'{0}' does not exist in '{1}'.", wMessage, cMessage);
            }
        }

        // Get the substring from message
        public string GetSubMessage(string sMessage, int n)
        {
            string subString;

            subString = sMessage.Substring(n);

            return subString;
        }

        // Join messages
        public string JoinMessage()
        {
            string[] starray = new string[]{"Down the way nights are dark",
            "And the sun shines daily on the mountain top",
            "I took a trip on a sailing ship",
            "And when I reached Jamaica",
            "I made a stop"};

            string jMessage = String.Join("\n", starray);

            return jMessage;
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


            ArrayParams aTest = new ArrayParams();
            aTest.GetData();
            aTest.ShowMe();
            Console.ReadKey();

            int[] Test;

            MyArray newMyArray = new MyArray();
            Test = newMyArray.AcceptData();
            newMyArray.ShowOriginal(Test);
            newMyArray.ShowReverse(Test);
            newMyArray.ShowSorted(Test);

            */

            int n;
            string aTest, bTest;
            string testWord = "test";

            MyString newString = new MyString();
            // newString.ShowString();

            aTest = newString.AcceptData();
            bTest = newString.AcceptData();

            // compare these 2 messages and get the results
            newString.CompareMessage(aTest, bTest);

            // check whether testwork existed in these 2 message
            newString.ContainWord(aTest, testWord);
            newString.ContainWord(bTest, testWord);

            n = 15;

            string subTest1, subTest2;

            subTest1 = newString.GetSubMessage(aTest, n);
            Console.WriteLine(subTest1);

            subTest2 = newString.GetSubMessage(bTest, n);
            Console.WriteLine(subTest2);

            string joinTest;

            joinTest = newString.JoinMessage();
            Console.WriteLine(joinTest);

            Console.ReadKey();
        }
    }
}
