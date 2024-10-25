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

    /// <summary>
    /// Return the Index.cshtml view containing the frontend code.
    /// </summary>
    /// <returns>ActionResult</returns>
    [HttpGet("Index")]
    public ActionResult Index()
    {
        return View();
    }

    /// <summary>
    /// Return a random shape with its id and name.
    /// </summary>
    /// <returns>Choice{id = placeholder, name = placeholder}</returns>
    [HttpGet("Choice")]
    public IActionResult Choice()
    {
        return Ok(_gameMaster.GetRandomChoice());
    }

    /// <summary>
    /// Return a list of shape choices to include in the game
    /// </summary>
    /// <returns></returns>
    [HttpGet("Choices")]
    public IActionResult Choices()
    {
        return Ok(_gameMaster.Choices());
    }
}

