using System;

namespace rockPaperScissors_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play a game of Rock, Paper, Scissors!");
            Console.WriteLine("Pick one: Rock, Paper, or Scissors?");

            var userPick = Console.ReadLine().ToLower();
            if (userPick != "rock" || userPick != "scissors" || userPick != "paper")
            {
                Console.WriteLine("That is not a valid option! Pick again!");
                userPick = Console.ReadLine().ToLower();
            }


        }
    }
}
