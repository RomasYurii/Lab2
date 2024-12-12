using laboratorna2.Games;
using laboratorna2.Accounts;
using laboratorna2.Factories;
using lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna2.Accounts
{
    class WinStreakAccount : GameAccount
    {
        private int winStreak;

        public WinStreakAccount(string userName) : base(userName)
        {
            winStreak = 0;
        }

        public override void WinGame(Game game)
        {
            winStreak++;
            int bonus = winStreak > 3 ? 10 : 0;
            CurrentRating += game.CalculateRating() + bonus;
            base.WinGame(game);
        }

        public override void LoseGame(Game game)
        {
            winStreak = 0; // Скидання серії перемог
            base.LoseGame(game);
        }
    }
}
