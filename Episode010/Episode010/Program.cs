using System;
using System.Collections.Generic;
using System.Linq;

namespace Episode010
{
    public class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.FirstChanceException += (sender, args) =>
            {
                if(args.Exception is WalangFirstNameException)
                {
                    Console.WriteLine("(From Event)nagaka-error na WalangFirstNameException");
                }
            };
            #region -- Debugging Demo --
            /*
            var binary1 = "00001111"; //15
            var binary2 = "01000001"; //65

            var firstBits = GetBitValues(binary1);
            var secondBits = GetBitValues(binary2);

            Console.WriteLine($"binary1: {binary1}, {string.Join(",", firstBits)}: {firstBits.Sum()}");
            Console.WriteLine($"binary2: {binary2}, {string.Join(",", secondBits)}: {secondBits.Sum()}");

            */

            #endregion
            #region Error/Exception Handling Demo --
            #region -- First Exception --
            /*
            var number1 = 100;
            var number2 = 50;
            var number3 = 0;
            try
            {
                Console.WriteLine($"Addition result: {number1 + number2}");
                Console.WriteLine($"Addition result: {number1 / number3}");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Hindi pwde mag divide by zero.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally! tapos na yung try and catch.");
            }
            */


            #endregion  
            try
            {
                string firstName = null;
                string lastName = "ProgrammerTV";

                if (string.IsNullOrWhiteSpace(firstName))
                    throw new WalangFirstNameException();

                Console.WriteLine(firstName.ToLower());
                Console.WriteLine(lastName.ToLower());
            }
            catch(WalangFirstNameException ex)
            {
                Console.WriteLine("Walang first name");
                //throw;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Hindi pwde mag gamit nang function pag null");
            }
            catch
            {
                Console.WriteLine("Ako bahala sa ibang exceptions");
            }

            #endregion
        }

        #region -- Debugging Demo --

        public static IEnumerable<int> GetBitValues(string binaryValue)
        {
            return binaryValue
                .Reverse()
                .Select((value, index) => {

                    return value == '1' ? (int)Math.Pow(2, index) : 0;
                })
                .Reverse();
        }

        #endregion
    }
}

public class SampleClassOne
{
    public void SampleFunctionCaller()
    {
        try
        {
            var other = new OtherClass();
            other.TestFunction();
            //Mag Celebrate
        }
        catch {
            //Mag luksa
        }
    }
}

public class OtherClass
{
    public void TestFunction()
    {
        try
        {
            throw new Exception("Forced error!");
        }
        catch { }
    }
}

