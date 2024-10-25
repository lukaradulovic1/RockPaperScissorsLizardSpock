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

    /// <summary>
    /// POST method endpoint to play the game that returns the shapes of player, computer and the results
    /// </summary>
    /// <param name="choice"></param>
    /// <returns>JSON array</returns>
    [HttpPost("Play")]
    public IActionResult Play([FromBody] PlayerChoiceModel choice)
    {
        if (choice.Player.HasValue)
        {
            if (Enum.IsDefined(typeof(Shape), choice.Player.Value))
            {
                _player.Shape = (Shape)choice.Player.Value;
                MatchResult result = _gameMaster.PlayGame(_player);

                return Ok(result);
            }
            else
            {
                return BadRequest("Invalid shape provided.");
            }
        }

        else
        {
            return BadRequest("Player choice is required.");
        }

    }
}
/// <summary>
/// Player choice model is used to wrap the int value in an object due to the use of the POST method
/// </summary>
public class PlayerChoiceModel
{
    public int? Player { get; set; }
}