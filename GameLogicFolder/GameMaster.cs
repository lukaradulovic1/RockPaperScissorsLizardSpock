
public class GameMaster : IGameMaster
{
    private readonly IGameLogic _gameLogic;
    public GameMaster(IGameLogic gameLogic)
    {
        this._gameLogic = gameLogic;
    }

    /// <summary>
    /// Play game method used to call all elements to run the game
    /// First we check for proper input, instanciate the Computer player
    /// and run Determine winner function that returns the response to be sent to the frontend
    /// </summary>
    /// <param name="player"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    public MatchResult PlayGame(Player player)
    {
        if (player == null || !Enum.IsDefined(typeof(Shape), player.Shape))
        {
            throw new ArgumentException("Invalid player input: shape must be a defined enum value.");
        }
        try
        {
            Player cpuPlayer = InstanciateComputerPlayer();

            Dictionary<int, List<string>> gameOutcomes = _gameLogic.InstanciateGameOutcomes();

            return _gameLogic.DetermineWinner(player, cpuPlayer, gameOutcomes);
        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred while playing the game.", ex);
        }
    }

    /// <summary>
    /// Creates Computer player with random numbered shape
    /// </summary>
    /// <returns></returns>

    public Player InstanciateComputerPlayer()
    {
        var random = new Random();
        Player cpuPlayer = new Player();
        cpuPlayer.Shape = (Shape)Enum.ToObject(typeof(Shape), random.Next(0, 5));
        return cpuPlayer;
    }

    /// <summary>
    /// Returns random shape to be used in endpoint Choice
    /// </summary>
    /// <returns></returns>
    public Choice GetRandomChoice()
    {
        return _gameLogic.Choice();

    }

    /// <summary>
    /// Returns the choices to populate the list of shapes on the frontend
    /// </summary>
    /// <returns></returns>
    public List<Choice> Choices()
    {
        return _gameLogic.Choices();
    }
}
