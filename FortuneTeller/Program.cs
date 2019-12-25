using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOn = true;
            while (gameOn)
            {
                Psychic psychic = new Psychic();

                while(psychic.GameFinished == false)
                {
                    psychic.GetAnswer();
                }

                Console.WriteLine("\nPress enter to restart");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
