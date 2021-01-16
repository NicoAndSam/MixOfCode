using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string input = Console.ReadLine();
            Console.WriteLine($"Hello {input}!");

            // This part will tell the user their age in a string
            Console.WriteLine("How old are you?");
            double age = Convert.ToInt32(Console.ReadLine());
            // This part tells you if you are a higher priority based on your age
            Console.WriteLine("Are you a (1) boy or a (2) girl?");
            double gender = Convert.ToInt32(Console.ReadLine());
            if (gender == 1)
            {
                Console.WriteLine($"You are a boy that is {age} years old.");
            }
            else
            {
                Console.WriteLine($"You are a girl that is {age} years old");
            }
            // Young person
            if (age < 17)
            {
                Console.WriteLine("You are a low priority for the coronavirus vaccine.");
                Console.WriteLine("You are not allowed to drive");
            }
            // Person aged over 17
            else if (age >= 17)
            {
                if (age < 60)
                {
                    Console.WriteLine("You are a lower priority for the coronavirus vaccine.");
                    Console.WriteLine("You are allowed to drive");
                }
                else
                {
                    Console.WriteLine("You are a higher priority for the coronavirus vaccine.");
                    Console.WriteLine("You are allowed to drive");
                }
            }
            //New project
            Console.WriteLine("Would you like to (1) find out the tax per citizen?");
            Console.WriteLine("Or, Would you like to (2) find out the tax of a product?");
            Console.WriteLine("Please choose 1 or 2");
            double choice1 = Convert.ToInt32(Console.ReadLine());

            if (choice1 == 1)
            {
                Console.WriteLine("How much do you tax each citizen?");
                double taxValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many citizens are in your country?");
                double citizens = Convert.ToInt32(Console.ReadLine());
                double earnings = taxValue * citizens;
                Console.WriteLine($"You are earning {earnings}");
            }
            else if (choice1 == 2)
            {
                // Cost of buying something + tax

                Console.WriteLine("How much does the product cost that you are buying?");
                double productCost = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How much is the tax in your country, percentage wise?");
                double buyTax = Convert.ToInt32(Console.ReadLine());
                double taxTotal = productCost * buyTax / 100;
                Console.WriteLine($"The tax you will pay on top of the original price is {taxTotal}.");
                double productTotal = taxTotal + productCost;
                Console.WriteLine($"The total price of the product is now {productTotal}");


            }

            //Retirement age

            if (gender == 1)
            {
                if (age < 65)
                {
                    double manretire = 65 - age;
                    Console.WriteLine($"You have {manretire} years until you can retire.");
                }
                else
                {
                    Console.WriteLine("You should have already retired");
                }
            }

            else if (gender == 2)
                if (age < 62)
                {
                    double womanretire = 62 - age;
                    Console.WriteLine($"You have {womanretire} years until you can retire.");
                }
            if (age > 50)

            // Podzol vs Mycelium
            {
                Console.WriteLine("You are too old to play minecraft!");
            }
            else
            {
                Console.WriteLine("This is a minecraft section");
                Console.WriteLine("This is a random generator of Podzol vs Mycelium.");
                Random random = new System.Random();
                double minecraftNumber = random.Next(1, 3);
                if (minecraftNumber == 1)
                {
                    Console.WriteLine("You have been assigned Podzol.");

                }
                else if (minecraftNumber == 2)
                {
                    Console.WriteLine("You have been assigned Mycelium");

                    // This will help anyone aged 31 or under with their maths homework.
                }
            }

            if (age < 31)
            {
                Console.WriteLine("This section will help you with your maths homework.");
                Console.WriteLine("Please write the number for the desired section");
                Console.WriteLine("(1) Addition");
                Console.WriteLine("(2) Subtraction");
                Console.WriteLine("(3) Multiplication");
                Console.WriteLine("(4) Division");
                double mathsChoice = Convert.ToInt32(Console.ReadLine());
                if (mathsChoice == 1)
                {
                    Console.WriteLine("You chose Addition");
                    Console.WriteLine("Please enter the first number:");
                    double addition1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the second number:");
                    double addition2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"You are wanting to add {addition1} to {addition2}");
                    double plusanswer = addition1 + addition2;
                    Console.WriteLine($"You have added {addition1} to {addition2} and the answer is {plusanswer}");  ;
                }
                else if (mathsChoice == 2)
                {
                    Console.WriteLine("You chose Subtraction");
                    Console.WriteLine("Please enter the first number:");
                    double subtraction1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the second number:");
                    double subtraction2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"You are wanting to subtract {subtraction2} from {subtraction1}");
                    double subanswer = subtraction1 - subtraction2;  ;
                    Console.WriteLine($"You have subtracted {subtraction2} from {subtraction1} and the answer is {subanswer}");  ;
                }
                else if (mathsChoice == 3)
                {
                    Console.WriteLine("You chose Multiplication");
                    Console.WriteLine("Please enter the first number:");
                    double multiplication1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the second number:");
                    double multiplication2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"You are wanting to multiply {multiplication1} by {multiplication2}");
                    double multiplyanswer = multiplication1 * multiplication2;
                    Console.WriteLine($"You have multiplied {multiplication1} by {multiplication2} and the answer is {multiplyanswer}"); ;
                }
                else if (mathsChoice == 4)
                {
                    Console.WriteLine("You chose Division");
                    Console.WriteLine("Please enter the first number:");
                    double division1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the second number:");
                    double division2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"You are wanting to divide {division1} by {division2}");
                    double divisionanswer = division1 / division2;
                    Console.WriteLine($"You have divided {division1} by {division2} and the answer is {divisionanswer}");
                }

            
            
        
            }
            //Start Coding Here
            Console.Write("please enter a file to search for");
            string fileResponse = Console.ReadLine();
            Console.Write("please enter a word to search for in the file");
            string wordResponse = Console.ReadLine();
            StreamReader myfile = File.OpenText(fileResponse);
            string line = myfile.ReadLine();
            int position = line.IndexOf(wordResponse);
            int count = 0; //counts the number of times wordResponse is found.
            while (line != null)
            {
                if (position != -1)
                {
                    count++;
                }
                line = myfile.ReadLine();
            }
            if (count == 0)
            {
                Console.WriteLine("Your word was not found!");
            }
            else
            {
                Console.WriteLine("Your word was found " + count + " times!" + position);
            }
            Console.ReadLine();





        }
    }
}
