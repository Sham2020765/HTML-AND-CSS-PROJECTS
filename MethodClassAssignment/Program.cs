using System;

namespace MethodClassAssignment
{
    // Create a class named MathOperations
    class MathOperations
    {
        // Create a void method that takes two integers as parameters
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // Perform a math operation (multiply by 2) on the first integer
            int result = firstNumber * 2;

            // Display the result of the math operation on the first integer
            Console.WriteLine("Result of math operation on first number: " + result);

            // Display the second integer to the screen as required
            Console.WriteLine("Second number is: " + secondNumber);
        }
    }

    class Program
    {
        // Entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathObj = new MathOperations();

            // Call the method in the class, passing in two numbers positionally
            mathObj.ProcessNumbers(10, 25);

            // Print an empty line to separate the two outputs
            Console.WriteLine();

            // Call the method in the class, specifying the parameters by name
            mathObj.ProcessNumbers(firstNumber: 7, secondNumber: 42);

            // Keep the console window open until the user presses a key
            Console.ReadLine();
        }
    }
}
