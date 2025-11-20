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
            this.ShowDraw();
            this.ShowRanking();
            this.frmDisplay.ShowRanking();
            this.frmDisplay.ShowDraw();
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
                item.SubItems.Add(team.GamesWon.ToString());
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

        public void ShowDraw()
        {
            this.NudRound.Value = this.schochManager.Round.RoundActual;

            this.LvwDraws.Items.Clear();
            this.LvwDraws.Groups.Clear();

            var group = new ListViewGroup("Runde " + this.schochManager.Round.RoundActual);
            this.LvwDraws.Groups.Add(group);

            foreach (var draw in this.schochManager.Round.Draws)
            {
                var item = new ListViewItem(Helpers.OpponentsAsList(draw.Team1.Opponents));
                item.SubItems.Add("(" + draw.Team1.Id + ") " + draw.Team1.Name);
                item.SubItems.Add(draw.Team1.GamesWon.ToString());
                item.SubItems.Add(draw.Team2.GamesWon.ToString());
                item.SubItems.Add("(" + draw.Team2.Id + ") " + draw.Team2.Name);
                item.SubItems.Add(Helpers.OpponentsAsList(draw.Team2.Opponents));
                item.SubItems.Add(draw.Court == 0 ? string.Empty : draw.Court.ToString());
                item.SubItems.Add(string.Empty);
                item.Tag = draw;
                group.Items.Add(item);
                this.LvwDraws.Items.Add(item);
                //Thread.Sleep(500);
                //Application.DoEvents();
            }

            this.frmDisplay.ShowDraw();
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

        private void ShowMatchcard()
        {
            // TBD, works for testing
            if (this.LvwDraws.SelectedItems.Count == 0)
            {
                return;
            }

            var draw = (Draw)this.LvwDraws.SelectedItems[0].Tag;
            var frmMatchcard = new FrmMatchcard(draw, this.schochManager.Round.RoundActual);
            frmMatchcard.ShowDialog();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var frmEntry = new FrmEntry(this.schochManager.Teams, (int)this.NudRound.Value, -1, -1, -1);
            if (frmEntry.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.schochManager.AddEntry(Helpers.CreateEntry(frmEntry));
                    this.schochManager.CalculateRanking();
                    this.schochManager.Save();
                    this.ShowAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Öppis isch nöd guet.\r\nHesch sicher vergesse Teams uswähle!\r\n\r\n" + ex, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            this.EditEntry();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this.LvwEntries.SelectedItems.Count == 0)
            {
                return;
            }

            if (MessageBox.Show(this.LvwEntries.SelectedItems.Count + " Resultate löschen?", "Schochrecher", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            foreach (ListViewItem item in this.LvwEntries.SelectedItems)
            {
                var entry = (Entry)item.Tag;
                this.schochManager.DeleteEntry(entry);
                // Todo: Cleanup opponent lists
            }

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
            //this.schochManager.AddExampleData2();

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
            pd.DefaultPageSettings.Landscape = true;

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
            if (MessageBox.Show("Sicher neu auslosen?", "Sir Schoch-A-Lot", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            this.schochManager.CreateDraw((int)this.NudRound.Value);
            this.schochManager.Save();
            this.ShowDraw();
        }

        private void BtnRandomDraw_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sicher neu auslosen?", "Sir Schoch-A-Lot", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            this.schochManager.CreateDrawRandom((int)this.NudRound.Value);
            this.schochManager.Save();
            this.ShowDraw();
        }

        private void BtnEmptyMatchcard_Click(object sender, EventArgs e)
        {
            new FrmMatchcard().ShowDialog();
        }

        private void LvwDraws_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowMatchcard();
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

        private void BtnTest_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.LvwDraws.Items)
            {
                var draw = (Draw)item.Tag;

                var entry = Helpers.GenerateResult(draw, (int)this.NudRound.Value);
                try
                {
                    this.schochManager.AddEntry(entry);
                    this.schochManager.CalculateRanking();
                    this.schochManager.Save();
                    this.ShowAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Öppis isch nöd guet.\r\nHesch sicher vergesse Teams uswähle!\r\n\r\n" + ex, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCustomMatchcard_Click(object sender, EventArgs e)
        {
            var frmCustomMatchcard = new FrmCustomMatchcard(this.schochManager.Teams);
            if (frmCustomMatchcard.ShowDialog() == DialogResult.OK)
            {
                var frmMatchcard = new FrmMatchcard(frmCustomMatchcard.Team1, frmCustomMatchcard.Team2, frmCustomMatchcard.Round, frmCustomMatchcard.Court);
                frmMatchcard.ShowDialog();
            }
        }

        private void CmsCourt_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.LvwDraws.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void MnuCourt_Click(object sender, EventArgs e)
        {
            if (this.LvwDraws.SelectedItems.Count == 0)
            {
                return;
            }

            var court = ((ToolStripMenuItem)sender).Tag.ToString();
            var draw = (Draw)this.LvwDraws.SelectedItems[0].Tag;
            draw.Court = Convert.ToInt32(court);

            if (court == "0")
            {
                if (draw.Start != DateTime.MinValue)
                {
                    draw.End = DateTime.Now;
                    this.LvwDraws.SelectedItems[0].SubItems[6].Text = string.Empty;
                }
            }
            else
            {
                this.LvwDraws.SelectedItems[0].SubItems[6].Text = court;
                draw.Start = DateTime.Now;
            }

            this.frmDisplay.ShowDraw();
            this.schochManager.Save();
        }

        private void NudRound_ValueChanged(object sender, EventArgs e)
        {
            this.schochManager.SetRoundNumber((int)this.NudRound.Value);
        }

        private void MnuMatchcard_Click(object sender, EventArgs e)
        {
            this.ShowMatchcard();
        }

        private void MnuEnterResult_Click(object sender, EventArgs e)
        {
            if (this.LvwDraws.SelectedItems.Count == 0)
            {
                return;
            }

            var draw = (Draw)this.LvwDraws.SelectedItems[0].Tag;

            var frmEntry = new FrmEntry(this.schochManager.Teams, (int)this.NudRound.Value, draw.Court, draw.Team1.Id, draw.Team2.Id);
            if (frmEntry.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.schochManager.AddEntry(Helpers.CreateEntry(frmEntry));
                    this.schochManager.CalculateRanking();
                    this.schochManager.Save();
                    this.ShowAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Öppis isch nöd guet.\r\nHesch sicher vergesse Teams uswähle!\r\n\r\n" + ex, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EditEntry()
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

        private void LvwEntries_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.EditEntry();
        }

        private void TmrDuration_Tick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.LvwDraws.Items)
            {
                var draw = (Draw)item.Tag;
                if (draw.Start != DateTime.MinValue && draw.Court != 0)
                {
                    var duration = DateTime.Now - draw.Start;
                    item.SubItems[7].Text = Math.Floor(duration.TotalMinutes) + ":" + duration.Seconds.ToString("D2");
                }
            }
        }
    }
}