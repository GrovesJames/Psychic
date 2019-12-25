using System;
using System.Collections.Generic;
using System.Text;

namespace FortuneTeller
{
    class Psychic
    {
        public int Retire { get; set; }
        public int Balance { get; set; }
        public string Car { get; set; }
        public string Home { get; set; }
        public string Answer { get; set; }
        public bool GameFinished { get; set; }

        public string AnswerOne { get; set; }
        public string AnswerTwo { get; set; }
        public int AnswerThreeNum { get; set; }
        public int AnswerFourNum { get; set; }
        public string AnswerFive { get; set; }
        public int AnswerSixNum { get; set; }

        public Psychic()
        {
            GameFinished = false;

            Console.WriteLine("What's your first name?");
            AnswerOne = Console.ReadLine();

            Console.WriteLine("\nWhat's your last name?");
            AnswerTwo = Console.ReadLine();

            Console.WriteLine("\nHow old are you?");
            string answerThree = Console.ReadLine();
            AnswerThreeNum = Convert.ToInt32(answerThree);

            Console.WriteLine("\nWhat's the number of the month you were born?");
            string answerFour = Console.ReadLine();
            AnswerFourNum = Convert.ToInt32(answerFour);

            Console.WriteLine("\nWhat's your favorite color out of: Red, Orange, Yellow, Green, Blue, Indigo & Violet?");
            AnswerFive = Console.ReadLine().ToLower();

            Console.WriteLine("\nHow many siblings do you have?");
            string answerSix = Console.ReadLine();
            AnswerSixNum = Convert.ToInt32(answerSix);
        }

        public void GetAnswer()
        {
            //check answer three
            if (AnswerThreeNum >= 30)
            {
                Retire = 35;
            }
            else if (AnswerThreeNum <= 29)
            {
                Retire = 50;
            }
            //check answer four
            if (AnswerFourNum >= 1 && AnswerFourNum <= 4)
            {
                Balance = 256000;
            }
            else if (AnswerFourNum >= 5 && AnswerFourNum <= 8)
            {
                Balance = 3687105;
            }
            else if (AnswerFourNum >= 9 && AnswerFourNum <= 12)
            {
                Balance = 86;
            }
            //check answer five
            if (AnswerFive == "red")
            {
                Car = "maserati";
            }
            else if (AnswerFive == "orange")
            {
                Car = "corvete";
            }
            else if (AnswerFive == "yellow")
            {
                Car = "lamborghini";
            }
            else if (AnswerFive == "green")
            {
                Car = "ferrari";
            }
            else if (AnswerFive == "blue")
            {
                Car = "pickup truck";
            }
            else if (AnswerFive == "indigo")
            {
                Car = "RV";
            }
            else if (AnswerFive == "violet")
            {
                Car = "hippy van";
            }
            //check answer six
            if (AnswerSixNum == 0)
            {
                Home = "Boca Raton, FL";
            }
            else if (AnswerSixNum == 1)
            {
                Home = "Nassau, Bahamas";
            }
            else if (AnswerSixNum == 2)
            {
                Home = "Ponta Negra,Brazil";
            }
            else if (AnswerSixNum == 3)
            {
                Home = "Portland, Oregon";
            }
            else if (AnswerSixNum >= 4)
            {
                Home = "Baton Rouge, LA";
            }
            else if (AnswerSixNum < 0)
            {
                Home = "Chernobyl, Ukraine";
            }

            Console.Clear();
            Console.WriteLine("The psychic is figuring out your fortune.. press enter to continue");
            Console.ReadLine();

            Console.WriteLine(AnswerOne + " " + AnswerTwo + " will retire in " + Retire + " years with $" + Balance + " in the bank, a vacation home in " + Home + ", and travel by " + Car + "!");
            GameFinished = true;
        }
    }
}
