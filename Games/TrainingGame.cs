using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna2.Games
{
    class TrainingGame : Game
    {
        public TrainingGame(string opponentName) : base(opponentName) { }

        public override int CalculateRating()
        {
            return 0; 
        }
    }
}
