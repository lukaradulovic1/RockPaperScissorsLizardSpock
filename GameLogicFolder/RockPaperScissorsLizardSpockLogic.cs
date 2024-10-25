
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





}
