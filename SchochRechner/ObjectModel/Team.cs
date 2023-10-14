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

        public int SetsWon { get; set; }
        public int SetsLost { get; set; }
        public int SetsDiff { get { return this.SetsWon - this.SetsLost; } }  
        public string SetsDiffText { get { return this.SetsDiff > 0 ? "+" + this.SetsDiff : this.SetsDiff.ToString(); } }

        public int GamesWon { get; set; }
        public int GamesLost { get; set; }        
        public int GamesDiff { get { return this.GamesWon - this.GamesLost; } }
        public string GamesDiffText { get { return this.GamesDiff > 0 ? "+" + this.GamesDiff : this.GamesDiff.ToString(); } }

        public int PointsWon { get; set; }
        public int PointsLost { get; set; }
        public int PointsDiff {  get { return this.PointsWon - this.PointsLost; } }
        public string PointsDiffText { get { return this.PointsDiff > 0 ? "+" + this.PointsDiff : this.PointsDiff.ToString(); } }

        public int Buchholz { get; set; }

        public int Feinbuchholz { get; set; }

        public List<int> Opponents { get; }

        public override string ToString()
        {
            return this.Name + " (" + this.Id + ")";
        }
    }
}
