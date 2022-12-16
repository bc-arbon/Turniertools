namespace SchochRechner
{
    public partial class CtlMatchcard : UserControl
    {
        public CtlMatchcard()
        {
            this.InitializeComponent();
        }

        public string Team1 
        { 
            get { return this.LblTeam1.Text; } 
            set { this.LblTeam1.Text = value; }
        }

        public string Team2
        {
            get { return this.LblTeam2.Text; }
            set { this.LblTeam2.Text = value; }
        }
    }
}