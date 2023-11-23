using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace YashProjectNewBL
{
    public class GameHomePage
    {
        public string Game1;
        public string Game2;
        public int Score;
        public bool ScoreCard;

        public GameHomePage(string Game1, string Game2, int Score, bool ScoreCard)
        {
            this.Game1 =Game1;
            this.Game2 = Game2;
            this.Score = Score;
            this.ScoreCard = ScoreCard;
        }

        public string GameOver()
        {
            string response = string.Empty;
            response += string.Format("GameName :"+ Game1);
            response += string.Format("\nGameName 2:"+ Game2);
            response += string.Format("\nScore :" + Score);
            response += string.Format("\n ScoreCard:" + ScoreCard);
            return response;
        }
    }
}
