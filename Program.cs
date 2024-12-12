using laboratorna2.Accounts;
using laboratorna2.Factories;
using laboratorna2.Games;
using System;
namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            GameAccount player1 = new StandardAccount("Player1");
            GameAccount player2 = new HalfLossAccount("Player2");
            GameAccount player3 = new WinStreakAccount("Player3");

            Game game1 = GameFactory.CreateGame("Standard", "Player1", 20);
            Game game2 = GameFactory.CreateGame("Training", "Player2");
            Game game3 = GameFactory.CreateGame("Standard", "Player2", 30);

            player1.WinGame(game2);
            player1.LoseGame(game3);

            player2.WinGame(game1);
            player2.LoseGame(game2);

            player3.WinGame(game1);
           // player3.PlayerStats();

            player3.WinGame(game2);
           // player3.PlayerStats();

            player3.WinGame(game1);
           // player3.PlayerStats();

            player3.WinGame(game2);
           // player3.PlayerStats();

            player3.LoseGame(game1);
           // player3.PlayerStats();

            player3.WinGame(game1);
           // player3.PlayerStats();

            player1.GetStats();
            player2.GetStats();
            player3.GetStats();

            player1.PlayerStats();
            player2.PlayerStats();
            player3.PlayerStats();
        }
    }
}