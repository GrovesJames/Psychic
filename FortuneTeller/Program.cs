using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            int retire = 0;
            int balance = 0;
            string car = "";
            string home = "";

            Console.WriteLine("What's your first name?");
            string answerOne = Console.ReadLine();

            Console.WriteLine("\nWhat's your last name?");
            string answerTwo = Console.ReadLine();

            Console.WriteLine("\nHow old are you?");
            string answerThree = Console.ReadLine();
            int answerThreeNum = Convert.ToInt32(answerThree);

            Console.WriteLine("\nWhat's the number of the month you were born?");
            string answerFour = Console.ReadLine();
            int answerFourNum = Convert.ToInt32(answerFour);

            Console.WriteLine("\nWhat's your favorite color out of: Red, Orange, Yellow, Green, Blue, Indigo & Violet?");
            string answerFive = Console.ReadLine().ToLower();

            Console.WriteLine("\nHow many siblings do you have?");
            string answerSix = Console.ReadLine();
            int answerSixNum = Convert.ToInt32(answerSix);

            if(answerThreeNum >= 30)
            {
                retire = 35;
            }
            else if (answerThreeNum <= 29)
            {
                retire = 50;
            }

            if (answerFourNum >= 1 && answerFourNum <= 4)
            {
                balance = 256000;
            }
            else if (answerFourNum >= 5 && answerFourNum <= 8)
            {
                balance = 3687105;
            }
            else if (answerFourNum >= 9 && answerFourNum <= 12)
            {
                balance = 86;
            }

            if(answerFive == "red")
            {
                car = "maserati";
            }
            else if (answerFive == "orange")
            {
                car = "corvete";
            }
            else if (answerFive == "yellow")
            {
                car = "lamborghini";
            }
            else if (answerFive == "green")
            {
                car = "ferrari";
            }
            else if (answerFive == "blue")
            {
                car = "pickup truck";
            }
            else if (answerFive == "indigo")
            {
                car = "RV";
            }
            else if (answerFive == "violet")
            {
                car = "hippy van";
            }

            if (answerSixNum == 0)
            {
                home = "Boca Raton, FL";
            }
            else if (answerSixNum == 1)
            {
                home = "Nassau, Bahamas";
            }
            else if (answerSixNum == 2)
            {
                home = "Ponta Negra,Brazil";
            }
            else if (answerSixNum == 3)
            {
                home = "Portland, Oregon";
            }
            else if (answerSixNum >= 4)
            {
                home = "Baton Rouge, LA";
            }
            else if (answerSixNum < 0)
            {
                home = "Chernobyl, Ukraine";
            }

            Console.Clear();
            Console.WriteLine("The psychic is figuring out your fortune.. press enter to continue");
            Console.ReadLine();

            Console.WriteLine(answerOne + " " + answerTwo + " will retire in " + retire + " years with $" + balance + " in the bank, a vacation home in " + home + ", and travel by " + car + "!");
        }
    }
}
