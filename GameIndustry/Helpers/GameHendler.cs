namespace GameIndustry.Helpers
{
    public class GameHendler
    {

        public RSPOptions Choose { get; set; }

        public RSPOptions WinCondition { get; set; }

        public RSPOptions LosseCondition { get; set; }

        public string Image { get; set; }

        public GameState GameResult(GameHendler opponent)
        {
            if (Choose == opponent.Choose)
                return GameState.Draw;
            if(LosseCondition == opponent.Choose)
                return GameState.Loss;
            return GameState.Victory;
        }
    }
  
}
