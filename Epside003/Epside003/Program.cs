using System;

namespace Epside003
{
    class Program
    {
        static void Main(string[] args)
        {
            #region -- Inputs --

            #region -- Write --
            /*
            Console.Write($"a{Environment.NewLine}");
            Console.Write("b\n");

            Console.WriteLine("c");
            Console.WriteLine("d");
            */
            #endregion

            #region -- Read --

            //var stringValue = Console.ReadLine();
            //Console.WriteLine($"Inputted value: {stringValue}");

            //var readTest = Console.Read();
            //Console.WriteLine(readTest);
            
            /*Console.Write("Input your age: ");
            var ageString = Console.ReadLine();
            var age = int.Parse(ageString);
            Console.WriteLine(age < 18 ? "minor" : "adult");
            */
            /*if (age < 18)
                Console.WriteLine("minor");
            else
                Console.WriteLine("adult");
            */
            #endregion

            #endregion

            #region -- Expressions & Operators --

            #region -- Assigment Operator --

            var a = 5;
            a = 10;

            #endregion

            #region -- Arithmetic Operators --

            //Addition
            var num1 = 3;
            var num2 = 7;
            var num1And2Result = num1 + num2;
            num1And2Result = num1 + num2 + 100 + 10;

            //Subtraction
            var sub1 = 100;
            var sub2 = 90;
            var subResult = sub1 - sub2;

            //Multiplication
            var mul1 = 10;
            var mul2 = 10;
            var mulResult = mul1 * mul2;

            //Division
            var div1 = 10;
            var div2 = 10;
            var divResult = div1 / div2;

            //modulus
            var mod1 = 9;
            var mod2 = 5;
            var modResult = mod1 % mod2;

            //precedence : (), [], ++, --, *, /, %, +, -
            var samplePrecedence = (1 + 1) * 5 + 2 / 2 - 10 + 3;
            Console.WriteLine(samplePrecedence);

            #endregion

            #region -- Boolean Operators --

            var isActive = true;
            var isSuspended = false;

            var testAnd = isActive && isSuspended;
            var testOr = isActive || isSuspended;

            //Equality
            var eq1 = 100;
            var eq2 = 90;

            var testEq = eq1 == eq2;
            var testNotEq = eq1 != eq2;

            var testGreaterThan = eq1 > eq2;
            var testLessThan = eq1 < eq2;

            var testGreaterThanOrEqual = eq1 >= eq2;
            var testLessThanOrEqual = eq1 <= eq2;

            #endregion

            #region Null-Coalescing

            var sampleString = "may laman";
            string nullNaString = null;

            var sampleResult1 = sampleString ?? "nilagyan nang lamam";
            var samppleResult2 = nullNaString ?? "nilagyan nang laman";

            Console.WriteLine(sampleResult1);
            Console.WriteLine(samppleResult2);

            #endregion

            #region -- Unary --

            var trueValue = true;
            trueValue = !trueValue;

            var numberIncrementDecrement = 10;
            Console.WriteLine("Post Increment");
            //equivalent to: numberIncrementDecrement = numberIncrementDecrement + 1;
            Console.WriteLine(numberIncrementDecrement++);
            //equivalent to: numberIncrementDecrement = numberIncrementDecrement - 1;
            Console.WriteLine(numberIncrementDecrement--);

            numberIncrementDecrement = 10;
            Console.WriteLine("Pre Increment");
            //post incr and decr
            Console.WriteLine(++numberIncrementDecrement);
            Console.WriteLine(--numberIncrementDecrement);

            #endregion

            #region -- Ternary --

            var sampleStringTernary = "frace";
            var result = sampleStringTernary == "frace" ? "programmertv" : "??unknown??";

            Console.WriteLine(result);

            #endregion

            #endregion

            //Closing: Inputs + Expressions + Operators
            //Sample: pyhagorean theorem
            //Formula to get C: c = square root of (a square + b square)

            //Inputs is a and b
            //Output is c

            Console.WriteLine("Input a value: ");
            var formulaA = double.Parse(Console.ReadLine());
            Console.WriteLine("Input b value: ");
            var formulaB = double.Parse(Console.ReadLine());

            var formulaResult = Math.Sqrt(Math.Pow(formulaA, 2) + Math.Pow(formulaB, 2));
            Console.WriteLine($"Sample C result: {formulaResult}");

        }
    }
}
