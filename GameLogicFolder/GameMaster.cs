
public class GameMaster : IGameMaster
{
    private readonly IGameLogic _gameLogic;
    public GameMaster(IGameLogic gameLogic)
    {
        this._gameLogic = gameLogic;
    }

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

    public Player InstanciateComputerPlayer()
    {
        var random = new Random();
        Player cpuPlayer = new Player();
        cpuPlayer.Shape = (Shape)Enum.ToObject(typeof(Shape), random.Next(0, 5));
        return cpuPlayer;
    }
}
