
public class GameMaster : IGameMaster
{
    private readonly IGameLogic _gameLogic;
    public GameMaster(IGameLogic gameLogic)
    {
        this._gameLogic = gameLogic;
    }
}
