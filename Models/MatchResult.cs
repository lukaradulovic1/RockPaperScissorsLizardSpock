public class MatchResult
{
    public int Player { get; set; }
    public int Computer { get; set; }
    public string Results { get; set; }

    public MatchResult(int playerShape, int computerShape, string result)
    {
        Player = playerShape;
        Computer = computerShape;
        Results = result;
    }

}