using SchochRechner.ObjectModel;

namespace SchochRechner
{
    public partial class FrmTeam : Form
    {
        public FrmTeam()
        {
            this.InitializeComponent();
        }

        public FrmTeam(Team team) : this()
        {
            this.TxtId.Text = team.Id.ToString();
            this.TxtName.Text = team.Name;
        }

        public int Id 
        { 
            get 
            { 
                if (string.IsNullOrEmpty(this.TxtId.Text))
                {
                    return -1;
                }

                return Convert.ToInt32(this.TxtId.Text); 
            }
        }

        public string TeamName { get { return this.TxtName.Text; }
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
