using laboratorna2.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna2.Accounts
{
    abstract class GameAccount
    {
        public string UserName { get; private set; }
        protected int CurrentRating
        {
            get => _currentRating;

            set
            {
                if (value < 0)
                {
                    _currentRating = 1;
                }
                else
                {
                    _currentRating = value;
                }
            }
        }

        private int _currentRating;

        public int GamesCount { get; private set; }
        private List<Game> gamesHistory;

        public GameAccount(string userName)
        {
            UserName = userName;
            CurrentRating = 1; // Початковий рейтинг
            GamesCount = 0;
            gamesHistory = new List<Game>();
        }

        public virtual void WinGame(Game game)
        {
            CurrentRating += game.CalculateRating();
            GamesCount++;
            gamesHistory.Add(game);
        }

        public virtual void LoseGame(Game game)
        {
            CurrentRating -= game.CalculateRating();
            if (CurrentRating < 1)
                CurrentRating = 1;
            GamesCount++;
            gamesHistory.Add(game);
        }

        public void GetStats()
        {
            Console.WriteLine($"\nІсторія ігор для {UserName}:");
            foreach (var game in gamesHistory)
            {
                Console.WriteLine(game);
            }
        }

        public void PlayerStats()
        {
            Console.WriteLine($"\nСтатистика для {UserName}:");
            Console.WriteLine($"Рейтинг: {CurrentRating} | Ігор зіграно: {GamesCount}");
        }
    }
}
