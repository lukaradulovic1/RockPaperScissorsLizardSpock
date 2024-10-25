
public interface IGameMaster
{
        public MatchResult PlayGame(Player player);
        public Player InstanciateComputerPlayer();
        public List<Choice> Choices();
        public Choice GetRandomChoice();

    }
