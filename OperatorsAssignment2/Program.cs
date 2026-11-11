using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the first Employee object and assign values to its properties
            Employee employee1 = new Employee
            {
                Id = 101,
                FirstName = "Sarah",
                LastName = "Connor"
            };

            // Instantiate the second Employee object with the same Id to test equality
            Employee employee2 = new Employee
            {
                Id = 101,
                FirstName = "John",
                LastName = "Doe"
            };

            // Compare the two Employee objects using the overloaded '==' operator
            bool areEqual = (employee1 == employee2);
            Console.WriteLine($"Are employee1 and employee2 equal (==)? {areEqual}");

            // Compare the two Employee objects using the overloaded '!=' operator
            bool areNotEqual = (employee1 != employee2);
            Console.WriteLine($"Are employee1 and employee2 not equal (!=)? {areNotEqual}");

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}
