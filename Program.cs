using System;

namespace rockPaperScissors_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var isPlaying = true;

            while (isPlaying)
            {
                Console.Clear();

                Console.WriteLine("Lets play a game of Rock, Paper, Scissors!");
                Console.WriteLine("Pick one: Rock, Paper, or Scissors?");

                var userPick = Console.ReadLine().ToLower();
                while (userPick != "rock" && userPick != "scissors" && userPick != "paper")
                {
                    Console.WriteLine("That is not a valid option! Pick again!");
                    userPick = Console.ReadLine().ToLower();
                }

                var randomize = new Random();
                string[] compPick = { "rock", "paper", "scissors" };
                int compIndex = randomize.Next(compPick.Length);
                var opponent = compPick[compIndex];

                Console.WriteLine($"Your opponent chose {opponent}!");

                if (userPick == "rock" && opponent == "rock")
                {
                    Console.WriteLine("It's a tie!");
                }
                else if (userPick == "rock" && opponent == "scissors")
                {
                    Console.WriteLine("You win!");
                }
                else if (userPick == "rock" && opponent == "paper")
                {
                    Console.WriteLine("You lose!");
                }
                else if (userPick == "paper" && opponent == "rock")
                {
                    Console.WriteLine("You win!");
                }
                else if (userPick == "paper" && opponent == "scissors")
                {
                    Console.WriteLine("You lose!");
                }
                else if (userPick == "scissors" && opponent == "paper")
                {
                    Console.WriteLine("You win!");
                }
                else if (userPick == "scissors" && opponent == "rock")
                {
                    Console.WriteLine("You lose!");
                }

                Console.WriteLine("Do you want to play again? Yes or No?");
                var keepPlaying = Console.ReadLine().ToLower();

                if (keepPlaying != "yes" && keepPlaying != "no")
                {
                    Console.WriteLine("That's not a valid option! Do you want to play again?");
                    keepPlaying = Console.ReadLine().ToLower();
                }
                else if (keepPlaying == "no")
                {
                    isPlaying = false;
                }
            }
        }
    }
}
