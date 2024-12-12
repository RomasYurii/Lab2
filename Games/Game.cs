using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna2.Games
{
    abstract class Game
    {
        public string OpponentName { get; private set; }

        public Game(string opponentName)
        {
            OpponentName = opponentName;
        }

        public abstract int CalculateRating();

        public override string ToString()
        {
            return $"Проти: {OpponentName} | Рейтинг на який грають: {CalculateRating()}";
        }
    }
}
