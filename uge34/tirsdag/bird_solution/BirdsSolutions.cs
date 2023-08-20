namespace gettingstarted.uge34.tirsdag.bird_solution;

public class BirdCountSolutions : IBirdCount
{
    private int[] _birds;
    
    public BirdCountSolutions(int[] birds)
    {
        _birds = birds;
    }
    
    public int BirdsToday()
    {
        return _birds.Last();
    }

    public void IncrementTodaysCount()
    {
        var index = Array.LastIndexOf(_birds, _birds.Last());
        _birds.SetValue(_birds.Last() + 1, index);
    }

    public bool HasDayWithoutBirds()
    {
        return _birds.Any(x => x.Equals(0));
    }

    public int CountForDays(int days)
    {
        var take = _birds.Take(days);
        return take.Sum();
    }

    public double GetAverageNumberOfBirds()
    {
        return _birds.Average();
    }

    public int BirdOnDay(int days)
    {
        return _birds[days-1];
    }
}