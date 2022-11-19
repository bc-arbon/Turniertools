using SchochRechner.ObjectModel;
using System.Runtime.CompilerServices;

namespace SchochRechner.Logic
{
    internal class SchochComparer : IComparer<Team>
    {
        public int Compare(Team? x, Team? y)
        {
            if (x == null) return 1;
            if (y == null) return -1;

            // Swapping x and y here to get a descending ranking
            var team1 = (Team)y;
            var team2 = (Team)x;

            // Put the Freilos team to the end
            if (team1.Name == "Freilos") return -1;
            if (team2.Name == "Freilos") return 1;


            if (team1.GamesWon != team2.GamesWon) return team1.GamesWon.CompareTo(team2.GamesWon);
            if (team1.Buchholz != team2.Buchholz) return team1.Buchholz.CompareTo(team2.Buchholz);
            if (team1.GamesDiff != team2.GamesDiff) return team1.GamesDiff.CompareTo(team2.GamesDiff);
            if (team1.GamesLost != team2.GamesLost) return team2.GamesLost.CompareTo(team1.GamesLost);
            if (team1.Opponents.Contains(99)) return -1;
            if (team2.Opponents.Contains(99)) return 1;
            //if (team1.Buchholz != team2.Buchholz) return team1.Buchholz.CompareTo(team2.Buchholz);
            if (team1.SetsDiff != team2.SetsDiff) return team1.SetsDiff.CompareTo(team2.SetsDiff);
            if (team1.SetsWon != team2.SetsWon) return team2.SetsWon.CompareTo(team1.SetsWon);
            if (team1.SetsLost != team2.SetsLost) return team2.SetsLost.CompareTo(team1.SetsLost);
            if (team1.PointsDiff != team2.PointsDiff) return team1.PointsDiff.CompareTo(team2.PointsDiff);
            if (team1.PointsWon != team2.PointsWon) return team2.PointsWon.CompareTo(team1.PointsWon);
            //if (team1.PointsLost != team2.PointsLost) return team1.PointsLost.CompareTo(team2.PointsLost);
            //return team1.Buchholz.CompareTo(team2.Buchholz);
            return team2.PointsLost.CompareTo(team1.PointsLost);
        }
    }
}
