
using System.Numerics;

/// <summary>
/// Logic class called by the name of the game but inheriting IGameLogic which allows us to swap out game logics for different playstyles and testing of the code
/// </summary>
public class RockPaperScissorsLizardSpockLogic : IGameLogic
{
    /// <summary>
    /// Instanciates current game outcomes based on this specific game logic
    /// </summary>
    /// <returns></returns>
    public Dictionary<int, List<string>> InstanciateGameOutcomes()
    {
        Dictionary<int, List<string>> gameOutcomes = new();

        List<string> paperDefeats = new() { Shape.Rock.ToString(), Shape.Spock.ToString() };
        gameOutcomes.Add((int)Shape.Paper, paperDefeats);

        List<string> rockDefeats = new() { Shape.Scissors.ToString(), Shape.Lizard.ToString() };
        gameOutcomes.Add((int)Shape.Rock, rockDefeats);

        List<string> scissorsDefeats = new() { Shape.Paper.ToString(), Shape.Lizard.ToString() };
        gameOutcomes.Add((int)Shape.Scissors, scissorsDefeats);

        List<string> lizardDefeats = new() { Shape.Spock.ToString(), Shape.Paper.ToString() };
        gameOutcomes.Add((int)Shape.Lizard, lizardDefeats);

        List<string> spockDefeats = new() { Shape.Scissors.ToString(), Shape.Rock.ToString() };
        gameOutcomes.Add((int)Shape.Spock, spockDefeats);
        return gameOutcomes;
    }

    /// <summary>
    /// Method used to determine winner where we check if the Computers shape is found in the 
    /// dictionary that contains all outcomes based on the shapes
    /// In short, if your shape is Paper, we check if the Computer shape is in the list of 
    /// shapes you defeat, or lose to or get a draw
    /// </summary>
    /// <param name="player"></param>
    /// <param name="cpuPlayer"></param>
    /// <param name="gameOutcomes"></param>
    /// <returns></returns>
    public MatchResult DetermineWinner(Player player, Player cpuPlayer, Dictionary<int, List<string>> gameOutcomes)
    {
        List<string> everyoneThatIDefeat = gameOutcomes[(int)player.Shape];
        List<string> everyoneThatCpuDefeats = gameOutcomes[(int)cpuPlayer.Shape];

        string result = Outcome.tie.ToString();

        if (everyoneThatIDefeat.Contains(cpuPlayer.Shape.ToString()))
        {
            result = Outcome.win.ToString();
        }
        if (everyoneThatCpuDefeats.Contains(player.Shape.ToString()))
        {
            result = Outcome.lose.ToString();
        }
        return new MatchResult((int)player.Shape, (int)cpuPlayer.Shape, result);
    }

    /// <summary>
    /// Method to return all shapes
    /// </summary>
    /// <returns></returns>
    public List<Choice> Choices()
    {
        return new List<Choice>
        {
            new(0, "Rock"),
            new(1, "Paper"),
            new(2, "Scissors"),
            new(3, "Lizard"),
            new(4, "Spock"),
        };
    }

    /// <summary>
    /// Method to return a random shape each time it is called
    /// </summary>
    /// <returns></returns>
    public Choice Choice()
    {
        List<Choice> choices = Choices();
        Random random = new Random();

        int randomIndex = random.Next(choices.Count);

        return choices[randomIndex];
    }


}
