using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportskiRezultati
{
    public class Game<T>
    {
        public string homeTeam { get; set; }
        public string visitorTeam { get; set; }
        public int scoreHome { get; set; }
        public int scoreVisitor { get; set; }
        public T detailsHome { get; set; }
        public T detailsVisitor { get; set; }
        public DateTime date { get; set; }
        public Game<Football> FootballGame;
        public Game<Basketball> BasketGame;
        public List<Details<int, string>> detaliD;
        public List<Details<int, string>> detaliG;

        public Game(string homeTeam, string visitorTeam, int scoreHome, int scoreVisitor, T detailsHome, T detailsVisitor, DateTime date,
            Game<Football> FootballGame,Game<Basketball> BasketGame,List<Details<int,string>> detaliD, List<Details<int, string>> detaliG)
        {
            this.homeTeam = homeTeam;
            this.visitorTeam = visitorTeam;
            this.scoreHome = scoreHome;
            this.scoreVisitor = scoreVisitor;
            this.detailsHome = detailsHome;
            this.detailsVisitor = detailsVisitor;
            this.date = date;
            this.FootballGame = FootballGame;
            this.BasketGame = BasketGame;
            detaliD = new List<Details<int, string>>();
            detaliG = new List<Details<int, string>>();
        }

        public Game()
        {
        }
    }
}
