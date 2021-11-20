namespace SchochRechner
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            this.InitializeComponent();
            this.ShowRanking();
            this.ShowEntries();
        }

        private SchochManager schochManager = new SchochManager();

        private void ShowRanking()
        {
            this.LvwRanking.Items.Clear();

            foreach (var team in this.schochManager.Teams)
            {
                var item = new ListViewItem(team.Name);
                item.SubItems.Add(team.Rounds.ToString());
                item.SubItems.Add(team.GameWins.ToString());
                item.SubItems.Add(team.GameLosses.ToString());
                item.SubItems.Add(team.GamesDiff.ToString());
                item.SubItems.Add(team.SetWins.ToString());
                item.SubItems.Add(team.SetLosses.ToString());
                item.SubItems.Add(team.SetDiff.ToString());
                item.SubItems.Add(team.Buchholz.ToString());
                item.SubItems.Add(team.Feinbuchholz.ToString());
                this.LvwRanking.Items.Add(item);
            }            
        }

        private void ShowEntries()
        {
            this.listView1.Items.Clear();

            foreach (var entry in this.schochManager.Entries)
            {
                var item = new ListViewItem(entry.Round.ToString());
                var team1 = this.schochManager.Teams.Find(x => x.Id == entry.Team1);
                var team2 = this.schochManager.Teams.Find(x => x.Id == entry.Team2);
                item.SubItems.Add(team1.Name);
                item.SubItems.Add(team2.Name);
                item.SubItems.Add(entry.GamesTeam1 + ":" + entry.GamesTeam2);
                item.SubItems.Add(entry.SetsTeam1 + ":" + entry.SetsTeam2);
                this.listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bla = new FrmEntry(this.schochManager.Teams);
            bla.ShowDialog();
        }
    }
}