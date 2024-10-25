
/// <summary>
/// Using interface so we are able to swap out game logic based on types of games, 
/// like Rock Paper Scissors or Rock Paper Scissors Wizard or Human Rock Paper Scissors
/// </summary>
public interface IGameLogic
    {
    public Dictionary<int, List<string>> InstanciateGameOutcomes();
    public MatchResult DetermineWinner(Player player, Player cpuPlayer, Dictionary<int, List<string>> rule);
    public List<Choice> Choices();
    public Choice Choice();

    }
