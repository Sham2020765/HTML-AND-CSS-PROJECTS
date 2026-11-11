using System;

namespace OperatorsAssignment
{
    // Define the Employee class
    public class Employee
    {
        // Properties to store employee details
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the '==' operator to compare two Employee objects by their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both objects point to the same memory reference or are both null
            if (ReferenceEquals(emp1, emp2))
                return true;

            // Check if either object is null
            if (emp1 is null || emp2 is null)
                return false;

            // Return true if their Id properties match, otherwise false
            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator (comparison operators must be overloaded in pairs)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the opposite result of the '==' operator
            return !(emp1 == emp2);
        }

        // Override Equals() to match the overloaded '==' operator and prevent compiler warnings
        public override bool Equals(object obj)
        {
            if (obj is Employee otherEmployee)
            {
                return this.Id == otherEmployee.Id;
            }
            return false;
        }

        // Override GetHashCode() as required when Equals() is overridden
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
