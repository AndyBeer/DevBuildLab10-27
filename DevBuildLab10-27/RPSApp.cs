using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildLab10_27
{
    class RPSApp
    {
        public UserPlayer User { get; set; } = new UserPlayer();
        //we leave this blank since user selects this (later on)
        public Player Opponent { get; set; }
        public int TimesPlayed { get; set; } = 0;
        public int Wins { get; set; } = 0;
        public int Losses { get; set; } = 0;

        public RPSApp()
        {
            Console.WriteLine("What is your name?");
            User.Name = Console.ReadLine();
            Console.WriteLine($"Welcome {User.Name}!\nWho do you want to play against?\n[1] for Randa, [2] for Rocky.");
            OppoSelect();
        }
        public Player OppoSelect()
        {
            Player randa = new Randa();
            Player rocky = new Rocky();
            string response = Console.ReadLine();

            switch (response.Trim())
            {
                case "1":
                    {
                        Console.WriteLine("You selected Randa.\n\nLet's play!\n");
                        return Opponent = randa;
                    }
                case "2":
                    {
                        Console.WriteLine("You selected Rocky.\n\nLet's play!\n");
                        return Opponent = rocky;  
                    }
                default:
                    {
                        Console.WriteLine("That is not a valid choice - please select [1] for Randa and [2] for Rocky:");
                        return OppoSelect();
                    }
            }
        }

        public Player Play()
        {
            RPSEnum user = User.GenerateRPS();
            RPSEnum oppo = Opponent.GenerateRPS();
            
            if (user == oppo)
            {
                TimesPlayed++;
                Console.WriteLine($"\n{Opponent.Name}: " + oppo);
                Console.WriteLine($"{User.Name}: " + user);
                Console.WriteLine($"Draw!  Let's try again.");
                return Play();
            }
            else if (user == RPSEnum.rock && oppo == RPSEnum.paper)
            {
                TimesPlayed++;
                Losses++;
                Console.WriteLine($"\n{Opponent.Name}: " + oppo);
                Console.WriteLine($"{User.Name}: " + user);
                Console.WriteLine($"You lose.  Good day sir/madam.");
                return Opponent;
            }
            else if (user == RPSEnum.rock && oppo == RPSEnum.scissors)
            {
                TimesPlayed++;
                Wins++;
                Console.WriteLine($"\n{Opponent.Name}: " + oppo);
                Console.WriteLine($"{User.Name}: " + user);
                Console.WriteLine($"You win!");
                return User;
            }
            else if (user == RPSEnum.paper && oppo == RPSEnum.scissors)
            {
                TimesPlayed++;
                Losses++;
                Console.WriteLine($"\n{Opponent.Name}: " + oppo);
                Console.WriteLine($"{User.Name}: " + user);
                Console.WriteLine($"You lose.  Good day sir/madam.");
                return Opponent;
            }
            else if (user == RPSEnum.paper && oppo == RPSEnum.rock)
            {
                TimesPlayed++;
                Wins++;
                Console.WriteLine($"\n{Opponent.Name}: " + oppo);
                Console.WriteLine($"{User.Name}: " + user);
                Console.WriteLine($"You win!");
                return User;
            }
            else if (user == RPSEnum.scissors && oppo == RPSEnum.rock)
            {
                TimesPlayed++;
                Losses++;
                Console.WriteLine($"\n{Opponent.Name}: " + oppo);
                Console.WriteLine($"{User.Name}: " + user);
                Console.WriteLine($"You lose.  Good day sir/madam.");
                return Opponent;
            }
            else if (user == RPSEnum.scissors && oppo == RPSEnum.paper)
            {
                TimesPlayed++;
                Wins++;
                Console.WriteLine($"\n{Opponent.Name}: " + oppo);
                Console.WriteLine($"{User.Name}: " + user);
                Console.WriteLine($"You win!");
                return User;
            }
            else
            { return Play(); }
        }
    }
}
