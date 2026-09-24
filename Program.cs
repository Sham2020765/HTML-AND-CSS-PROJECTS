using System;

namespace EmployeeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Instantiate two objects of the Employee class and assign values to their properties.
            
            // Create the first employee object
            Employee employee1 = new Employee()
            {
                Id = 101,
                FirstName = "John",
                LastName = "Doe"
            };

            // Create the second employee object with a matching ID to test equality
            Employee employee2 = new Employee()
            {
                Id = 101,
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Create a third employee object with a different ID to test inequality
            Employee employee3 = new Employee()
            {
                Id = 102,
                FirstName = "Alice",
                LastName = "Johnson"
            };

            // Display employee details in the console
            Console.WriteLine($"Employee 1: ID = {employee1.Id}, Name = {employee1.FirstName} {employee1.LastName}");
            Console.WriteLine($"Employee 2: ID = {employee2.Id}, Name = {employee2.FirstName} {employee2.LastName}");
            Console.WriteLine($"Employee 3: ID = {employee3.Id}, Name = {employee3.FirstName} {employee3.LastName}");
            Console.WriteLine(new string('-', 50));

            // Compare employee1 and employee2 using the overloaded '==' operator
            Console.WriteLine("Comparing Employee 1 and Employee 2 using '==':");
            if (employee1 == employee2)
            {
                Console.WriteLine("Result: The employees are EQUAL (IDs match).");
            }
            else
            {
                Console.WriteLine("Result: The employees are NOT EQUAL.");
            }

            Console.WriteLine(); // Blank line for spacing

            // Compare employee1 and employee3 using the overloaded '!=' operator
            Console.WriteLine("Comparing Employee 1 and Employee 3 using '!=':");
            if (employee1 != employee3)
            {
                Console.WriteLine("Result: The employees are NOT EQUAL (IDs are different).");
            }
            else
            {
                Console.WriteLine("Result: The employees are EQUAL.");
            }

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
