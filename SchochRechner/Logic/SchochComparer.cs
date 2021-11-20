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

            if (team1.GamesDiff != team2.GamesDiff) return team1.GamesDiff.CompareTo(team2.GamesDiff);
            //if (team1.GameWins != team2.GameWins) return team1.GameWins.CompareTo(team2.GameWins);
            //if (team1.GameLosses != team2.GameLosses) return team1.GameLosses.CompareTo(team2.GameLosses);
            if (team1.SetDiff != team2.SetDiff) return team1.SetDiff.CompareTo(team2.SetDiff);
            //if (team1.SetWins != team2.SetWins) return team1.SetWins.CompareTo(team2.SetWins);
            //if (team1.SetLosses != team2.SetLosses) return team1.SetLosses.CompareTo(team2.SetLosses);
            if (team1.Buchholz != team2.Buchholz) return team1.Buchholz.CompareTo(team2.Buchholz);
            return team1.Feinbuchholz.CompareTo(team2.Feinbuchholz);
        }
    }
}
