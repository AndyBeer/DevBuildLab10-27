using System;

namespace DevBuildLab10_27
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            Console.WriteLine("Let's play some Rock, Paper, Scissors!\n");
            
            RPSApp game = new RPSApp();

            while (keepGoing)
            {
                game.Play();
                keepGoing = ContinueLoop($"Would you like to try again {game.User.Name}? [y] or [n]: ");
            }

            Console.WriteLine($"\nTotal games: {game.TimesPlayed} - Number of games resulting in a draw: {game.TimesPlayed - game.Wins - game.Losses}\n");
            Console.WriteLine($"{game.User.Name}'s Wins: {game.Wins}");
            Console.WriteLine($"{game.User.Name}'s Losses: {game.Losses}\n");
            
            Console.WriteLine($"Goodbye!  Thanks for playing {game.User.Name}.");
        }
        public static bool ContinueLoop(string question)
        {
            string response = GetInput(question);
            if (response.ToLower().Trim() == "y")

            {
                return true;
            }
            else if (response.ToLower().Trim() == "n")

            {
                return false;
            }
            else
            { Console.WriteLine("Please respond with either [y] or [n]\n"); }
            return ContinueLoop(question);
        }
        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string response = Console.ReadLine();
            return response;
        }
    }
}
