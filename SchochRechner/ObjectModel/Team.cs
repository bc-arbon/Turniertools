namespace SchochRechner.ObjectModel
{
    public class Team
    {
        public Team()
        {
            this.Opponents = new List<int>();
            this.Name = string.Empty;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Rounds { get { return this.Opponents.Count; } }

        public int SetWins { get; set; }
        public int SetLosses { get; set; }
        public int SetDiff { get { return this.SetWins - this.SetLosses; } }  
        public string SetDiffText { get { return this.SetDiff > 0 ? "+" + this.SetDiff : this.SetDiff.ToString(); } }

        public int GameWins { get; set; }
        public int GameLosses { get; set; }        
        public int GameDiff { get { return this.GameWins - this.GameLosses; } }
        public string GameDiffText { get { return this.GameDiff > 0 ? "+" + this.GameDiff : this.GameDiff.ToString(); } }

        public int Buchholz { get; set; }

        public int Feinbuchholz { get; set; }

        public List<int> Opponents { get; }

        public override string ToString()
        {
            return this.Name + " (" + this.Id + ")";
        }
    }
}
