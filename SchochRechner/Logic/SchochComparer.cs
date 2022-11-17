using SchochRechner.ObjectModel;

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

            //if (team1.GameDiff != team2.GameDiff) return team1.GameDiff.CompareTo(team2.GameDiff);
            if (team1.GamesWon != team2.GamesWon) return team1.GamesWon.CompareTo(team2.GamesWon);
            if (team1.GamesLost != team2.GamesLost) return team1.GamesLost.CompareTo(team2.GamesLost);
            //if (team1.SetDiff != team2.SetDiff) return team1.SetDiff.CompareTo(team2.SetDiff);
            if (team1.SetsWon != team2.SetsWon) return team1.SetsWon.CompareTo(team2.SetsWon);
            if (team1.SetsLost != team2.SetsLost) return team1.SetsLost.CompareTo(team2.SetsLost);
            if (team1.Buchholz != team2.Buchholz) return team1.Buchholz.CompareTo(team2.Buchholz);
            if (team1.PointsWon != team2.PointsWon) return team1.PointsWon.CompareTo(team2.PointsWon);
            if (team1.PointsLost != team2.PointsLost) return team1.PointsLost.CompareTo(team2.PointsLost);
            return team1.Feinbuchholz.CompareTo(team2.Feinbuchholz);
        }
    }
}
