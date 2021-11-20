namespace SchochRechner
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            this.InitializeComponent();
            this.ShowRanking();
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
    }
}