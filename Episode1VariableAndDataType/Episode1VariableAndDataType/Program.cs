using System;

namespace Episode1VariableAndDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            //With or Without variable
            WalangVariable();
            MayroongVariable();

            //Principles
            SimpleNoKISSAndKISS();
            SimpleNoDAMPAndDAMP();
            SimpleWETAndDRY();

            //syntax: <datatype> <variable1,varibale2,variable3...variableN>
            int m1 = 2, m2 = 4, m3; //Multiple

            //single per line
            int s1 = 2;
            int s2 = 4;
            int s3;

            //Variable and Data Type
            int num1 = 100; // explicit typed
            var num2 = 500; //implicity typed
            var num3 = num1; 
            num3 = 9000;
            var class1 = new DemoClass()
            {
                Value = 100
            };
            var class2 = new DemoClass()
            {
                Value = 500
            };
            var class3 = class1;
            class3.Value = 9000;


            bool trueVal = true;
            bool falseVal = false;
            char charA = 'A';
            string nullString;
            string stringWithValue = "test";

            float floatA = 1.2F;
            double doubleA = 1.2D;
            doubleA = floatA;
            var floatAndDouble = floatA + doubleA;

            decimal decimalA = 1.2M;

            short shortA = 1;
            int intA = 1;
            long longA = 1;

            intA = shortA;
            longA = intA;

            var intAndLong = intA + longA;

        }

        #region -- Without Variable --

        static void WalangVariable()
        {
            Console.WriteLine("Walang Variable");

            Console.WriteLine("Hello Pro Grammer TV!");
            Console.WriteLine("Bye Pro Grammer TV!");
        }

        #endregion

        #region -- With Variable --

        static void MayroongVariable()
        {
            string channelName = "Programmer TV";

            PrintSeparator();
            Console.WriteLine("Mayroong Variable");
            Console.WriteLine("Hello " + channelName + "!");
            Console.WriteLine("Bye " + channelName + "!");

            #region -- Para sa mga Kritiko --

            #region -- Using String.Format --

            PrintSeparator();
            Console.WriteLine("(Kritiko) Style 1");
            Console.WriteLine(string.Format("Hello {0}!", channelName));
            Console.WriteLine(string.Format("Bye {0}!", channelName));

            #endregion

            #region -- Using String.Format --

            PrintSeparator();
            Console.WriteLine("(Kritiko) Style 2");
            Console.WriteLine($"Hello {channelName}!");
            Console.WriteLine($"Bye {channelName}!");

            #endregion

            #endregion
        }

        #endregion

        static void SimpleNoKISSAndKISS()
        {
            PrintSeparator();
            Console.WriteLine("KISS");

            //NO KISS
            int sampleNumber = 100;
            string numberString = ConverToString(sampleNumber);
            Console.WriteLine(sampleNumber);

            string ConverToString(int number)
            {
                return number.ToString();
            }

            //With KISS
            int sampleNumberWithKISS = 100;
            Console.WriteLine(sampleNumberWithKISS);
        }

        static void SimpleNoDAMPAndDAMP()
        {
            PrintSeparator();
            Console.WriteLine("DAMP");
            //Violated yung DAMP principle kasi di natin malalaman kung ano ibig sabihin nang variable na 'a'
            var a = 10;
            Console.WriteLine($"Number of Apples: {a}");

            //Now, mas descriptive na ung variable name natin tapos alam na natin kung ano purpose nang variable
            var numberOfApples = 10;
            Console.WriteLine($"Number of Apples: {numberOfApples}");
        }

        static void SimpleWETAndDRY()
        {
            PrintSeparator();
            Console.WriteLine("WET");
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;
            int f = 6;

            #region -- WET Principle --
            //(generalize @ n > 2)

            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"c + d = {c + d}");
            //Violated na dito na part yung WET principle dahil more than 2 times ka nag repeat nang same process
            Console.WriteLine("Violated WET");
            Console.WriteLine($"d + e = {c + d}");

            #endregion

            Console.WriteLine("DRY");
            //Gumamit nang DRY Principle para di mo maviolate ung WET Principle
            AddAndPrint("a + b", a, b);
            AddAndPrint("c + d", c, d);
            AddAndPrint("e + f", e, f);
            void AddAndPrint(string text, int firstNum, int secondNum)
            {
                Console.WriteLine($"{text} = {firstNum + secondNum}");
            }
        }


        //Utils
        static void PrintSeparator()
        {
            Console.WriteLine("*******************************");
        }
    }

    #region -- Test Class (class will be discuss separately) --


    public class DemoClass
    {
        public int Value { get; set; }
    }

    #endregion
}
