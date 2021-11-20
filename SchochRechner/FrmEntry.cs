using SchochRechner.ObjectModel;

namespace SchochRechner
{
    public partial class FrmEntry : Form
    {
        public FrmEntry()
        {
            this.InitializeComponent();
        }

        public int Team1 { get { return ((Team)this.CbxTeam1.SelectedItem).Id; } }
        public int Team2 { get { return ((Team)this.CbxTeam2.SelectedItem).Id; } }
        public int Round { get { return Convert.ToInt32(this.TxtRound.Text); } }
        public int Games1 { get { return Convert.ToInt32(this.TxtGames1.Text); } }
        public int Games2 { get { return Convert.ToInt32(this.TxtGames2.Text); } }
        public int Sets1 { get { return Convert.ToInt32(this.TxtSets1.Text); } }
        public int Sets2 { get { return Convert.ToInt32(this.TxtSets2.Text); } }

        public FrmEntry(List<Team> teams) : this()
        {
            var teamsSorted = teams.ToArray().OrderBy(x => x.Name).ToArray();            
            this.CbxTeam1.Items.AddRange(teamsSorted);
            this.CbxTeam2.Items.AddRange(teamsSorted);
        }

        public FrmEntry(List<Team> teams, Entry entry) : this(teams)
        {
            var team1 = teams.Find(x => x.Id == entry.Team1);
            var team2 = teams.Find(x => x.Id == entry.Team2);

            this.CbxTeam1.SelectedItem = team1;
            this.CbxTeam2.SelectedItem = team2;

            this.TxtRound.Text = entry.Round.ToString();
            this.TxtGames1.Text = entry.Games1.ToString();
            this.TxtGames2.Text = entry.Games2.ToString();
            this.TxtSets1.Text = entry.Sets1.ToString();
            this.TxtSets2.Text = entry.Sets2.ToString();
        }
    }
}
