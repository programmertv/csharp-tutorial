using System;
using System.Collections.Generic;
using System.Linq;

namespace Episode006
{
    class Program
    {
        static void Main(string[] args)
        {
            #region -- 1st sample --

            /*
            //Print even numbers only
            var numbers = new[] { 5, 6, 2, 9, 1 };

            //Using Loop and If-else
            var evenNumbers = new List<int>();
            foreach(var number in numbers)
            {
                if(number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
            Console.WriteLine("Foreach and If");
            foreach (var even in evenNumbers)
                Console.WriteLine(even);


            //Using LINQ
            var linqEvenNumbers = from number in numbers where number % 2 == 0 select number;
            foreach (var even in linqEvenNumbers)
                Console.WriteLine(even);

            //using Lamda
            var lambdaEvenNumbers = numbers.Where(number => number % 2 == 0);
            foreach (var even in lambdaEvenNumbers)
                Console.WriteLine(even);
            */

            #endregion

            #region -- With Order and Transformation of data --

            /*
            //Print only those numbers less than 9
            //Linq
            var mixedNumbers = new[]{ 3, 5, 6, 9 };
            var linqQuery = from number in mixedNumbers
                            where number < 9
                            orderby number descending
                            select $"numero: {number}";
            Console.WriteLine("LINQ");
            foreach (var num in linqQuery)
                Console.WriteLine(num);

            //Lambda
            Console.WriteLine("**********");
            Console.WriteLine("Lambda");
            var lambdaQuery = mixedNumbers
                                .Where(number => number < 9)
                                .OrderByDescending(number => number)
                                .Select(number => $"numero: {number}");
            foreach (var num in lambdaQuery)
                Console.WriteLine(num);

            */

            #endregion

            #region -- JOINS --

            /*
            var students = new List<Student>() {
                new Student(){ Name = "frace", Age = 32, Grade = 1 },
                new Student(){ Name = "ace", Age = 25, Grade = 3 },
                new Student(){ Name = "trunks", Age = 30, Grade = 1 }
            };
            var sections = new List<Section>() {
                new Section(){ Grade = 1, SectionName = "Section Nemic" },
                new Section(){ Grade = 1, SectionName = "Section land Of Wano" }
            };

            //LINQ
            Console.WriteLine("LINQ");
            var query = from section in sections
                        join student in students on section.Grade equals student.Grade
                        where student.Age > 20
                        orderby student.Age, student.Grade
                        select new
                        {
                            section.SectionName,
                            StudentName = student.Name
                        };
            foreach (var sectionAndStudent in query)
                Console.WriteLine($"Section {sectionAndStudent.SectionName}, Student Name: {sectionAndStudent.StudentName}");

            //Lambda
            Console.WriteLine("*********");
            Console.WriteLine("Lambda");
            var lambdaQuery = sections
                                .Join(
                                    students.Where(student => student.Age > 20),
                                    section => section.Grade,
                                    student => student.Grade,
                                    (section, student) => new
                                    {
                                        section.SectionName,
                                        StudentName = student.Name,
                                        student.Age,
                                        student.Grade
                                    }
                                ).OrderBy(student => student.Age).ThenBy(student => student.Grade);
            foreach (var sectionAndStudent in lambdaQuery)
                Console.WriteLine($"Section {sectionAndStudent.SectionName}, Student Name: {sectionAndStudent.StudentName}");
            */

            #endregion

            #region -- GROUPING --

            
            var students = new List<Student>() {
                new Student(){ Name = "frace", Age = 32, Grade = 1 },
                new Student(){ Name = "ace", Age = 25, Grade = 3 },
                new Student(){ Name = "trunks", Age = 30, Grade = 1 }
            };

            //LINQ
            Console.WriteLine("LINQ");
            var query = from student in students
                        group student by student.Grade into gradeGroup
                        select new GradeCount {
                            Grade = gradeGroup.Key,
                            StudentCount = gradeGroup.Count()
                        };
            foreach (var gradeCount in query)
                Console.WriteLine($"Grade: {gradeCount.Grade}, Count: {gradeCount.StudentCount}");

            //Lambda
            Console.WriteLine("*****");
            Console.WriteLine("Lamda");
            var lambda = students.GroupBy(student => student.Grade, student => student)
                .Select(groupCount =>
                    new GradeCount
                    {
                        Grade = groupCount.Key,
                        StudentCount = groupCount.Count()
                    }
                );
            foreach (var gradeCount in lambda)
                Console.WriteLine($"Grade: {gradeCount.Grade}, Count: {gradeCount.StudentCount}");
            

            #endregion

            #region - Lambda Only

            var numbers = Enumerable.Range(1, 10); //equivalent to {1, 2, 3, 4, 5, 6,7, 8, 9, 10}
            Console.WriteLine(string.Join(",", numbers));

            #region -- Basic Aggregation --

            //Average
            var average = numbers.Average();
            var num1To5Average = numbers.Where(n => n <= 5).Average();
            Console.WriteLine($"Average: {average}, Average 1 to 5: {num1To5Average}");

            //Count or Long Count, use Long Count when expected count is more than int capacity
            var count = numbers.Count();

            //Max and Mix
            var maxNumber = numbers.Max();
            var minNumber = numbers.Min();

            //Sum
            var summation = numbers.Sum();

            Console.WriteLine($"Count: {count}, Max: {maxNumber}, Min: {minNumber}, Sum: {summation}");

            #endregion

            #region -- Conversion --

            var list = new List<int>(numbers);
            var enumValue = list.AsEnumerable(); //converted to enumerable
            var backToList = enumValue.ToList(); //converted back to list

            list = (from number in numbers where number >= 5 select number).ToList();

            #endregion

            #region -- Basic Element Access --

            var firstNumber = numbers.FirstOrDefault();
            var lastNumber = numbers.LastOrDefault();

            var firstEvenNumber = numbers.FirstOrDefault(n => n % 2 == 0);

            var firstWithoutDefault = numbers.First();
            var laststWithoutDefault = numbers.Last();

            #endregion

            #region -- Partitioning --

            var numberSkip5 = numbers.Skip(5);
            var numberSkipWhile = numbers.SkipWhile(n => n < 5);

            var numberTake5 = numbers.Take(5);
            var numbertakeWhile = numbers.TakeWhile(n => n < 5);

            Console.WriteLine($"Skip5: {string.Join(",", numberSkip5)}");
            Console.WriteLine($"SkipWhile: {string.Join(",", numberSkipWhile)}");
            Console.WriteLine($"Take5: {string.Join(",", numberTake5)}");
            Console.WriteLine($"TakeWhile: {string.Join(",", numbertakeWhile)}");

            //Paging approach
            var page = 2;
            var rowsPerPage = 3;
            var pagedNumbers = numbers.Skip(1 * rowsPerPage).Take(rowsPerPage);

            Console.WriteLine($"PagedNumber: {string.Join(",", pagedNumbers)}");

            #endregion

            #region -- Quantifiers --

            var isAll = numbers.All(n => n <= 10);
            var isAny = numbers.Any(n => n == 5);
            var has5 = numbers.Contains(5);

            #endregion

            #region -- SET --

            var repeatedNumbers = new[] { 1, 2, 3, 1, 5, 1, 1, 2 };
            var distinctNumbers = repeatedNumbers.Distinct();

            Console.WriteLine($"Distinct: {string.Join(",", distinctNumbers)}");

            var excludeNumbers = new[] { 5, 6, 7 };
            var newNumbers = numbers.Except(excludeNumbers);
            Console.WriteLine($"Exclude: {string.Join(",", newNumbers)}");

            var checkerNumbers = new int[] { 1, 9, 10, 11, 12 };
            var intersectedNumbers = numbers.Intersect(checkerNumbers);
            Console.WriteLine($"Intersect: {string.Join(",", intersectedNumbers)}");

            var appendNumbers = new[] { 10, 11, 12, 13 };
            var unionNumbers = numbers.Union(appendNumbers);
            Console.WriteLine($"Union: {string.Join(",", unionNumbers)}");

            #endregion

            #endregion

            #region -- Practice using Collection, Select, If, Expression and Operators --
            /*
            var binaries = new[] { "11111111", "01000001", "11110000", "00001111", "00", "11112222", "01010101" };
            const char BINARY_ON = '1';
            const char BINARY_OFF = '0';
            const int MAX_BINARY_BITS_COUNT = 8;
            char[] ALLOWED_BIT_VALUE = new[] { BINARY_ON, BINARY_OFF };
            foreach(var binary in binaries){
                var result = string.Empty;
                if (binary.Length == MAX_BINARY_BITS_COUNT)
                {
                    var binaryValue = 0;
                    foreach(var bit in binary.Reverse().Select((value, index) => new { Value = value, Index = index }))
                    {
                        if (ALLOWED_BIT_VALUE.Contains(bit.Value))
                        {
                            binaryValue += bit.Value == BINARY_ON ? (int)Math.Pow(2, bit.Index) : 0;
                        }
                        else
                        {
                            result = "INVALID";
                            break;
                        }

                        result = binaryValue.ToString();
                    }
                }
                else
                {
                    result = "INVALID";
                }
                Console.WriteLine($"{binary}:{result}");
            }
            */


            #endregion
        }
    }

    #region -- For Demo Purposes Only --

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
    }

    public class Section
    {
        public string SectionName { get; set; }
        public int Grade { get; set; }
    }

    public class GradeCount
    {
        public int Grade { get; set; }
        public int StudentCount { get; set; }
    }

    #endregion
}
