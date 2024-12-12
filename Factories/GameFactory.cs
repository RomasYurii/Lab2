using laboratorna2.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna2.Factories
{
    class GameFactory
    {
        public static Game CreateGame(string type, string opponentName, int rating = 0)
        {
            return type switch
            {
                "Standard" => new StandardGame(opponentName, rating),
                "Training" => new TrainingGame(opponentName),     
                _ => throw new ArgumentException("Невідомий тип гри")
            };
        }
    }
}
