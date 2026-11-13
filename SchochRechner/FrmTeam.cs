using SchochRechner.ObjectModel;

namespace SchochRechner
{
    public partial class FrmTeam : Form
    {
        public FrmTeam()
        {
            this.InitializeComponent();
        }

        public FrmTeam(IEnumerable<string> groups, Team? team = null, string? selectedGroupName = null) : this()
        {
            this.CbxGroup.Items.AddRange(groups.Cast<object>().ToArray());
            this.CbxGroup.SelectedItem = team?.GroupName ?? selectedGroupName ?? this.CbxGroup.Items[0];
            if (team != null)
            {
                this.TxtId.Text = team.Id.ToString();
                this.TxtName.Text = team.Name;
            }
        }

        public int Id 
        { 
            get 
            {
                return string.IsNullOrEmpty(this.TxtId.Text) ? -1 : Convert.ToInt32(this.TxtId.Text);
            }
        }

        public string TeamName { get { return this.TxtName.Text; }
        }

        public string GroupName { get { return (string)this.CbxGroup.SelectedItem; } }

        public void SetGroupSelectionEnabled(bool enabled)
        {
            this.CbxGroup.Enabled = enabled;
        }

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
