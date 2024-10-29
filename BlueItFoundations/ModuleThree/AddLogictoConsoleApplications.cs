using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BlueItFoundations.ModuleThree
{
    public static class AddLogictoConsoleApplications
    {
        public static void Init()
        {
            //What is an expression
            //An expression is any combination of values (literal or variable), operators, and methods that return a single value.

            //Console.WriteLine("a" == "a");
            //Console.WriteLine("a" == "A");
            //Console.WriteLine(1 == 2);

            //string myValue = "a";
            //Console.WriteLine(myValue == "a");

            Console.WriteLine("a" != "a");
            Console.WriteLine("a" != "A");
            Console.WriteLine(1 != 2);

            string myValue = "a";
            Console.WriteLine(myValue != "a");

            Console.WriteLine(1 > 2);
            Console.WriteLine(1 < 2);
            Console.WriteLine(1 >= 1);
            Console.WriteLine(1 <= 1);

            string pangram = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(pangram.Contains("fox"));
            Console.WriteLine(pangram.Contains("cow"));

            //What is logical negation
            //The term "Logical Negation" refers to the unary negation operator !. Some people call this operator the "not operator". When you place the ! operator before a conditional expression (or any code that's evaluated to either true or false)

            // These two lines of code will create the same output
            Console.WriteLine(pangram.Contains("fox") == false);
            Console.WriteLine(!pangram.Contains("fox"));

            int a = 7;
            int b = 6;
            Console.WriteLine(a != b); // output: True
            string s1 = "Hello";
            string s2 = "Hello";
            Console.WriteLine(s1 != s2); // output: False

            //What is the conditional operator
            //The conditional operator ?: evaluates a Boolean expression and returns one of two results depending on whether the Boolean expression evaluates to true or false.

            int saleAmount = 1001;
            //int discount = saleAmount > 1000 ? 100 : 50;
            //Console.WriteLine($"Discount: {discount}");

            //int saleAmount = 1001;
            // int discount = saleAmount > 1000 ? 100 : 50;

            Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

            //var random = new Random();
            //var number = random.Next(0, 2);
            //Console.WriteLine(number == 0 ? "heads" : "tails");





            string permission = "Admin|Manager";
            int level = 53;

            if (permission.Contains("Admin"))
            {
                if (level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else
                {
                    Console.WriteLine("Welcome, Admin user.");
                }
            }
            else if (permission.Contains("Manager"))
            {
                if (level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }




            bool flag = true;
            int value = 0;

            if (flag)
            {
                Console.WriteLine($"Inside the code block: {value}");
            }

            value = 10;
            Console.WriteLine($"Outside the code block: {value}");



            bool flag2 = true;
            if (flag2) Console.WriteLine(flag2);

            //string name = "steve";
            //if (name == "bob") Console.WriteLine("Found Bob");
            //else if (name == "steve") Console.WriteLine("Found Steve");
            //else Console.WriteLine("Found Chuck");



            //if (name == "bob")
            //    Console.WriteLine("Found Bob");
            //else if (name == "steve")
            //    Console.WriteLine("Found Steve");
            //else
            //    Console.WriteLine("Found Chuck");






            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            bool found = false;
            int total = 0;

            foreach (int number in numbers)
            {
                total += number;

                if (number == 42) found = true;

            }

            if (found) Console.WriteLine("Set contains 42");

            Console.WriteLine($"Total: {total}");

            string fruit = "apple";
            switch (fruit)
            {
                case "apple":
                    Console.WriteLine($"App will display information for apple.");
                    break;

                case "banana":
                    Console.WriteLine($"App will display information for banana.");
                    break;

                case "cherry":
                    Console.WriteLine($"App will display information for cherry.");
                    break;
            }



            int employeeLevel = 100;
            string employeeName = "John Smith";

            string title = "";

            switch (employeeLevel)
            {
                case 100:
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }

            Console.WriteLine($"{employeeName}, {title}");

            // SKU = Stock Keeping Unit. 
            // SKU value format: <product #>-<2-letter color code>-<size code>
            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";

            switch (product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-Shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
                default:
                    type = "Other";
                    break;
            }

            switch (product[1])
            {
                case "BL":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break;
                default:
                    color = "White";
                    break;
            }

            switch (product[2])
            {
                case "S":
                    size = "Small";
                    break;
                case "M":
                    size = "Medium";
                    break;
                case "L":
                    size = "Large";
                    break;
                default:
                    size = "One Size Fits All";
                    break;
            }

            Console.WriteLine($"Product: {size} {color} {type}");

            //int i = 0 => initializer
            // i < 10 => condition
            // i++ => iterator
            // i => body
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i += 3)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7) break;
            }

            //string[] names = { "Alex", "Eddie", "David", "Michael" };
            //for (int i = names.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //string[] names = { "Alex", "Eddie", "David", "Michael" };
            //foreach (var name in names)
            //{
            //    // Can't do this:
            //    if (name == "David") name = "Sammy";
            //}

            string[] names = { "Alex", "Eddie", "David", "Michael" };
            for (int i = 0; i < names.Length; i++)
                if (names[i] == "David") names[i] = "Sammy";

            foreach (var name in names) Console.WriteLine(name);
            Console.WriteLine();
            Console.WriteLine();




            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine();
                Console.Write(i + " - ");         

                if (i % 3 == 0)
                    Console.Write("Fizz");

                if (i % 5 == 0)
                    Console.Write("Buzz");
            }

            //Random random = new Random();
            //int current = random.Next(1, 11);

            //do
            //{
            //    current = random.Next(1, 11);

            //    if (current >= 8) continue;

            //    Console.WriteLine(current);
            //} while (current != 7);

            /*
            while (current >= 3)
            {
                Console.WriteLine(current);
                current = random.Next(1, 11);
            }
            Console.WriteLine($"Last number: {current}");
            */


            var random = new Random();
            int heroHealthPoints = 10;
            int monsterHeathPoints = 10;

            while ((heroHealthPoints > 0) && (monsterHeathPoints > 0))
            {
                var attackDamage = random.Next(1, 11);
                monsterHeathPoints -= attackDamage;

                Console.WriteLine($"Monster was damaged and lost {attackDamage} health and now has {monsterHeathPoints} health.");

                if (monsterHeathPoints <= 0) continue;

                attackDamage = random.Next(1, 11);
                heroHealthPoints -= attackDamage;

                Console.WriteLine($"Hero was damaged and lost {attackDamage} health and now has {heroHealthPoints} health.");
            }

            Console.WriteLine(heroHealthPoints > monsterHeathPoints ? "Hero wins" : "Monster wins");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            // the ourAnimals array will store the following: 
            //string animalSpecies = "";
            //string animalID = "";
            //string animalAge = "";
            //string animalPhysicalDescription = "";
            //string animalPersonalityDescription = "";
            //string animalNickname = "";

            //// variables that support data entry
            //int maxPets = 8;
            //string? readResult;
            //string menuSelection = "";

            //// array used to store runtime data, there is no persisted data
            //string[,] ourAnimals = new string[maxPets, 6];

            //// TODO: Convert the if-elseif-else construct to a switch statement

            //// create some initial ourAnimals array entries
            //for (int i = 0; i < maxPets; i++)
            //{
            //    switch (i)
            //    {
            //        case 0:
            //            animalSpecies = "dog";
            //            animalID = "d1";
            //            animalAge = "2";
            //            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            //            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            //            animalNickname = "lola";
            //            break;
            //        case 1:
            //            animalSpecies = "dog";
            //            animalID = "d2";
            //            animalAge = "9";
            //            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            //            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            //            animalNickname = "loki";
            //            break;
            //        case 2:
            //            animalSpecies = "cat";
            //            animalID = "c3";
            //            animalAge = "1";
            //            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            //            animalPersonalityDescription = "friendly";
            //            animalNickname = "Puss";
            //            break;
            //        case 3:
            //            animalSpecies = "cat";
            //            animalID = "c4";
            //            animalAge = "?";
            //            animalPhysicalDescription = "";
            //            animalPersonalityDescription = "";
            //            animalNickname = "";
            //            break;
            //        default:
            //            animalSpecies = "";
            //            animalID = "";
            //            animalAge = "";
            //            animalPhysicalDescription = "";
            //            animalPersonalityDescription = "";
            //            animalNickname = "";
            //            break;
            //    }

            //    ourAnimals[i, 0] = "ID #: " + animalID;
            //    ourAnimals[i, 1] = "Species: " + animalSpecies;
            //    ourAnimals[i, 2] = "Age: " + animalAge;
            //    ourAnimals[i, 3] = "Nickname: " + animalNickname;
            //    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
            //    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
            //}

            //// display the top-level menu options
            //do
            //{
            //    Console.Clear();

            //    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
            //    Console.WriteLine(" 1. List all of our current pet information");
            //    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
            //    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
            //    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
            //    Console.WriteLine(" 5. Edit an animal’s age");
            //    Console.WriteLine(" 6. Edit an animal’s personality description");
            //    Console.WriteLine(" 7. Display all cats with a specified characteristic");
            //    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
            //    Console.WriteLine();
            //    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

            //    readResult = Console.ReadLine();
            //    if (readResult != null)
            //    {
            //        menuSelection = readResult.ToLower();
            //    }

            //    Console.WriteLine($"You selected menu option {menuSelection}.");
            //    Console.WriteLine("Press the Enter key to continue");

            //    switch (menuSelection)
            //    {
            //        case "1":
            //            Console.WriteLine();
            //            for (int i = 0; i < maxPets; i++)
            //            {
            //                if (ourAnimals[i, 0] != "ID #: ")
            //                {
            //                    Console.WriteLine(ourAnimals[i, 0]);
            //                    Console.WriteLine(ourAnimals[i, 0]);
            //                    for (int j = 0; j < 6; j++)
            //                    {
            //                        Console.WriteLine(ourAnimals[i, j]);
            //                    }
            //                }
            //            }
            //            Console.WriteLine("Press the Enter key to continue.");
            //            readResult = Console.ReadLine();
            //            break;

            //        case "2":
            //            // List all of our current pet information
            //            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            //            Console.WriteLine("Press the Enter key to continue.");
            //            readResult = Console.ReadLine();
            //            break;
            //        case "3":
            //        case "4":
            //            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            //            Console.WriteLine("Press the Enter key to continue.");
            //            readResult = Console.ReadLine();
            //            break;
            //        default:
            //            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            //            Console.WriteLine("Press the Enter key to continue.");
            //            readResult = Console.ReadLine();
            //            break;
            //    }
            //    } while (menuSelection != "exit");

            

            

            

            //// pause code execution
            //readResult = Console.ReadLine();





            // the ourAnimals array will store the following: 
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickname = "";

            // variables that support data entry
            int maxPets = 8;
            string? readResult;
            string menuSelection = "";
            int petCount = 0;
            string anotherPet = "y";
            bool validEntry = false;
            int petAge = 0;

            // array used to store runtime data, there is no persisted data
            string[,] ourAnimals = new string[maxPets, 6];

            // create some initial ourAnimals array entries
            for (int i = 0; i < maxPets; i++)
            {
                switch (i)
                {
                    case 0:
                        animalSpecies = "dog";
                        animalID = "d1";
                        animalAge = "2";
                        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                        animalNickname = "lola";
                        break;

                    case 1:
                        animalSpecies = "dog";
                        animalID = "d2";
                        animalAge = "9";
                        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                        animalNickname = "loki";
                        break;

                    case 2:
                        animalSpecies = "cat";
                        animalID = "c3";
                        animalAge = "1";
                        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                        animalPersonalityDescription = "friendly";
                        animalNickname = "Puss";
                        break;

                    case 3:
                        animalSpecies = "cat";
                        animalID = "c4";
                        animalAge = "?";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";

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

            // display the top-level menu options
            do
            {
                Console.Clear();

                Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                Console.WriteLine(" 1. List all of our current pet information");
                Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
                Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
                Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
                Console.WriteLine(" 5. Edit an animal’s age");
                Console.WriteLine(" 6. Edit an animal’s personality description");
                Console.WriteLine(" 7. Display all cats with a specified characteristic");
                Console.WriteLine(" 8. Display all dogs with a specified characteristic");
                Console.WriteLine();
                Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    menuSelection = readResult.ToLower();
                    // NOTE: We could put a do statement around the menuSelection entry to ensure a valid entry, but we
                    //  use a conditional statement below that only processes the valid entry values, so the do statement 
                    //  is not required here. 
                }

                // use switch-case to process the selected menu option
                switch (menuSelection)
                {
                    case "1":
                        // List all of our current pet information
                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 0] != "ID #: ")
                            {
                                Console.WriteLine();
                                for (int j = 0; j < 6; j++)
                                {
                                    Console.WriteLine(ourAnimals[i, j].ToString());
                                }
                            }
                        }
                        Console.WriteLine("\n\rPress the Enter key to continue");
                        readResult = Console.ReadLine();

                        break;

                    case "2":
                        // Add a new animal friend to the ourAnimals array
                        //
                        // The ourAnimals array contains
                        //    1. the species (cat or dog). a required field
                        //    2. the ID number - for example C17
                        //    3. the pet's age. can be blank at initial entry.
                        //    4. the pet's nickname. can be blank.
                        //    5. a description of the pet's physical appearance. can be blank.
                        //    6. a description of the pet's personality. can be blank.

                        anotherPet = "y";
                        petCount = 0;
                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 0] != "ID #: ")
                            {
                                petCount += 1;
                            }
                        }

                        if (petCount < maxPets)
                        {
                            Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
                        }

                        while (anotherPet == "y" && petCount < maxPets)
                        {
                            // get species (cat or dog) - string animalSpecies is a required field 
                            do
                            {
                                Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalSpecies = readResult.ToLower();
                                    if (animalSpecies != "dog" && animalSpecies != "cat")
                                    {
                                        //Console.WriteLine($"You entered: {animalSpecies}.");
                                        validEntry = false;
                                    }
                                    else
                                    {
                                        validEntry = true;
                                    }
                                }
                            } while (validEntry == false);

                            // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                            animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                            // get the pet's age. can be ? at initial entry.
                            do
                            {
                                Console.WriteLine("Enter the pet's age or enter ? if unknown");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalAge = readResult;
                                    if (animalAge != "?")
                                    {
                                        validEntry = int.TryParse(animalAge, out petAge);
                                    }
                                    else
                                    {
                                        validEntry = true;
                                    }
                                }
                            } while (validEntry == false);


                            // get a description of the pet's physical appearance - animalPhysicalDescription can be blank.
                            do
                            {
                                Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalPhysicalDescription = readResult.ToLower();
                                    if (animalPhysicalDescription == "")
                                    {
                                        animalPhysicalDescription = "tbd";
                                    }
                                }
                            } while (validEntry == false);


                            // get a description of the pet's personality - animalPersonalityDescription can be blank.
                            do
                            {
                                Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalPersonalityDescription = readResult.ToLower();
                                    if (animalPersonalityDescription == "")
                                    {
                                        animalPersonalityDescription = "tbd";
                                    }
                                }
                            } while (validEntry == false);


                            // get the pet's nickname. animalNickname can be blank.
                            do
                            {
                                Console.WriteLine("Enter a nickname for the pet");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalNickname = readResult.ToLower();
                                    if (animalNickname == "")
                                    {
                                        animalNickname = "tbd";
                                    }
                                }
                            } while (validEntry == false);

                            // store the pet information in the ourAnimals array (zero based)
                            ourAnimals[petCount, 0] = "ID #: " + animalID;
                            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                            ourAnimals[petCount, 2] = "Age: " + animalAge;
                            ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                            ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                            ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                            // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                            petCount = petCount + 1;

                            // check maxPet limit
                            if (petCount < maxPets)
                            {
                                // another pet?
                                Console.WriteLine("Do you want to enter info for another pet (y/n)");
                                do
                                {
                                    readResult = Console.ReadLine();
                                    if (readResult != null)
                                    {
                                        anotherPet = readResult.ToLower();
                                    }

                                } while (anotherPet != "y" && anotherPet != "n");
                            }
                            //NOTE: The value of anotherPet (either "y" or "n") is evaluated in the while statement expression - at the top of the while loop
                        }

                        if (petCount >= maxPets)
                        {
                            Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                            Console.WriteLine("Press the Enter key to continue.");
                            readResult = Console.ReadLine();
                        }

                        break;

                    case "3":
                        // Ensure animal ages and physical descriptions are complete
                        Console.WriteLine("Challenge Project - please check back soon to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "4":
                        // Ensure animal nicknames and personality descriptions are complete
                        Console.WriteLine("Challenge Project - please check back soon to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "5":
                        // Edit an animal’s age");
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "6":
                        // Edit an animal’s personality description");
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "7":
                        // Display all cats with a specified characteristic
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "8":
                        // Display all dogs with a specified characteristic
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
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
