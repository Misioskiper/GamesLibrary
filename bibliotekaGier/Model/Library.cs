using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotekaGier.Model
{
    class Library
    {
        public List <Game> Games { get; private set; }

        public Library()
        {
            Games = new List<Game>();
        }

        public void AddGame(Game game)
        {
            if(!Games.Contains(game))
            {
                Games.Add(game);
            }
            
        }

        public void RemoveGame(Game game)
        {
            Games.Remove(game);
        }

        public List<Game> GetGame()
        {
            return Games;
        }

        public void ImportFromFile()
        {
            Games.Clear();
            using (var x = new StreamReader(@"D:\GamesLibrary-master\lib.txt"))
            {
                string line;
                while ((line = x.ReadLine()) != null)
                {
                    var values = line.Split('|');
                    var title = values[0];
                    var minimumAge = int.Parse(values[1]);
                    var price = decimal.Parse(values[2]);
                    var description = values[3];
                    var game = new Game(title, price, description, minimumAge);

                    AddGame(game);
                }
            }
        }

        public void SaveGamesToFile()
        {
            foreach(Game g in Games)
            {
                using (var sw = new StreamWriter(@"D:\GamesLibrary-master\lib.txt"))
                {
                    sw.WriteLine("{0}|{1}|{2}|{3}", g.Title, g.MinimumAge, g.Price, g.Description);
                }
            }
        }
    }
}
