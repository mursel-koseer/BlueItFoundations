using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BlueItFoundations.ModuleOne
{
    public static class WriteYourFirstCodeUsing
    {
        public static void Init()
        {
            Console.WriteLine("Hello World!");

            Console.Write("Congratulations!");
            Console.Write(" ");
            Console.Write("You wrote your first lines of code.");

            Console.WriteLine("Congratulations!");
            Console.Write("You wrote your first lines of code.");

            //Console.WriteLine("Hello World!"); "Hello World!" => literal string.
            //Console.WriteLine("Hello World!"); The dot between the class and method is the member access operator.
            //Console.WriteLine("Hello World!"); The parentheses of the method () is called method invocation operator. 

            Console.WriteLine(" ");
            Console.WriteLine("This is the first line.");
            Console.WriteLine("This is the second line.");

            Console.WriteLine(" ");
            Console.WriteLine('b');
            Console.WriteLine(123);

            //Float Type    Precision
            //----------------------------
            //float         ~6 - 9 digits
            //double        ~15 - 17 digits
            //decimal        28 - 29 digits

            Console.WriteLine(0.251111111111111111111111111111111F); // outputs max 9 digits.
            Console.WriteLine(2.625555555555555555555555555555555555555555555555555555555555555555555555); //Default float type is double with max 17 digits.
            Console.WriteLine(12.39816888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888m); // outputs max 29 digits for decimal


            //These are bool literals
            Console.WriteLine(true);
            Console.WriteLine(false);


            //These appears the same
            Console.WriteLine("123");
            Console.WriteLine(123);

            Console.WriteLine("true");
            Console.WriteLine(true);


            //A variable is a container for storing a type of value
            //string firstName;

            //Variable names should use camel case
            string thisIsCamelCase;

            char userOption;

            int gameScore;

            decimal particlesPerMillion;

            bool processedCustomer;


            string firstName;
            firstName = "Bob";
            Console.WriteLine(firstName);
            firstName = "Liem";
            Console.WriteLine(firstName);
            firstName = "Isabella";
            Console.WriteLine(firstName);
            firstName = "Yasmin";
            Console.WriteLine(firstName);

            //implicitly typed local variables
            var message = "Hello world!";


            Console.Write("Hello, Bob! ");
            Console.Write("You have ");

            int messagesCount = 3;
            Console.Write(messagesCount);
            Console.Write(" ");
            Console.Write("messages in your inbox. The temperature is ");

            float celsius = 34.4F;
            Console.Write(celsius);
            Console.Write(" celsius.");

        }
    }
}
