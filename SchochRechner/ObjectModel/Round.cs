namespace SchochRechner.ObjectModel
{
    public class Round
    {
        public Round()
        {
            this.Draws = new List<Draw>();
        }

        public int RoundActual { get; set; }

        public List<Draw> Draws { get; }
    }
}
