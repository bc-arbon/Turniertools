using SchochRechner.Logic;

namespace SchochRechner
{
    public partial class FrmDisplay : Form
    {
        private readonly SchochManager schochManager;
        private string displayGroupName = string.Empty;

        public FrmDisplay()
        {
            this.InitializeComponent();
            this.schochManager = new SchochManager();            
        }

        public FrmDisplay(SchochManager schochManager) : this()
        {
            this.schochManager = schochManager;
        }

        public void ShowRanking()
        {
            this.EnsureDisplayGroup();
            this.schochManager.CalculateRanking(this.displayGroupName);
            this.TpgRanking.Text = "Rangliste – " + this.displayGroupName;
            this.LvwRanking.Items.Clear();
            var rank = 1;
            foreach (var team in this.schochManager.GetTeams(this.displayGroupName))
            {
                if (team.Id == 99)
                {
                    // Skip the Freilos, does only create confusion among the players...
                    continue;
                }

                var item = new ListViewItem(string.Empty);
                item.SubItems.Add(rank.ToString());
                item.SubItems.Add(team.Name);
                item.SubItems.Add(team.Rounds.ToString());
                item.SubItems.Add(team.GamesWon.ToString());
                item.SubItems.Add(team.Buchholz.ToString());
                item.SubItems.Add(team.GamesWon.ToString() + ":" + team.GamesLost.ToString());
                item.SubItems.Add(team.GamesDiffText);
                item.SubItems.Add(team.SetsWon.ToString() + ":" + team.SetsLost.ToString());
                item.SubItems.Add(team.SetsDiffText);
                item.SubItems.Add(team.PointsWon.ToString() + ":" + team.PointsLost.ToString());
                item.SubItems.Add(team.PointsDiffText);
                //item.SubItems.Add(team.Feinbuchholz.ToString());

                this.LvwRanking.Items.Add(item);
                rank++;
            }
        }

        public void ShowDraw()
        {
            this.EnsureDisplayGroup();
            var round = this.schochManager.GetRoundForGroup(this.displayGroupName);
            var entries = this.schochManager.GetEntries(this.displayGroupName);
            this.TpgDraw.Text = "Auslosung – " + this.displayGroupName;
            this.LblDrawsRound.Text = $"{this.displayGroupName} – Runde {round.RoundActual}";

            this.LvwDraw.Items.Clear();
            foreach (var draw in round.Draws)
            {
                if (draw.Team1 == null || draw.Team2 == null)
                {
                    continue;
                }

                var item = new ListViewItem(string.Empty);
                item.SubItems.Add(draw.Court == 0 ? string.Empty : draw.Court.ToString());
                item.SubItems.Add(draw.Team1.Name);
                item.SubItems.Add("-");
                item.SubItems.Add(draw.Team2.Name);
                var entry = entries.FirstOrDefault(e => e.Team1 == draw.Team1.Id && e.Team2 == draw.Team2.Id);
                item.SubItems.Add(entry != null ? $"{entry.Games1}:{entry.Games2}" : string.Empty);
                this.LvwDraw.Items.Add(item);
            }
        }

        private void LvwRanking_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if ((e.ItemIndex % 2) == 1)
            {
                e.Item.BackColor = Color.FromArgb(220, 220, 220);
                e.Item.UseItemStyleForSubItems = true;
            }
        }

        private void LvwRanking_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void EnsureDisplayGroup()
        {
            if (!this.schochManager.Groups.Contains(this.displayGroupName, StringComparer.OrdinalIgnoreCase))
            {
                this.displayGroupName = this.schochManager.Groups[0];
            }
        }

        private void FrmDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void TmrChangeView_Tick(object sender, EventArgs e)
        {
            this.EnsureDisplayGroup();
            if (this.TclDisplay.SelectedTab == this.TpgDraw)
            {
                var groupIndex = this.schochManager.Groups.ToList().FindIndex(
                    group => string.Equals(group, this.displayGroupName, StringComparison.OrdinalIgnoreCase));
                this.displayGroupName = this.schochManager.Groups[(groupIndex + 1) % this.schochManager.Groups.Count];
                this.TclDisplay.SelectedTab = this.TpgRanking;
                this.ShowRanking();
            }
            else
            {
                this.TclDisplay.SelectedTab = this.TpgDraw;
                this.ShowDraw();
            }
        }
    }
}