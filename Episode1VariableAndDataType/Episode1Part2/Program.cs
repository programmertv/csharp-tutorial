using System;

namespace Episode1Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region -- About Variables --

            #region -- Local Variables --
            //Local variables
            //explicit
            int sampleNumber = 3;
            //implicit
            var sampleNumberImplicit = 3;
            dynamic sampleNumberDynamic = 5;

            #endregion

            #region -- Class & Instance Variables --

            //Instance Variable
            var episode1 = new Episode1Class();
            Console.WriteLine(episode1.samplePublicInt);
            episode1.samplePublicInt = 250;
            Console.WriteLine(episode1.samplePublicInt);

            //Class or Static Variable
            Console.WriteLine("***************");
            Console.WriteLine(Episode1Class.sampleStaticOrClassVariableInt);
            Episode1Class.sampleStaticOrClassVariableInt = 200;
            Console.WriteLine(Episode1Class.sampleStaticOrClassVariableInt);

            #endregion

            #endregion

            #region -- About Datatypes --

            #region **** Parse & Convert ****

            //Parse & Convert
            string textOne = "5";
            var intOne = int.Parse(textOne);
            var result = intOne * 5;
            Console.WriteLine($"(Parse)Text One result: {result}");

            string textTwo = "999";
            int intTwo;
            int.TryParse(textTwo, out intTwo);
            Console.WriteLine($"Result Two using TryParse: {intTwo}");

            string textThree = ":)";
            int intThree;
            if(int.TryParse(textThree, out intThree))
            {
                Console.WriteLine($"Result Three using TryParse: {intThree}");
            }
            else
            {
                Console.WriteLine($"Hindi naman number yung {textThree} ah?");
            }

            //Inline variable decleration
            string textFour = "**TEST**";
            if (int.TryParse(textThree, out int intFour))
            {
                Console.WriteLine($"Result Four using TryParse: {intFour}");
            }
            else
            {
                Console.WriteLine($"Hindi naman number yung {textFour} ah?");
            }

            var intConverted = Convert.ToInt32(textOne);
            result = intConverted * 5;
            Console.WriteLine($"(Convert)Text One result: {result}");

            #endregion

            #region *** Casting / Converting ***

            //Casting
            var childOne = new SampleChild();
            var amponOne = new SampleAmpon();
            var sampleParent = (SampleParent)childOne;

            var sampleInt = 10000;
            var sampleLong = (int)sampleInt;

            //Conversion
            var testChild = childOne as SampleParent;
            //var testAmpon = amponOne as SampleParent;
            //when to use "as" keyword ?
            object sampleObject = new { TestingNaProperty = "Sample Lang" };
            dynamic testDynamic = new { GayagayaLangNaProperty = "Pan Test Lang" };
            var testObjectParent = sampleObject as SampleParent;
            var testDynamicParent = testDynamic as SampleParent;

            object sampleObjectUsingParentClass = new SampleParent() { LastName = "test name" };
            var testObjectUsingParent = sampleObjectUsingParentClass as SampleParent;

            Console.WriteLine($"Lastname: {testObjectUsingParent.LastName}");

            //Pattern Matching
            if(sampleObjectUsingParentClass is SampleParent)
            {
                //Do Something here...
            }
            else
            {
                //Do Nothing :)
            }

            //Pattern Matching with Inline Variable decleration
            if(sampleObjectUsingParentClass is SampleParent sampleResult)
            {
                Console.WriteLine(sampleResult.LastName);
            }

            //Old Version without using Patter matching -- Pang matandang style ito
            var testObjectUsingParentUlitLang = sampleObjectUsingParentClass as SampleParent;
            if(testObjectUsingParentUlitLang != null)
            {
                Console.WriteLine(testObjectUsingParentUlitLang.LastName);
            }

            #endregion

            #endregion
        }
    }

    #region -- Demo Class --

    public class Episode1Class
    {
        public static int sampleStaticOrClassVariableInt = 3;

        public int samplePublicInt = 500;
        private int samplePrivateInt = 100;

        #region -- Fields --

        int sampleFieldInt = 5;
        static int sampleStaticInt = 6;

        readonly long sampleLong;
        readonly long sampleLong2 = 10;

        const int sampleIntNaConst = 150;
        const float mathPI = 3.14F;

        #endregion

        public Episode1Class()
        {
            sampleLong = 500;
            sampleLong2 = 100;
        }

        public void SampleMethod1()
        {
            int sampleLocalInt = 1;
            var sampleLocalDouble = 1.5;
            sampleFieldInt = 0;
            sampleStaticInt = 0;
        }

        public void SampleMethod2()
        {
            int sample2Int = 1;
            sampleFieldInt = 0;
            sampleStaticInt = 0;
        }

        public static void SampleStaticMethod1()
        {
            sampleStaticInt = 0;
        }
    }

    #endregion

    #region Sample Class for Casting and Converting

    public class SampleParent
    {
        public string LastName { get; set; }
    }

    public class SampleChild: SampleParent { }

    public class SampleAmpon { }

    #endregion
}
