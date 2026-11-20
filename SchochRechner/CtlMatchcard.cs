using System.ComponentModel;

namespace SchochRechner
{
    public partial class CtlMatchcard : UserControl
    {
        public CtlMatchcard()
        {
            this.InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Round
        {
            get { return this.LblRound.Text; }
            set { this.LblRound.Text = "Runde:  " + value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Court
        {
            get { return this.LblCourt.Text; }
            set { this.LblCourt.Text = "Feld:      " + value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Team1
        {
            get { return this.LblTeam1.Text; }
            set { this.LblTeam1.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Team2
        {
            get { return this.LblTeam2.Text; }
            set { this.LblTeam2.Text = value; }
        }
    }
}