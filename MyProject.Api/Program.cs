using System.Runtime.CompilerServices;
using YashProjectNewBL;

namespace MyProjectPL.Api
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Game1 = "Gta";
            bool ScoreCard = true;
            string Game2 = "Nfs";
            int score1 = 4;
            var score2 = 5;
            GameHomePage test = new GameHomePage(Game1, Game2, score1, ScoreCard);

            string test2 =test.GameOver();
            Console.WriteLine( $"{test2}");
        }
    }
}