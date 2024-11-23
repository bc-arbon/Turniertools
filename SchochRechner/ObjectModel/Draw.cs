namespace SchochRechner.ObjectModel
{
    public class Draw
    {
        public Team? Team1 { get; set; }

        public Team? Team2 { get; set; }

        public int Court { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
