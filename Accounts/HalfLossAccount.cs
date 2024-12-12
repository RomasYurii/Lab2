using laboratorna2.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna2.Accounts
{
    class HalfLossAccount : GameAccount
    {
        public HalfLossAccount(string userName) : base(userName) { }

        public override void LoseGame(Game game)
        {
            int ratingChange = game.CalculateRating() / 2;
            CurrentRating -= ratingChange;
            if (CurrentRating < 1)
                CurrentRating = 1;
            base.LoseGame(game);
        }
    }
}
