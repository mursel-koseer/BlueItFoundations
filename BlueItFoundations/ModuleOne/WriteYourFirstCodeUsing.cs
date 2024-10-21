using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            Console.WriteLine();

            //Perform Basic String Formatting in C#
            //An escape character sequence is an instruction to the runtime to insert a special character that will affect the output of your string.In C#, the escape character sequence begins with a backslash \ followed by the character you're escaping. For example, the \n sequence will add a new line, and a \t sequence will add a tab.

            Console.WriteLine("Hello\nWorld!"); // n => newline
            Console.WriteLine("Hello\tWorld!"); // t => tab

            //Console.WriteLine("Hello "World"!"); Compiler will not know you want to use "" in the output
            Console.WriteLine("Hello \"world\"!"); // Like this you can use the ""

            //Console.WriteLine("c:\source\repos"); For paths this don't work because it recognizes as a escape character sequence

            Console.WriteLine("c:\\source\\repos"); // This will output 1 backslash

            Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");

            //Verbatim string literal => use @
            Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

            Console.Write(@"c:\invoices");

            //Unicode escape characters
            // Kon'nichiwa World
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            // User command to run an application
            Console.WriteLine(@"c:\invoices\app.exe -j");

            //String concatenation operator => +
            //string firstName = "Bob";
            //string message = "Hello " + firstName;
            //Console.WriteLine(message);


            //String interpolation combines multiple values into a single literal string by using a "template" and one or more interpolation expressions.
            //An interpolation expression is indicated by an opening and closing curly brace symbol { }.
            //You can put any C# expression that returns a value inside the braces.
            //The literal string becomes a template when it's prefixed by the $ character.

            //string message = greeting + " " + firstName + "!";

            string projectName = "ACME";

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

            //My solution
            Console.WriteLine(@$"View English output:
    c:\Exercise\{projectName}\data.txt");

            Console.WriteLine(@$"{russianMessage}:
    c:\Exercise\{projectName}\ru-RU\data.txt");



            //Perform Basic Operations on Numbers in C#
            //string firstName = "Bob";
            //int widgetsSold = 7;
            //Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

            //Output Bob sold 7 widgets.


            //string firstName = "Bob";
            //int widgetsSold = 7;
            //Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");

            //Output Bob sold 77 widgets.

            //string firstName = "Bob";
            //int widgetsSold = 7;
            //Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
            //Output Bob sold 14 widgets.
            //The parentheses symbol () becomes another overloaded operator

            int first = 7;
            int second = 5;
            decimal quotient = (decimal)first / (decimal)second; //Casting
            Console.WriteLine(quotient);

            //Increment and decrement
            int value = 0;     // value is now 0.
            value = value + 5; // value is now 5.
            value += 5;        // value is now 10.
            //Operators like +=, -=, *=, ++, and -- are known as compound assignment 



            int count = 0;
            count++;
            Console.WriteLine(count); //Output 1

            int count2 = 0;
            Console.WriteLine(count2++); //Output 0 because the compound assignment operator is after the int => It outputs then increments it

            int count3 = 0;
            Console.WriteLine(++count3); //Output 1 => it increments then outputs

            int fahrenheit = 94;
            decimal celsius2 = (fahrenheit - 32m) * (5m / 9m);
            Console.WriteLine("The temperature is " + celsius2 + " Celsius.");

            Console.WriteLine("Windows " + 7 + 4);
            Console.WriteLine(3 + 1 * 5 / 2);
            Console.WriteLine(5 / 10);

            // += => addition assignment operator



            //Guided Project - Calculate and Print Student Grades
            // initialize variables - graded assignments 
            int currentAssignments = 5;

            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;

            int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
            int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
            int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

            Console.WriteLine("Sophia: " + sophiaSum);
            Console.WriteLine("Nicolas: " + nicolasSum);
            Console.WriteLine("Zahirah: " + zahirahSum);
            Console.WriteLine("Jeong: " + jeongSum);

            decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
            decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
            decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
            decimal jeongScore = (decimal)jeongSum / currentAssignments;

            Console.WriteLine("Student\t\tGrade\n");
            Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
            Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
            Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
            Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");

            //Guided Project - Calculate Final GPA
            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            int gradeA = 4;
            int gradeB = 3;

            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;


            Console.WriteLine($"{course1Name} {course1Grade}");
            Console.WriteLine($"{course2Name} {course2Grade}");
            Console.WriteLine($"{course3Name} {course3Grade}");
            Console.WriteLine($"{course4Name} {course4Grade}");
            Console.WriteLine($"{course5Name} {course5Grade}");

            Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
            Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
            Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
            Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
            Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");

            int totalCreditHours = 0;
            totalCreditHours += course1Credit;
            totalCreditHours += course2Credit;
            totalCreditHours += course3Credit;
            totalCreditHours += course4Credit;
            totalCreditHours += course5Credit;
            totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

            int totalGradePoints = 0;
            totalGradePoints += course1Credit * course1Grade;
            totalGradePoints += course2Credit * course2Grade;
            totalGradePoints += course3Credit * course3Grade;
            totalGradePoints += course4Credit * course4Grade;
            totalGradePoints += course5Credit * course5Grade;

            decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

            int leadingDigit = (int)gradePointAverage;
            int firstDigit = (int)(gradePointAverage * 10) % 10;
            int secondDigit = (int)(gradePointAverage * 100) % 10;

            Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
            Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
            Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
            Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
            Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");

            Console.WriteLine($"Final GPA: {leadingDigit}.{firstDigit}{secondDigit}");
        }
    }
}
