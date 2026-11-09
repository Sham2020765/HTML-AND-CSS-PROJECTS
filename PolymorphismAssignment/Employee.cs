using System;

namespace PolymorphismAssignment
{
    // Inherit from the IQuittable interface
    public class Employee : IQuittable
    {
        // Properties to store the employee's first and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method to display the employee's full name
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }

        // Implement the Quit() method required by the IQuittable interface
        public void Quit()
        {
            // Print a message to the console indicating the employee has quit
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }
}  
