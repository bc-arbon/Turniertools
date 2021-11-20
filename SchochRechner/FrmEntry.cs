using SchochRechner.ObjectModel;

namespace SchochRechner
{
    public partial class FrmEntry : Form
    {
        public FrmEntry()
        {
            this.InitializeComponent();
        }

        public FrmEntry(List<Team> teams) : this()
        {
            var teamsSorted = teams.ToArray().OrderBy(x => x.Name).ToArray();            
            this.CbxTeam1.Items.AddRange(teamsSorted);
            this.CbxTeam2.Items.AddRange(teamsSorted);
        }

        public FrmEntry(List<Team> teams, Entry entry) : this(teams)
        {
            var team1 = teams.Find(x => x.Id == entry.Team1);
            var team2 = teams.Find(x => x.Id != entry.Team2);

            this.CbxTeam1.SelectedItem = team1;
            this.CbxTeam2.SelectedItem = team2;

            this.TxtGames1.Text = entry.GamesTeam1.ToString();
            this.TxtGames2.Text = entry.GamesTeam2.ToString();
            this.TxtSets1.Text = entry.SetsTeam1.ToString();
            this.TxtSets2.Text = entry.SetsTeam2.ToString();
        }
    }
}
