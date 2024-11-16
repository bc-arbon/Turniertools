using SchochRechner.ObjectModel;

namespace SchochRechner
{
    public partial class FrmCustomMatchcard : Form
    {
        public string Team1 { get; private set; } = string.Empty;
        public string Team2 { get; private set; } = string.Empty;

        public FrmCustomMatchcard()
        {
            this.InitializeComponent();
        }

        public FrmCustomMatchcard(List<Team> teams) : this()
        {
            var teamsSorted = teams.ToArray().OrderBy(x => x.Name).ToArray();
            this.CbxTeam1.Items.AddRange(teamsSorted);
            this.CbxTeam2.Items.AddRange(teamsSorted);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {            
            if (!string.IsNullOrEmpty(this.TxtTeam1.Text))
            {
                this.Team1 = this.TxtTeam1.Text;
            }

            if (!string.IsNullOrEmpty(this.TxtTeam2.Text))
            {
                Team2 = this.TxtTeam2.Text;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CbxTeam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CbxTeam1.SelectedItem != null)
            {
                var team = (Team)this.CbxTeam1.SelectedItem;
                this.TxtTeam1.Text = team.Name;
            }
        }

        private void CbxTeam2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CbxTeam2.SelectedItem != null)
            {
                var team = (Team)this.CbxTeam2.SelectedItem;
                this.TxtTeam2.Text = team.Name;
            }
        }
    }
}
