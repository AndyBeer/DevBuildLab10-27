using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildLab10_27
{
    abstract class Player
    {

        public string Name { get; set; }
        public RPSEnum RPS { get; set; }

        public abstract RPSEnum GenerateRPS();
     
    }
    
}
