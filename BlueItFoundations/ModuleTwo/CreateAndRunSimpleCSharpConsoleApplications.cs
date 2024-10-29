using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlueItFoundations.ModuleTwo
{
    public static class CreateAndRunSimpleCSharpConsoleApplications
    {
        public static void Init()
        {
            //.net class library
            Random dice = new Random();
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll);

            //Stateful or instance methods are those that depend on or modify the state (the data held in variables, fields, or objects) across method calls.
            //Example: when you have a property or a field in a class that is called STATE. when there is a method that changes this value this is called a STATEFUL method because we change the value.

            //Stateless methods, on the other hand, do not depend on any previous state or change any state. They operate purely on the input they receive and return a result without storing or altering any internal data between calls.
            //Example: when you pass just parameters to a method and don't use other fields or proprties this is called STATELESS because they only rely on the input.


            //A Instance of a class is called a OBJECT.
            Random dice2 = new Random();
            dice2.Next();

            //Methode signature => number of parameters
            //Parameter => variable type
            //Argument => variable value

            int firstValue = 500;
            int secondValue = 600;
            int largerValue = Math.Max(firstValue, secondValue);

            Console.WriteLine(largerValue);

            //Developers refer to the code that implements different execution paths as code branches.

            Random dice3 = new Random();

            int roll1 = dice3.Next(1, 7);
            int roll2 = dice3.Next(1, 7);
            int roll3 = dice3.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
            if (total > 14)
            {
                Console.WriteLine("You win!");
            }

            if (total < 15)
            {
                Console.WriteLine("Sorry, you lose.");
            }

            //A Boolean expression is any code that returns a Boolean value, either true or false.

            //string message = "The quick brown fox jumps over the lazy dog.";
            //bool result = message.Contains("dog");
            //Console.WriteLine(result);

            //if (message.Contains("fox"))
            //{
            //    Console.WriteLine("What does the fox say?");
            //}

            //A code block is a collection of one or more lines of code that are defined by an opening and closing curly brace symbol { }

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
            }


            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            // Your code goes here
            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day!");
                Console.WriteLine("Renew now and save 20%!");
                discountPercentage = 20;
            }
            if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
                Console.WriteLine("Renew now and save 10%!");
                discountPercentage = 10;
            }

            if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }

            if (discountPercentage > 0)
            {
                Console.WriteLine($"Renew now and save {discountPercentage}%.");
            }


            //An array is a collection of individual data elements accessible through a single variable name.
            string[] fraudulentOrderIDs = new string[3];
            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";

            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

            string[] names = { "Rowena", "Robin", "Bao" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            foreach (int items in inventory)
            {
                sum += items;
            }

            Console.WriteLine($"We have {sum} items in inventory.");


            string[] fraudulentOrderIDs2 = new string[]
            {
                "B123",
                "C234",
                "A345",
                "C15",
                "B177",
                "G3003",
                "C235",
                "B179"
            };

            foreach (var fraudelentOrderId in fraudulentOrderIDs2)
            {
                if (fraudelentOrderId.StartsWith("B"))
                {
                    Console.WriteLine(fraudelentOrderId);
                }
            }


            string message = "The quick brown fox jumps over the lazy dog.";

            // Convert the message into a char array
            char[] messageLetters = message.ToCharArray();

            // Reverse the chars
            Array.Reverse(messageLetters);

            int x = 0;

            // count the o's
            foreach (char i in messageLetters) 
            { 
                if (i == 'o') 
                { 
                    x++; 
                } 
            }

            // initialize variables - graded assignments
            int examAssignments = 5;

            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
            int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
            int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
            int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
            int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

            // Student names
            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

            int[] studentScores = new int[10];

            string currentStudentLetterGrade = "";

            // Write the Report Header to the console
            Console.WriteLine("Student\t\tGrade\n");

            foreach (string name in studentNames)
            {
                string currentStudent = name;

                if (currentStudent == "Sophia")
                    studentScores = sophiaScores;

                else if (currentStudent == "Andrew")
                    studentScores = andrewScores;

                else if (currentStudent == "Emma")
                    studentScores = emmaScores;

                else if (currentStudent == "Logan")
                    studentScores = loganScores;

                else if (currentStudent == "Becky")
                    studentScores = beckyScores;

                else if (currentStudent == "Chris")
                    studentScores = chrisScores;

                else if (currentStudent == "Eric")
                    studentScores = ericScores;

                else if (currentStudent == "Gregor")
                    studentScores = gregorScores;

                else
                    continue;

                // initialize/reset the sum of scored assignments
                int sumAssignmentScores = 0;

                // initialize/reset the calculated average of exam + extra credit scores
                decimal currentStudentGrade = 0;

                // initialize/reset a counter for the number of assignment 
                int gradedAssignments = 0;

                // loop through the scores array and complete calculations for currentStudent
                foreach (int score in studentScores)
                {
                    // increment the assignment counter
                    gradedAssignments += 1;

                    if (gradedAssignments <= examAssignments)
                        // add the exam score to the sum
                        sumAssignmentScores += score;

                    else
                        // add the extra credit points to the sum - bonus points equal to 10% of an exam score
                        sumAssignmentScores += score / 10;
                }

                currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

                if (currentStudentGrade >= 97)
                    currentStudentLetterGrade = "A+";

                else if (currentStudentGrade >= 93)
                    currentStudentLetterGrade = "A";

                else if (currentStudentGrade >= 90)
                    currentStudentLetterGrade = "A-";

                else if (currentStudentGrade >= 87)
                    currentStudentLetterGrade = "B+";

                else if (currentStudentGrade >= 83)
                    currentStudentLetterGrade = "B";

                else if (currentStudentGrade >= 80)
                    currentStudentLetterGrade = "B-";

                else if (currentStudentGrade >= 77)
                    currentStudentLetterGrade = "C+";

                else if (currentStudentGrade >= 73)
                    currentStudentLetterGrade = "C";

                else if (currentStudentGrade >= 70)
                    currentStudentLetterGrade = "C-";

                else if (currentStudentGrade >= 67)
                    currentStudentLetterGrade = "D+";

                else if (currentStudentGrade >= 63)
                    currentStudentLetterGrade = "D";

                else if (currentStudentGrade >= 60)
                    currentStudentLetterGrade = "D-";

                else
                    currentStudentLetterGrade = "F";

                //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
                Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
            }

            // required for running in VS Code (keeps the Output windows open to view results)
            Console.WriteLine("\n\rPress the Enter key to continue");
            Console.ReadLine();

            int test = 3;
            var yes = test.ToString();

        }

    }
}
