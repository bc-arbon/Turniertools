using SchochRechner.Logic;
using SchochRechner.ObjectModel;
using System.Drawing.Printing;

namespace SchochRechner
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            this.InitializeComponent();

            this.frmDisplay = new FrmDisplay(this.schochManager);
        }

        private readonly SchochManager schochManager = new();
        private readonly FrmDisplay frmDisplay;

        private void ShowAll()
        {
            this.ShowEntries();
            this.ShowRanking();
            this.frmDisplay.ShowRanking();
        }

        private void ShowRanking()
        {
            this.LvwRanking.Items.Clear();
            var rank = 1;
            foreach (var team in this.schochManager.Teams)
            {
                var item = new ListViewItem(rank.ToString());
                item.SubItems.Add(team.Id.ToString());
                item.SubItems.Add(team.Name);
                item.SubItems.Add(team.GamesWon.ToString());
                item.SubItems.Add(team.Rounds.ToString());
                item.SubItems.Add(team.Buchholz.ToString());
                item.SubItems.Add(team.Feinbuchholz.ToString());
                item.SubItems.Add(team.GamesWon.ToString() + ":" + team.GamesLost.ToString());
                item.SubItems.Add(team.GamesDiffText);
                item.SubItems.Add(team.SetsWon.ToString() + ":" + team.SetsLost.ToString());
                item.SubItems.Add(team.SetsDiffText);
                item.SubItems.Add(team.PointsWon.ToString() + ":" + team.PointsLost.ToString());
                item.SubItems.Add(team.PointsDiffText);
                this.LvwRanking.Items.Add(item);
                rank++;
            }
        }

        private void ShowEntries()
        {
            this.LvwEntries.Items.Clear();

            foreach (var entry in this.schochManager.Entries)
            {
                var item = new ListViewItem(entry.Round.ToString());
                item.Tag = entry;
                var team1 = this.schochManager.Teams.Find(x => x.Id == entry.Team1);
                var team2 = this.schochManager.Teams.Find(x => x.Id == entry.Team2);
                item.SubItems.Add(team1 != null ? team1.Name : string.Empty);
                item.SubItems.Add(team2 != null ? team2.Name : string.Empty);
                item.SubItems.Add(entry.Games1 + ":" + entry.Games2);
                item.SubItems.Add(entry.Sets1 + ":" + entry.Sets2);
                item.SubItems.Add(entry.Points1 + ":" + entry.Points2);
                this.LvwEntries.Items.Add(item);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var frmEntry = new FrmEntry(this.schochManager.Teams);
            if (frmEntry.ShowDialog() == DialogResult.OK)
            {
                this.schochManager.AddEntry(Helpers.CreateEntry(frmEntry));
                this.schochManager.CalculateRanking();
                this.schochManager.Save();
                this.ShowAll();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (this.LvwEntries.SelectedItems.Count == 0)
            {
                return;
            }

            var entry = (Entry)this.LvwEntries.SelectedItems[0].Tag;
            var frmEntry = new FrmEntry(this.schochManager.Teams, entry);
            if (frmEntry.ShowDialog() == DialogResult.OK)
            {
                Helpers.UpdateEntry(entry, frmEntry);

                this.schochManager.CalculateRanking();
                this.schochManager.Save();
                this.ShowAll();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this.LvwEntries.SelectedItems.Count == 0)
            {
                return;
            }

            var entry = (Entry)this.LvwEntries.SelectedItems[0].Tag;
            this.schochManager.DeleteEntry(entry);
            this.schochManager.CalculateRanking();
            this.schochManager.Save();
            this.ShowAll();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.schochManager.Save();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.schochManager.Load();
            //this.schochManager.AddExampleData();
            this.schochManager.AddExampleData2();

            this.frmDisplay.Show();
            this.ShowAll();
        }

        private void BtnTeams_Click(object sender, EventArgs e)
        {
            var frmTeams = new FrmTeams(this.schochManager);
            frmTeams.ShowDialog();

            this.ShowAll();
        }

        private void LvwRanking_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if ((e.ItemIndex % 2) == 1)
            {
                e.Item.BackColor = Color.FromArgb(230, 230, 255);
                e.Item.UseItemStyleForSubItems = true;
            }
        }

        private void LvwRanking_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void LvwEntries_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if ((e.ItemIndex % 2) == 1)
            {
                e.Item.BackColor = Color.FromArgb(230, 230, 255);
                e.Item.UseItemStyleForSubItems = true;
            }
        }

        private void LvwEntries_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(this.LvwRanking.Width, this.LvwRanking.Height);

            this.LvwRanking.DrawToBitmap(bitmap, new Rectangle(0, 0, this.LvwRanking.Width, this.LvwRanking.Height));

            var pd = new PrintDocument();

            pd.PrintPage += (s, e) => e.Graphics.DrawImage(bitmap, 100, 100);

            var preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog();
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            this.frmDisplay.Show();
        }

        private void BtnAddDraw_Click(object sender, EventArgs e)
        {
            var round = this.schochManager.CreateDraw();

            var group = new ListViewGroup("Runde " + round.RoundActual);
            this.LvwDraws.Groups.Add(group);

            foreach (var draw in round.Draws)
            {
                var item = new ListViewItem(Helpers.OpponentsAsList(draw.Team1.Opponents));
                item.SubItems.Add("(" + draw.Team1.Id + ") " + draw.Team1.Name);
                item.SubItems.Add(draw.Team1.GamesWon.ToString());
                item.SubItems.Add(draw.Team2.GamesWon.ToString());
                item.SubItems.Add("(" + draw.Team2.Id + ") " + draw.Team2.Name);
                item.SubItems.Add(Helpers.OpponentsAsList(draw.Team2.Opponents));
                item.Tag = draw;
                group.Items.Add(item);
                this.LvwDraws.Items.Add(item);
                //Thread.Sleep(500);
                //Application.DoEvents();
            }
        }

        private void LvwDraws_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // TBD, works for testing
            if (this.LvwDraws.SelectedItems.Count == 0)
            {
                return;
            }

            var draw = (Draw)this.LvwDraws.SelectedItems[0].Tag;
            var frmMatchcard = new FrmMatchcard(draw);
            frmMatchcard.ShowDialog();
        }

        private void BtnClearDraws_Click(object sender, EventArgs e)
        {
            this.LvwDraws.Items.Clear();
            this.LvwDraws.Groups.Clear();
        }

        private void LvwDraws_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if ((e.ItemIndex % 2) == 1)
            {
                e.Item.BackColor = Color.FromArgb(230, 230, 255);
                e.Item.UseItemStyleForSubItems = true;
            }
        }

        private void LvwDraws_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}