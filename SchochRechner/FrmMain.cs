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
                item.SubItems.Add(team.Rounds.ToString());
                item.SubItems.Add(team.GameWins.ToString());
                item.SubItems.Add(team.GameLosses.ToString());
                item.SubItems.Add(team.GameDiffText);
                item.SubItems.Add(team.SetWins.ToString());
                item.SubItems.Add(team.SetLosses.ToString());
                item.SubItems.Add(team.SetDiffText);
                item.SubItems.Add(team.Buchholz.ToString());
                item.SubItems.Add(team.Feinbuchholz.ToString());
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
                this.LvwEntries.Items.Add(item);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var frmEntry = new FrmEntry(this.schochManager.Teams);
            if (frmEntry.ShowDialog() == DialogResult.OK)
            {
                this.schochManager.AddEntry(frmEntry.Round, frmEntry.Team1, frmEntry.Team2, frmEntry.Games1, frmEntry.Games2, frmEntry.Sets1, frmEntry.Sets2);
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
                entry.Round = frmEntry.Round;
                entry.Team1 = frmEntry.Team1;
                entry.Team2 = frmEntry.Team2;
                entry.Games1 = frmEntry.Games1;
                entry.Games2 = frmEntry.Games2;
                entry.Sets1 = frmEntry.Sets1;
                entry.Sets2 = frmEntry.Sets2;

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

            this.frmDisplay.Show();
            this.ShowAll();                        
        }

        private void BtnTeams_Click(object sender, EventArgs e)
        {
            var frmTeams = new FrmTeams(this.schochManager);
            frmTeams.ShowDialog();

            this.schochManager.CalculateRanking();
            this.schochManager.Save();
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
            // TODO
            //this.frmDisplay.Show();
        }
    }
}