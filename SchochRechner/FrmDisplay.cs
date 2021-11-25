using SchochRechner.Logic;

namespace SchochRechner
{
    public partial class FrmDisplay : Form
    {
        private readonly SchochManager schochManager;

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
            this.LvwRanking.Items.Clear();
            var rank = 1;
            foreach (var team in this.schochManager.Teams)
            {
                var item = new ListViewItem(string.Empty);
                item.SubItems.Add(rank.ToString());
                item.SubItems.Add(team.Name);
                item.SubItems.Add(team.Rounds.ToString());
                item.SubItems.Add(team.GameWins.ToString() + ":" + team.GameLosses.ToString());
                item.SubItems.Add(team.GameDiffText);
                item.SubItems.Add(team.SetWins.ToString() + ":" + team.SetLosses.ToString());
                item.SubItems.Add(team.SetDiffText);
                item.SubItems.Add(team.Buchholz.ToString());
                item.SubItems.Add(team.Feinbuchholz.ToString());
                
                this.LvwRanking.Items.Add(item);
                rank++;
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

        private void FrmDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
