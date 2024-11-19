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
        public int Court { get { return Convert.ToInt32(this.TxtCourt.Text); } }
        public int Games1 { get { return Convert.ToInt32(this.TxtGames1.Text); } }
        public int Games2 { get { return Convert.ToInt32(this.TxtGames2.Text); } }
        public int Sets1 { get { return Convert.ToInt32(this.TxtSets1.Text); } }
        public int Sets2 { get { return Convert.ToInt32(this.TxtSets2.Text); } }
        public int Points1 { get { return Convert.ToInt32(this.TxtPoints1.Text); } }
        public int Points2 { get { return Convert.ToInt32(this.TxtPoints2.Text); } }
        public int Single11 { get { return Convert.ToInt32(this.TxtSingle11.Text); } }
        public int Single12 { get { return Convert.ToInt32(this.TxtSingle12.Text); } }
        public int Single21 { get { return Convert.ToInt32(this.TxtSingle21.Text); } }
        public int Single22 { get { return Convert.ToInt32(this.TxtSingle22.Text); } }
        public int Single31 { get { return string.IsNullOrEmpty(this.TxtSingle31.Text) ? -1 : Convert.ToInt32(this.TxtSingle31.Text); } }
        public int Single32 { get { return string.IsNullOrEmpty(this.TxtSingle32.Text) ? -1 : Convert.ToInt32(this.TxtSingle32.Text); } }
        public int Double11 { get { return Convert.ToInt32(this.TxtDouble11.Text); } }
        public int Double12 { get { return Convert.ToInt32(this.TxtDouble12.Text); } }
        public int Double21 { get { return Convert.ToInt32(this.TxtDouble21.Text); } }
        public int Double22 { get { return Convert.ToInt32(this.TxtDouble22.Text); } }
        public int Double31 { get { return string.IsNullOrEmpty(this.TxtDouble31.Text) ? -1 : Convert.ToInt32(this.TxtDouble31.Text); } }
        public int Double32 { get { return string.IsNullOrEmpty(this.TxtDouble32.Text) ? -1 : Convert.ToInt32(this.TxtDouble32.Text); } }

        public FrmEntry(List<Team> teams, int round, int court, int preselectTeam1, int preselectTeam2) : this()
        {
            var teamsSorted = teams.ToArray().OrderBy(x => x.Id).ToArray();
            this.CbxTeam1.Items.AddRange(teamsSorted);
            this.CbxTeam2.Items.AddRange(teamsSorted);
            this.TxtRound.Text = round.ToString();
            this.TxtCourt.Text = court == -1 ? string.Empty : court.ToString();

            if (preselectTeam1 != null)
            {
                var team1 = teams.Find(x => x.Id == preselectTeam1);
                this.CbxTeam1.SelectedItem = team1;
            }

            if (preselectTeam2 != null)
            {
                var team2 = teams.Find(x => x.Id == preselectTeam2);
                this.CbxTeam2.SelectedItem = team2;
            }
        }

        public FrmEntry(List<Team> teams, Entry entry) : this(teams, entry.Round, entry.Court, entry.Team1, entry.Team2)
        {
            this.TxtRound.Text = entry.Round.ToString();
            this.TxtGames1.Text = entry.Games1.ToString();
            this.TxtGames2.Text = entry.Games2.ToString();
            this.TxtSets1.Text = entry.Sets1.ToString();
            this.TxtSets2.Text = entry.Sets2.ToString();
            this.TxtSingle11.Text = entry.Single11.ToString();
            this.TxtSingle12.Text = entry.Single12.ToString();
            this.TxtSingle21.Text = entry.Single21.ToString();
            this.TxtSingle22.Text = entry.Single22.ToString();
            this.TxtSingle31.Text = entry.Single31 > -1 ? entry.Single31.ToString() : null;
            this.TxtSingle32.Text = entry.Single32 > -1 ? entry.Single32.ToString() : null;
            this.TxtDouble11.Text = entry.Double11.ToString();
            this.TxtDouble12.Text = entry.Double12.ToString();
            this.TxtDouble21.Text = entry.Double21.ToString();
            this.TxtDouble22.Text = entry.Double22.ToString();
            this.TxtDouble31.Text = entry.Double31 > -1 ? entry.Double31.ToString() : null;
            this.TxtDouble32.Text = entry.Double32 > -1 ? entry.Double32.ToString() : null;
            this.TxtPoints1.Text = entry.Points1.ToString();
            this.TxtPoints2.Text = entry.Points2.ToString();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            this.Calculate();
        }

        private bool Calculate()
        {
            try
            {
                if (string.IsNullOrEmpty(this.TxtSingle11.Text) ||
                    string.IsNullOrEmpty(this.TxtSingle12.Text) ||
                    string.IsNullOrEmpty(this.TxtSingle21.Text) ||
                    string.IsNullOrEmpty(this.TxtSingle22.Text) ||
                    string.IsNullOrEmpty(this.TxtDouble11.Text) ||
                    string.IsNullOrEmpty(this.TxtDouble12.Text) ||
                    string.IsNullOrEmpty(this.TxtDouble21.Text) ||
                    string.IsNullOrEmpty(this.TxtDouble22.Text))
                {
                    MessageBox.Show("Min. 1 Resultat fehlt", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                var setsSingle1 = 0;
                var setsSingle2 = 0;
                var setsDouble1 = 0;
                var setsDouble2 = 0;
                var games1 = 0;
                var games2 = 0;
                var points1 = 0;
                var points2 = 0;

                var single11 = Convert.ToInt32(this.TxtSingle11.Text);
                var single12 = Convert.ToInt32(this.TxtSingle12.Text);
                var single21 = Convert.ToInt32(this.TxtSingle21.Text);
                var single22 = Convert.ToInt32(this.TxtSingle22.Text);
                var single31 = string.IsNullOrEmpty(this.TxtSingle31.Text) ? -1 : Convert.ToInt32(this.TxtSingle31.Text);
                var single32 = string.IsNullOrEmpty(this.TxtSingle32.Text) ? -1 : Convert.ToInt32(this.TxtSingle32.Text);

                var double11 = Convert.ToInt32(this.TxtDouble11.Text);
                var double12 = Convert.ToInt32(this.TxtDouble12.Text);
                var double21 = Convert.ToInt32(this.TxtDouble21.Text);
                var double22 = Convert.ToInt32(this.TxtDouble22.Text);
                var double31 = string.IsNullOrEmpty(this.TxtDouble31.Text) ? -1 : Convert.ToInt32(this.TxtDouble31.Text);
                var double32 = string.IsNullOrEmpty(this.TxtDouble32.Text) ? -1 : Convert.ToInt32(this.TxtDouble32.Text);

                if (single11 > single12) { setsSingle1++; } else { setsSingle2++; }
                if (single21 > single22) { setsSingle1++; } else { setsSingle2++; }
                if (single31 > -1 && single32 > -1) { if (single31 > single32) { setsSingle1++; } else { setsSingle2++; } }

                if (double11 > double12) { setsDouble1++; } else { setsDouble2++; }
                if (double21 > double22) { setsDouble1++; } else { setsDouble2++; }
                if (double31 > -1 && double32 > -1) { if (double31 > double32) { setsDouble1++; } else { setsDouble2++; } }

                if (setsSingle1 > setsSingle2) { games1++; } else { games2++; }
                if (setsDouble1 > setsDouble2) { games1++; } else { games2++; }

                points1 = single11 + single21;
                points1 += single31 > -1 ? single31 : 0;
                points1 += double11 + double21;
                points1 += double31 > -1 ? double31 : 0;

                points2 = single12 + single22;
                points2 += single32 > -1 ? single32 : 0;
                points2 += double12 + double22;
                points2 += double32 > -1 ? double32 : 0;

                this.TxtSets1.Text = (setsSingle1 + setsDouble1).ToString();
                this.TxtSets2.Text = (setsSingle2 + setsDouble2).ToString();
                this.TxtGames1.Text = games1.ToString();
                this.TxtGames2.Text = games2.ToString();
                this.TxtPoints1.Text = points1.ToString();
                this.TxtPoints2.Text = points2.ToString();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öppis isch nöd guet:\r\n\r\n" + ex, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (this.CbxTeam1.SelectedItem == null)
            {
                MessageBox.Show("Team 1 fehlt", "Sir Schoch-A-Lot", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                return;
            }

            if (this.CbxTeam2.SelectedItem == null)
            {
                MessageBox.Show("Team 2 fehlt", "Sir Schoch-A-Lot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.Calculate())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
