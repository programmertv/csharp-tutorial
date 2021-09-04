using System;
using System.Linq;
using System.Text;

namespace Episode007
{
    class Program
    {
        static void Main(string[] args)
        {
            #region -- String --

            #region -- Initial Demo --
            /*
            string sampleString;
            string sampleStringWithNullValue = null;
            String stringUsingClass = "Test";

            var myName = "frace"; //regular string literal
            myName += " marteja"; //equivalent to: myName = myName + " marteja";
            Console.WriteLine("print by characters using loop");
            foreach(var c in myName)
            {
                Console.Write(c);
            }
            char[] nameCharacters = myName.ToCharArray();
            var stringFromArray = new string(nameCharacters);

            //verbatim string literal
            var stringWithSpecialCharacter = @"""test\only""";
            var stringMultipleLines = @"f
                                        r
                                        a
                                        c
                                        e";
            Console.WriteLine(stringWithSpecialCharacter);
            Console.WriteLine(stringMultipleLines);
            */

            //String Esacpe sequence
            //var stringWithTabAndNewLine = "my\tname\tis:\nFrace";
            //Console.WriteLine(stringWithTabAndNewLine);

            #endregion

            /*
            //Immutable issue
            var testString = "number";
            for(var number = 1; number <= 5; number++)
            {
                testString += number;
            }
            Console.WriteLine("Using normal concatenation");
            Console.WriteLine(testString);

            var sb = new StringBuilder();
            sb.Append("number");
            for (var number = 1; number <= 5; number++)
            {
                sb.Append(number.ToString());
            }
            Console.WriteLine("using StringBuilder");
            Console.WriteLine(sb.ToString());

            */

            /*
                Numeric Standard Formatting
                C = Currency                
                N = Number
                P = Percent

                D = Decimal
             */
            /*
            var myNumeric = 12345.678D;
            Console.WriteLine(myNumeric.ToString("C"));
            Console.WriteLine(myNumeric.ToString("N"));
            Console.WriteLine(myNumeric.ToString("P"));

            var myNumber = 123;
            Console.WriteLine(myNumber.ToString("D10"));

            Console.WriteLine("Number with 2 decimal places only");
            Console.WriteLine(myNumeric.ToString("N2"));

            Console.WriteLine("Custom");
            Console.WriteLine(myNumeric.ToString("PHP#,##0.00"));
            */

            /*
            //String format and interpolation
            var name = "farce";
            var age = 32;
            var sampleMoney = 54321.12345D;

            //using string.Format
            Console.WriteLine("Using String.Format");
            var stringOutput = string.Format("my name: {0}, age: {1}, sample computation: {2}", name, age, 1 + 1);
            Console.WriteLine(stringOutput);
            Console.WriteLine(string.Format("{0:C}", sampleMoney));

            //interpolation
            Console.WriteLine("Using Interpolation");
            var stringOutputv2 = $"my name: {name}, age: {age}, sample computation: {1 + 1}";
            Console.WriteLine(stringOutputv2);
            Console.WriteLine($"{sampleMoney:C}");
            */

            //Checker
            /*
            string firstString = null;
            var secondString = string.Empty; // equivalent to string secondString = "";
            var thirdString = " ";
            if (firstString == null)
                Console.WriteLine("firstString is Null");

            //version 1
            if (secondString != null && secondString != string.Empty)
                Console.WriteLine("secondString is not Null");
            else
                Console.WriteLine("secondString ois empty");

            //version 2
            if (!string.IsNullOrEmpty(secondString))
                Console.WriteLine("V2: secondString is not Null");
            else
                Console.WriteLine("V2: secondString is empty");

            //check string that is NULL, empty or blank (white spaces only)
            if (string.IsNullOrWhiteSpace(thirdString))
                Console.WriteLine("thirdString is: NULL, EMPTY or BLANK");

            */

            /*
            //Common checker functions
            var myNameForChecker = "frace";
            if (myNameForChecker.StartsWith("fr"))
                Console.WriteLine("frace starts with fr");
            if (myNameForChecker.EndsWith("e"))
                Console.WriteLine("frace ends with e");
            if (myNameForChecker.Contains("ac"))
                Console.WriteLine("frace contains with ac");

            if (myNameForChecker == "Frace")
                Console.WriteLine("frace is equal to Frace");
            else
                Console.WriteLine("frace is \"NOT\" equal to Frace");

            //Igone case
            if(myNameForChecker.Equals("Frace", StringComparison.InvariantCultureIgnoreCase))
                Console.WriteLine("(Ignored Case) frace is equal to Frace");
            else
                Console.WriteLine("(Ignored Case) frace is \"NOT\" equal to Frace");
            */

            /*
            //Commonly used manipulation in string
            var myString = "programmerTV";
            Console.WriteLine(myString);
            Console.WriteLine($"reverse: {new string(myString.Reverse().ToArray())}");
            Console.WriteLine($"replace: {myString.Replace("TV", "Tutorial Video")}");
            Console.WriteLine($"substring: {myString.Substring(3, 7)}");
            Console.WriteLine($"lower case: {myString.ToLower()}");
            Console.WriteLine($"upper case: {myString.ToUpper()}");

            var anotherString = "  fra ce  ";
            Console.WriteLine($"trim start: '{anotherString.TrimStart(' ')}'");
            Console.WriteLine($"trim end: '{anotherString.TrimEnd(' ')}'");
            Console.WriteLine($"trim start and end: '{anotherString.Trim(' ')}'");
            Console.WriteLine($"trim start and end and replace: '{anotherString.Trim(' ').Replace(" ", string.Empty)}'");

            var lastString = "frace-marteja-programmer-TV:String";
            Console.WriteLine(lastString);
            var words = lastString.Split('-');            
            Console.WriteLine("===Words===");
            foreach (var word in words)
                Console.WriteLine(word);

            var wordsWithMultipleSeparator = lastString.Split(new char[] { '-', ':' });
            Console.WriteLine("===Words with Multiple Separator - and : ===");
            foreach (var word in wordsWithMultipleSeparator)
                Console.WriteLine(word);

            Console.WriteLine(string.Join("*", wordsWithMultipleSeparator));


            */

            #endregion

            #region -- DateTime --

            /*
            var now = DateTime.Now;
            var today = DateTime.Today;
            var timeNow = now.TimeOfDay;
            var dateNow = now.Date;

            Console.WriteLine($"Now: {now}");
            Console.WriteLine($"Today: {today}");
            Console.WriteLine($"Time now: {timeNow}");
            Console.WriteLine($"Date now: {dateNow}");

            var myDate = new DateTime(2020, 12, 25);
            Console.WriteLine($"My Date: {myDate}");
            //Formatting:
            Console.WriteLine($"Formatted: {myDate:MMM dd, yyyy}");
            //Computation
            var yesterday = now.AddDays(-1);
            var tomorrow = now.AddDays(1);
            var days = now.Subtract(myDate).Days;
            Console.WriteLine($"yesterday: {yesterday.ToString("MM/dd/yyyy")}");
            Console.WriteLine($"yesterday: {tomorrow:MM/dd/yyyy}");
            Console.WriteLine($"now - myDate (number of days): {days}");

            //For Universal - Will discuss this on advance topics
            var utcNow = DateTime.UtcNow;
            Console.WriteLine(utcNow);

            */

            #endregion

            #region -- Nullable --
            
            string myString = null;
            Nullable<int> myNumber = null;
            int? secondnullableInt = null;

            //"Nullable" is equivalen to "Optional". Meaning, our int varaibles are now optionals 
            //version 1
            if(myNumber != null)
            {
                Console.WriteLine("myNumber is not null");
            }
            else
            {
                Console.WriteLine("myNumber is NULL");
            }

            secondnullableInt = 3;
            //version 2
            if (myNumber.HasValue || secondnullableInt.HasValue)
                Console.WriteLine(secondnullableInt.Value);
            
            #endregion

            #region -- Enumeration (enum) --
            
            var boyGender = Gender.Male;
            Console.WriteLine($"gender: {boyGender}, gender value: {(int)boyGender}");
            switch (boyGender)
            {
                case Gender.Male:
                    Console.WriteLine("Male");
                    break;
                case Gender.Female:
                    Console.WriteLine("Female");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }
            var value = 1;
            Gender genderFromValue = (Gender)value;
            var stringValue = "Male";
            Gender genderFromString = (Gender)Enum.Parse(typeof(Gender), stringValue);
            Console.WriteLine($"gender from int: {genderFromValue}");
            Console.WriteLine($"gender from String: {genderFromString}");
            


            #endregion
        }
    }

    #region -- Normal Enum --

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public enum SampleQuarterInMonths
    {
        First = 3,
        Second = 6,
        Third = 9,
        Fourth = 12
    }

    public enum SampleThatStartAt5
    {
        Usa = 5,
        Duwa,
        Tulo
    }

    #endregion
}
