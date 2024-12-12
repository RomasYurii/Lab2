using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna2.Games
{
    class OnePlayerGame : Game
    {
        private int rating;

        public OnePlayerGame(string opponentName, int rating) : base(opponentName)
        {
            this.rating = rating;
        }

        public override int CalculateRating()
        {
            return rating;
        }
    }
}
