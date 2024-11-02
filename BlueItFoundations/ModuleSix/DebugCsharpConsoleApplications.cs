using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BlueItFoundations.ModuleSix
{
    public static class DebugCsharpConsoleApplications
    {
        public static void Init()
        {
            //the errors that occur while the application is running are referred to as exceptions
            //The term "exception handling" refers to the process that a developer uses to manage those runtime exceptions within their code
            //Functional testing -Unit testing - Integration testing - System testing - Acceptance testing
            //Nonfunctional testing - Security testing - Performance testing - Usability testing - Compatibility testing
            //A debugger is a software tool used to observe and control the execution flow of your program with an analytical approach.
            //A conditional breakpoint is a special type of breakpoint that only triggers when a specified condition is met

            try
            {
                // try code block - code that may generate an exception
            }
            catch
            {
                // catch code block - code to handle an exception
            }
            finally
            {
                // finally code block - code to clean up resources
            }

            try
            {
                // Step 1: code execution begins
                try
                {
                    // Step 2: an exception occurs here
                }
                finally
                {
                    // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
                }

            }
            catch // Step 3: the system finds a catch clause that can handle the exception
            {
                // Step 5: the system transfers control to the first line of the catch code block
            }

            double float1 = 3000.0;
            double float2 = 0.0;
            int number1 = 3000;
            int number2 = 0;

            try
            {
                Console.WriteLine(float1 / float2);
                Console.WriteLine(number1 / number2);
            }
            catch
            {
                Console.WriteLine("An exception has been caught");
            }
            Console.WriteLine("Exit program");



            try
            {
                Process1();
            }
            catch
            {
                Console.WriteLine("An exception has occurred");
            }

            Console.WriteLine("Exit program");

            static void Process1()
            {
                try
                {
                    WriteMessage();
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception caught in Process1");
                   // throw;
                }
                
            }

            static void WriteMessage()
            {
                double float1 = 3000.0;
                double float2 = 0.0;
                int number1 = 3000;
                int number2 = 0;

                Console.WriteLine(float1 / float2);
                Console.WriteLine(number1 / number2);
            }

            checked
            {
                try
                {
                    int num1 = int.MaxValue;
                    int num2 = int.MaxValue;
                    int result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
                }
            }

            try
            {
                string? str = null;
                int length = str.Length;
                Console.WriteLine("String Length: " + length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error: The reference is null. " + ex.Message);
            }

            try
            {
                int[] numbers = new int[5];
                numbers[5] = 10;
                Console.WriteLine("Number at index 5: " + numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: Index out of range. " + ex.Message);
            }

            try
            {
                int num3 = 10;
                int num4 = 0;
                int result2 = num3 / num4;
                Console.WriteLine("Result: " + result2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
            }

            Console.WriteLine("Exiting program.");
        }
    }
}
