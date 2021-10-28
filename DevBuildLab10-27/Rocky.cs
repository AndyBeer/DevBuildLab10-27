using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildLab10_27
{
    class Rocky : Player
    {
        public Rocky()
        {
            Name = "Rocky";
        }
        public override RPSEnum GenerateRPS()
        {
            return RPSEnum.rock; 
        }
    }
}
