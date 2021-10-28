using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildLab10_27
{
    class UserPlayer : Player
    {
        public UserPlayer()
        {
            this.Name = Name;

        }
        
        public override RPSEnum GenerateRPS()
        {
            //put stuff here to actually generate RPS
            //have user select R, P, or S
            //if we get anything else, ask again
            Console.WriteLine("Rock, Paper, or Scissors?");
            Console.WriteLine("(or [r], [p], or [s] for short.)\n");
            string response = Console.ReadLine();

            switch (response.ToLower().Trim())
            {
                case "r":
                    {
                        return RPSEnum.rock;  
                    }
                case "rock":
                    {
                        return RPSEnum.rock;
                    }
                case "p":
                    {
                        return RPSEnum.paper;
                    }
                case "paper":
                    {
                        return RPSEnum.paper;
                    }
                case "s":
                    {
                            return RPSEnum.scissors;
                    }
                case "scissors":
                    {
                        return RPSEnum.scissors;
                    }
                default:
                    {
                        Console.WriteLine("That is not a valid input.  Please try again!\n");
                        return GenerateRPS();
                    }
            }
        }
    }
}
