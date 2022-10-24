using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //DONE TODO: Print the Sum of numbers
            Console.WriteLine(numbers.Sum());
            //DONE TODO: Print the Average of numbers
            
            Console.WriteLine(numbers.Average());
            //DONE TODO: Order numbers in ascending order and print to the console
            var ascOrder = numbers.OrderBy(x => x);
            Console.WriteLine("------------------------");
            foreach (var number in ascOrder)
            { 
                Console.WriteLine(number);
            }
            //DONE TODO: Order numbers in decsending order and print to the console
            var descOrder = numbers.OrderByDescending(x => x);
            Console.WriteLine("------------------------");
            foreach (var number in descOrder)
            {
                Console.WriteLine(number);
            }

            //DONE TODO: Print to the console only the numbers greater than 6
            var grThanSix = numbers.Where(num => num > 6);
            Console.WriteLine("------------------------");
            foreach (var number in grThanSix)
            { 
                Console.WriteLine(number);
            }
            //DONE TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("------------------------");
            foreach (var numb in descOrder.Take(4))
            { 
                Console.WriteLine(numb);
            }
            //DONETODO: Change the value at index 4 to your age, then print the numbers in decsending order
            numbers.SetValue(53, 4);
            var descWithAge = numbers.OrderByDescending(num => num);
            Console.WriteLine("------------------------");
            foreach (var numb in descWithAge)
            {
                Console.WriteLine(numb);
            }
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //DONE TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var firstFilt = employees.Where(person => person.FirstName.ToLower().StartsWith('c') || person.FirstName.ToLower()[0] == 's').OrderBy(person => person.FirstName);
            Console.WriteLine("--------------------");
            foreach (var person in firstFilt)
            {
                Console.WriteLine(person.FullName);
            }
            //DONE TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var twentySix = employees.Where(x => x.Age > 26).OrderByDescending(x => x.Age).ThenBy(x => x.FirstName);
            Console.WriteLine("--------------------");
            foreach (var item in twentySix)
            {
                Console.WriteLine($"Name: {item.FullName}, Age: {item.Age}");
            }

            //DONE TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var sumAndYear = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            Console.WriteLine("--------------------");
            Console.WriteLine($"Total YOE:{sumAndYear.Sum(x => x.YearsOfExperience)}");
            Console.WriteLine($"Average YOE:{ sumAndYear.Average(x => x.YearsOfExperience)}");

            //DONE TODO: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("Robert", "Steele", 53, 11)).ToList();
            Console.WriteLine("--------------------");
            foreach (var item in employees)
            { 
                Console.WriteLine(item.FullName); 
            }

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
