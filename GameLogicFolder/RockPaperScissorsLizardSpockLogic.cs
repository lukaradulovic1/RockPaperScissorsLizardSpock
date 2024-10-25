
using System.Numerics;


public class RockPaperScissorsLizardSpockLogic : IGameLogic
{
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

    public MatchResult DetermineWinner(Player player, Player cpuPlayer, Dictionary<int, List<string>> gameOutcomes)
    {
        List<string> everyoneThatIDefeat = gameOutcomes[(int)player.Shape];
        List<string> everyoneThatCpuDefeats = gameOutcomes[(int)cpuPlayer.Shape];

        string result = Outcome.tie.ToString();

        if (everyoneThatIDefeat.Contains(cpuPlayer.Shape.ToString()))
        {
           result =  Outcome.win.ToString();
        }
        if (everyoneThatCpuDefeats.Contains(player.Shape.ToString()))
        {
            result =  Outcome.lose.ToString();
        }
        return new MatchResult((int)player.Shape, (int)cpuPlayer.Shape, result);
    }

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
    public Choice Choice()
    {
        List<Choice> choices = Choices(); 
        Random random = new Random();

        int randomIndex = random.Next(choices.Count);

        return choices[randomIndex];
    }
}
