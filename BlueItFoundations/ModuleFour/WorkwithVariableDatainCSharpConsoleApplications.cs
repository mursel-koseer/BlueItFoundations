using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BlueItFoundations.ModuleFour
{
    public static class WorkwithVariableDatainCSharpConsoleApplications
    {
        public static void Initialize()
        {
            //A signed type uses its bytes to represent an equal number of positive and negative numbers. The following exercise gives you exposure to the signed integral types in C#.
            Console.WriteLine("Signed integral types:");

            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");


            //An unsigned type uses its bytes to represent only positive numbers. The remainder of the exercise introduces the unsigned integral types in C#.
            Console.WriteLine("");
            Console.WriteLine("Unsigned integral types:");

            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

            //you should use decimal when working with financial data or any scenario where you need an accurate result from a calculation

            Console.WriteLine("");
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

            //A value type variable stores its values directly in an area of storage called the stack.
            //A reference type variable stores its values in a separate memory region called the heap. The heap is a memory area that is shared across many applications running on the operating system at the same time.

            //int[] data;
            //data = new int[3];

            string shortenedString = "Hello World!";
            Console.WriteLine(shortenedString);

            int val_A = 2;
            int val_B = val_A;
            val_B = 5;

            Console.WriteLine("--Value Types--");
            Console.WriteLine($"val_A: {val_A}");
            Console.WriteLine($"val_B: {val_B}");

            int[] ref_A = new int[1];
            ref_A[0] = 2;
            int[] ref_B = ref_A;
            ref_B[0] = 5;

            Console.WriteLine("--Reference Types--");
            Console.WriteLine($"ref_A[0]: {ref_A[0]}");
            Console.WriteLine($"ref_B[0]: {ref_B[0]}");

            //            int for most whole numbers
            //decimal for numbers representing money
            //bool for true or false values
            //string for alphanumeric value

            //            byte: working with encoded data that comes from other computer systems or using different character sets.
            //double: working with geometric or scientific purposes. double is used frequently when building games involving motion.
            //System.DateTime for a specific date and time value.
            //System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.


            //int first = 2;
            //string second = "4";
            //string result = first + second;
            //Console.WriteLine(result);


            //Implicit
            //int myInt = 3;
            //Console.WriteLine($"int: {myInt}");

            //decimal myDecimal = myInt;
            //Console.WriteLine($"decimal: {myDecimal}");


            //Explicit
            //decimal myDecimal = 3.14m;
            //Console.WriteLine($"decimal: {myDecimal}");

            //int myInt = (int)myDecimal;
            //Console.WriteLine($"int: {myInt}");

            decimal myDecimal = 1.23456789m;
            float myFloat = (float)myDecimal;

            Console.WriteLine($"Decimal: {myDecimal}");
            Console.WriteLine($"Float  : {myFloat}");

            //int first = 5;
            //int second = 7;
            //string message = first.ToString() + second.ToString();
            //Console.WriteLine(message);

            //string first = "5";
            //string second = "7";
            //int sum = int.Parse(first) + int.Parse(second);
            //Console.WriteLine(sum);

            //string value1 = "5";
            //string value2 = "7";
            //int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            //Console.WriteLine(result);


            //int truncates the decimal values
            //int value = (int)1.5m; // casting truncates
            //Console.WriteLine(value);


            ////Convert int32 rounds up or down the decimal values.
            //int value2 = Convert.ToInt32(1.5m); // converting rounds up
            //Console.WriteLine(value2);

            //string value = "102";

            //if (int.TryParse(value, out int result))
            //{
            //    Console.WriteLine($"Measurement: {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Unable to report the measurement.");
            //}
            //Console.WriteLine($"Measurement (w/ offset): {50 + result}");



            //string[] values = { "12.3", "45", "ABC", "11", "DEF" };

            //decimal total = 0m;
            //string message = "";

            //foreach (var value in values)
            //{

            //    if (decimal.TryParse(value, out decimal number))
            //    {
            //        total += number;
            //    }
            //    else
            //    {
            //        message += value;
            //    }
            //}

            //Console.WriteLine($"Message: {message}");
            //Console.WriteLine($"Total: {total}");



            int value1 = 11;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            // Your code here to set result1
            // Hint: You need to round the result to nearest integer (don't just truncate)
            int result1 = Convert.ToInt32(value1 / value2);
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            // Your code here to set result2
            decimal result2 = value2 / (decimal)value3;
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            // Your code here to set result3
            float result3 = value3 / value1;
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

            //string[] pallets = ["B14", "A11", "B12", "A13"];

            //Console.WriteLine("Sorted...");
            //Array.Sort(pallets);
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            //Console.WriteLine("");
            //Console.WriteLine("Reversed...");
            //Array.Reverse(pallets);
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            string[] pallets = ["B14", "A11", "B12", "A13"];
            Console.WriteLine("");

            Array.Clear(pallets, 0, 2);
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Array.Resize(ref pallets, 6);
            Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            pallets[4] = "C01";
            pallets[5] = "C02";

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);
            //string result = new string(valueArray);
            //Console.WriteLine(result);

            //string result = string.Join(",", valueArray);
            //Console.WriteLine(result);

            //string[] items = result.Split(',');
            //foreach (string item in items)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string pangram = "The quick brown fox jumps over the lazy dog";
            string[] pangramArray = pangram.Split(" ");
            foreach (var pan in pangramArray)
            {
                var chars = pan.ToCharArray();
                Array.Reverse(chars);
                Console.Write(string.Join("",chars) + " ");
            }

            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            foreach (var order in orderStream.Split(","))
            {
                Console.WriteLine();
                Console.Write(order);
                if (order.Length != 4)
                {
                    Console.Write("\t - Error");
                }
            }


            //Composite formatting uses numbered placeholders within a string. At run time, everything inside the braces is resolved to a value that is also passed in based on their position.
            string first = "Hello";
            string second = "World";
            Console.WriteLine("{1} {0}!", first, second);
            Console.WriteLine("{0} {0} {0}!", first, second);


            //String interpolation is a technique that simplifies composite formatting.
            // use => $
            Console.WriteLine($"{first} {second}!");
            Console.WriteLine($"{second} {first}!");
            Console.WriteLine($"{first} {first} {first}!");

            //decimal price = 123.45m;
            //int discount = 50;
            //Console.WriteLine($"Price: {price:C} (Save {discount:C})"); //Currency for specific culture on machine
            decimal measurement = 123456.78912m;
            Console.WriteLine($"Measurement: {measurement:N} units"); //N => displays 2 decimal digits
            Console.WriteLine($"Measurement: {measurement:N4} units"); //N => displays 2 decimal digits

            decimal tax = .36785m;
            Console.WriteLine($"Tax rate: {tax:P2}"); //format percentages and rounds to 2 decimal places


            decimal price = 67.55m;
            decimal salePrice = 59.99m;

            string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

            yourDiscount += $"A discount of {((price - salePrice) / price):P2}!"; //inserted
            Console.WriteLine(yourDiscount);

            int invoiceNumber = 1201;
            decimal productShares = 25.4568m;
            decimal subtotal = 2750.00m;
            decimal taxPercentage = .15825m;
            decimal total = 3185.19m;

            Console.WriteLine($"Invoice Number: {invoiceNumber}");
            Console.WriteLine($"   Shares: {productShares:N3} Product");
            Console.WriteLine($"     Sub Total: {subtotal:C}");
            Console.WriteLine($"           Tax: {taxPercentage:P2}");
            Console.WriteLine($"     Total Billed: {total:C}");



            //The PadLeft() method adds blank spaces to the left-hand side of the string so that the total number of characters equals the argument you send it.
            //string input = "Pad this";
            //Console.WriteLine(input.PadLeft(12));

            //Console.WriteLine(input.PadRight(12));

            //Console.WriteLine(input.PadLeft(12, '-'));
            //Console.WriteLine(input.PadRight(12, '-'));

            string paymentId = "769C";
            string payeeName = "Mr. Stephen Ortega";
            string paymentAmount = "$5,000.00";

            var formattedLine = paymentId.PadRight(6);
            formattedLine += payeeName.PadRight(24);
            formattedLine += paymentAmount.PadLeft(10);

            Console.WriteLine(formattedLine);






            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            // Your logic here
            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine("As a customer of our {0} offering we are excited to tell you about a new financial product that would dramatically increase your return.", currentProduct);
            Console.WriteLine();
            Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.");
            Console.WriteLine();
            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C2}.");
            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            // Your logic here

            Console.WriteLine(comparisonMessage);
            Console.WriteLine();
            Console.WriteLine("{0}\t\t{1:P2}\t{2:C2}", currentProduct, currentReturn, currentProfit);
            Console.WriteLine("{0}\t\t{1:P2}\t{2:C2}", newProduct, newReturn, newProfit);

            //string message = "Find what is (inside the parentheses)";

            //int openingPosition = message.IndexOf('(');
            //int closingPosition = message.IndexOf(')');

            //openingPosition += 1;

            //int length = closingPosition - openingPosition;
            //Console.WriteLine(message.Substring(openingPosition, length)); //By increasing the openingPosition by 1, you skip over the opening parenthesis character

            //string message = "hello there!";

            //int first_h = message.IndexOf('h');
            //int last_h = message.LastIndexOf('h');

            //Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

            //string message = "(What if) there are (more than) one (set of parentheses)?";
            //while (true)
            //{
            //    int openingPosition = message.IndexOf('(');
            //    if (openingPosition == -1) break;

            //    openingPosition += 1;
            //    int closingPosition = message.IndexOf(')');
            //    int length = closingPosition - openingPosition;
            //    Console.WriteLine(message.Substring(openingPosition, length));

            //    // Note the overload of the Substring to return only the remaining 
            //    // unprocessed message:
            //    message = message.Substring(closingPosition + 1);
            //}

            string data = "12345John Smith          5000  3  ";
            string updatedData = data.Remove(5, 20);
            Console.WriteLine(updatedData);

            string message = "This--is--ex-amp-le--da-ta";
            message = message.Replace("--", " ");
            message = message.Replace("-", "");
            Console.WriteLine(message);



            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            // Your work here

            // Extract the "quantity"
            const string openSpan = "<span>";
            const string closeSpan = "</span>";

            int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
            int quantityEnd = input.IndexOf(closeSpan);
            int quantityLength = quantityEnd - quantityStart;
            quantity = input.Substring(quantityStart, quantityLength);
            quantity = $"Quantity: {quantity}";

            // Set output to input, replacing the trademark symbol with the registered trademark symbol
            const string tradeSymbol = "&trade;";
            const string regSymbol = "&reg;";
            output = input.Replace(tradeSymbol, regSymbol);

            // Remove the opening <div> tag
            const string openDiv = "<div>";
            int divStart = output.IndexOf(openDiv);
            output = output.Remove(divStart, openDiv.Length);

            // Remove the closing </div> tag and add "Output:" to the beginning
            const string closeDiv = "</div>";
            int divCloseStart = output.IndexOf(closeDiv);
            output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

            Console.WriteLine(quantity);
            Console.WriteLine(output);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // #1 the ourAnimals array will store the following: 
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickname = "";

            // #2 variables that support data entry
            int maxPets = 8;
            string? readResult;
            string menuSelection = "";

            // #3 array used to store runtime data, there is no persisted data
            string[,] ourAnimals = new string[maxPets, 6];

            // #4 create sample data ourAnimals array entries
            for (int i = 0; i < maxPets; i++)
            {
                switch (i)
                {
                    case 0:
                        animalSpecies = "dog";
                        animalID = "d1";
                        animalAge = "2";
                        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                        animalNickname = "lola";
                        break;

                    case 1:
                        animalSpecies = "dog";
                        animalID = "d2";
                        animalAge = "9";
                        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                        animalNickname = "gus";
                        break;

                    case 2:
                        animalSpecies = "cat";
                        animalID = "c3";
                        animalAge = "1";
                        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                        animalPersonalityDescription = "friendly";
                        animalNickname = "snow";
                        break;

                    case 3:
                        animalSpecies = "cat";
                        animalID = "c4";
                        animalAge = "3";
                        animalPhysicalDescription = "Medium sized, long hair, yellow, female, about 10 pounds. Uses litter box.";
                        animalPersonalityDescription = "A people loving cat that likes to sit on your lap.";
                        animalNickname = "Lion";
                        break;

                    default:
                        animalSpecies = "";
                        animalID = "";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        break;

                }

                ourAnimals[i, 0] = "ID #: " + animalID;
                ourAnimals[i, 1] = "Species: " + animalSpecies;
                ourAnimals[i, 2] = "Age: " + animalAge;
                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

            }


            // #5 display the top-level menu options
            do
            {
                // NOTE: the Console.Clear method is throwing an exception in debug sessions
                Console.Clear();

                Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                Console.WriteLine(" 1. List all of our current pet information");
                Console.WriteLine(" 2. Display all dogs with a specified characteristic");
                Console.WriteLine();
                Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    menuSelection = readResult.ToLower();
                }

                // use switch-case to process the selected menu option
                switch (menuSelection)
                {
                    case "1":
                        // list all pet info
                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 0] != "ID #: ")
                            {
                                Console.WriteLine();
                                for (int j = 0; j < 6; j++)
                                {
                                    Console.WriteLine(ourAnimals[i, j]);
                                }
                            }
                        }
                        Console.WriteLine("\n\rPress the Enter key to continue");
                        readResult = Console.ReadLine();

                        break;

                    case "2":
                        // Display all dogs with a specified characteristic
                        Console.WriteLine("\nUNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    default:
                        break;
                }

            } while (menuSelection != "exit");

        }
    }
}
