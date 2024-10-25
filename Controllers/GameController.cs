using Microsoft.AspNetCore.Mvc;
using System.Numerics;


[Route("")]
[ApiController]
public class GameController : Controller
{
    private readonly IGameMaster _gameMaster;
    private readonly Player _player;

    public GameController(IGameMaster gameMaster, Player player)
    {
        this._gameMaster = gameMaster;
        this._player = player;
    }
}

