namespace SchochRechner.ObjectModel
{
    public class Round
    {
        public Round()
        {
            this.Draws = new List<Draw>();
            this.RoundActual = 1;
        }

        public int RoundActual { get; set; }

        public List<Draw> Draws { get; }
    }
}
