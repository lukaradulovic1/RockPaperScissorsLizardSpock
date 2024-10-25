/// <summary>
/// GameMaster interface used to determine winners, gather all data for the game and instanciate computer player
/// Also could be swapped out to instaciate more human players or Cpu vs cpu but that was not implemented
/// </summary>
public interface IGameMaster
{
        public MatchResult PlayGame(Player player);
        public Player InstanciateComputerPlayer();
        public List<Choice> Choices();
        public Choice GetRandomChoice();

    }
