using System;
using System.Collections.Generic;

namespace Episode005
{
    class Program
    {
        static void Main(string[] args)
        {
            #region -- Decleration --
            /*
            int[] numbers = new int[10];
            int[] numbersWithInit = new int[] { 1, 2, 3 };
            int[][] multiNumbers = new int[3][] {
                new int[3] { 1, 2, 3},
                new int[3] { 4, 5, 6},
                new int[3] { 7, 8, 9}
            };
            int[,] otherNumbers = new int[2,2];
            */

            /*
            var numbers = new int[10];
            var numbersWithInit = new int[] { 1, 2, 3 };
            var multiNumbers = new int[3][] {
                new int[3] { 1, 2, 3 },
                new int[3] { 4, 5, 6 },
                new int[3] { 7, 8, 9 }
            };
            */

            #endregion

            #region -- Array Sample --
            /*
            var names = new[] { "frace", "ace", "trunks" };
            Console.WriteLine("Before update");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            names[1] = "hardware";
            Console.WriteLine("After update");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"name at index 2: {names[2]}");
            */

            //Multi-Dimensional
            /*
            var rowsAndCells = new int[3][]{
                new[] { 1, 2, 3 },
                new[] { 4, 5, 6 },
                new[] { 7, 8, 9 }
            };            
            for(var row = 0; row < rowsAndCells.Length; row++)
            {
                Console.WriteLine($"row: {row}");
                foreach(var cell in rowsAndCells[row])
                {
                    Console.WriteLine($"value: {cell}");
                }
            }
            */

            /*
            var numbers = new[] { 1, 2 };
            Console.WriteLine(numbers[3]);
            */

            #endregion

            #region -- Enumerable, Collection and List --

            var countries = new[] { "Philippines", "USA", "Canada", "Pakistan", "Afghanistan" };

            #region -- Enumerable --
            /*
            IEnumerable<string> enumCountries = countries;
            //enumCountries[0] = "PHL";
            Console.WriteLine("Enumerable:");
            foreach(var country in countries)
            {
                Console.WriteLine(country);
            }
            */
            #endregion

            #region -- Collection --
            /*
            ICollection<string> colCountries = new List<string>(countries);
            colCountries.Add("Australia");
            colCountries.Remove("USA");
            Console.WriteLine("*****************");
            //colCountries[0] = "Sample";
            Console.WriteLine("Collection:");
            foreach (var country in colCountries)
            {
                Console.WriteLine(country);
            }
            */
            #endregion

            #region -- List --

            var listCountries = new List<string>(countries); //with initial value from array
            var listInitCountries = new List<string>() //with initial value
            {
                "Philippines",
                "USA"
            };
            var listCountriesNew = new List<string>();
            listCountriesNew.Add("Philippines");
            listCountriesNew.Add("USA");
            listCountriesNew.AddRange(new[] { "Canada", "Australia" });
            listCountriesNew.Remove("Philippines");
            listCountriesNew[0] = "America";
            Console.WriteLine("List of countries");
            for(var index = 0; index < listCountriesNew.Count; index++)
            {
                Console.WriteLine($"{index}:{listCountriesNew[index]}");
            }

            #endregion

            #endregion
        }
    }
}
