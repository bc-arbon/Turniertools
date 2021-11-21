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

        public int Id { get { return Convert.ToInt32(this.TxtId.Text); }
        }

        public string TeamName { get { return this.TxtName.Text; }
        }
    }
}
