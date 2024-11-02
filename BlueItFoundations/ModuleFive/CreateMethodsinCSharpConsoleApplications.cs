using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueItFoundations.ModuleFive
{
    public static class CreateMethodsinCSharpConsoleApplications
    {
        public static void Init()
        {

            //int[] times = { 800, 1200, 1600, 2000 };
            //int diff = 0;

            //Console.WriteLine("Enter current GMT");
            //int currentGMT = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Current Medicine Schedule:");
            //DisplayTimes();

            //Console.WriteLine("Enter new GMT");
            //int newGMT = Convert.ToInt32(Console.ReadLine());

            //if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
            //{
            //    Console.WriteLine("Invalid GMT");
            //}
            //else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
            //{
            //    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
            //    AdjustTimes();
            //}
            //else
            //{
            //    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
            //    AdjustTimes();
            //}

            //Console.WriteLine("New Medicine Schedule:");
            //DisplayTimes();

            //void DisplayTimes()
            //{
            //    /* Format and display medicine times */
            //    foreach (int val in times)
            //    {
            //        string time = val.ToString();
            //        int len = time.Length;

            //        if (len >= 3)
            //        {
            //            time = time.Insert(len - 2, ":");
            //        }
            //        else if (len == 2)
            //        {
            //            time = time.Insert(0, "0:");
            //        }
            //        else
            //        {
            //            time = time.Insert(0, "0:0");
            //        }

            //        Console.Write($"{time} ");
            //    }
            //    Console.WriteLine();
            //}

            //void AdjustTimes()
            //{
            //    /* Adjust the times by adding the difference, keeping the value within 24 hours */
            //    for (int i = 0; i < times.Length; i++)
            //    {
            //        times[i] = ((times[i] + diff)) % 2400;
            //    }
            //}

            Random random = new Random();
            int luck = random.Next(100);

            string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
            string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
            string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
            string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

            TellFortune();

            void TellFortune()
            {
                Console.WriteLine("A fortune teller whispers the following words:");
                string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
                for (int i = 0; i < 4; i++)
                {
                    Console.Write($"{text[i]} {fortune[i]} ");
                }
            }

            //optional parameters => A parameter becomes optional when it's assigned a default value



            Console.WriteLine("Would you like to play? (Y/N)");
            if (ShouldPlay())
            {
                PlayGame();
            }

            bool ShouldPlay()
            {
                string response = Console.ReadLine();
                return response.ToLower().Equals("y");
            }

            void PlayGame()
            {
                var play = true;

                while (play)
                {
                    var target = GetTarget();
                    var roll = RollDice();

                    Console.WriteLine($"Roll a number greater than {target} to win!");
                    Console.WriteLine($"You rolled a {roll}");
                    Console.WriteLine(WinOrLose(roll, target));
                    Console.WriteLine("\nPlay again? (Y/N)");

                    play = ShouldPlay();
                }
            }

            int GetTarget()
            {
                return random.Next(1, 6);
            }

            int RollDice()
            {
                return random.Next(1, 7);
            }

            string WinOrLose(int roll, int target)
            {
                if (roll > target)
                {
                    return "You win!";
                }
                return "You lose!";
            }





            string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

            PlanSchoolVisit("School A");
            PlanSchoolVisit("School B", 3);
            PlanSchoolVisit("School C", 2);

            void PlanSchoolVisit(string schoolName, int groups = 6)
            {
                RandomizeAnimals();
                string[,] group1 = AssignGroup(groups);
                Console.WriteLine(schoolName);
                PrintGroup(group1);
            }

            void RandomizeAnimals()
            {
                Random random = new Random();

                for (int i = 0; i < pettingZoo.Length; i++)
                {
                    int r = random.Next(i, pettingZoo.Length);

                    string temp = pettingZoo[r];
                    pettingZoo[r] = pettingZoo[i];
                    pettingZoo[i] = temp;
                }
            }

            string[,] AssignGroup(int groups = 6)
            {
                string[,] result = new string[groups, pettingZoo.Length / groups];
                int start = 0;

                for (int i = 0; i < groups; i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        result[i, j] = pettingZoo[start++];
                    }
                }

                return result;
            }

            void PrintGroup(string[,] groups)
            {
                for (int i = 0; i < groups.GetLength(0); i++)
                {
                    Console.Write($"Group {i + 1}: ");
                    for (int j = 0; j < groups.GetLength(1); j++)
                    {
                        Console.Write($"{groups[i, j]}  ");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void SayHello()
        {
            Console.WriteLine("Hello World!");
        }

        static void DisplayRandomNumbers()
        {
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{random.Next(1, 100)} ");
            }
        }
    }
}
