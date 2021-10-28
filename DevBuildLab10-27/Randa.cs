using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildLab10_27
{
    class Randa : Player
    {
        public Randa()
        {
            Name = "Randa";
        }
        public override RPSEnum GenerateRPS()
        {
            Random random = new Random();
            int i = random.Next(0, 3);
            RPSEnum randaChoice;  //not sure if this needs to be addressed, but I get why the warning is popping up
            if (i == 0)
            {
                return randaChoice = RPSEnum.rock;
            }
            else if (i == 1)
            {
                return randaChoice = RPSEnum.paper;
            }
            else if (i == 2)
            {
                return randaChoice = RPSEnum.scissors;
            }
            else { return GenerateRPS(); }
        }
    }
}
