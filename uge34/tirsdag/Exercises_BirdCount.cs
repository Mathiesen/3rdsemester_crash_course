using gettingstarted.uge34.tirsdag.bird_solution;
using NUnit.Framework;

namespace gettingstarted.uge34.tirsdag;

public class BirdCount : IBirdCount
{
    private int[] _birds;
    public BirdCount(int[] birds)
    {
        _birds = birds;
    }

    public int BirdsToday()
    {
        throw new NotImplementedException();
    }

    public void IncrementTodaysCount()
    {
        throw new NotImplementedException();
    }

    public bool HasDayWithoutBirds()
    {
        throw new NotImplementedException();
    }

    public int CountForDays(int days)
    {
        throw new NotImplementedException();
    }

    public double GetAverageNumberOfBirds()
    {
        throw new NotImplementedException();
    }

    public int BirdOnDay(int day)
    {
        throw new NotImplementedException();
    }
}

public class BirdCountTests
{
    private IBirdCount birdCount;

    [SetUp]
    public void Setup()
    {
        var birds = new[] { 2, 5, 8, 0, 1, 2 };
        birdCount = new BirdCount(birds);
        
    }

    [Test]
    public void ReturnsCorrectNumberOfBirds()
    {
        int result = birdCount.BirdsToday();
        Assert.AreEqual(2, result);
    }

    [Test]
    public void CanAddBirdToTodaysCount()
    {
        birdCount.IncrementTodaysCount();
        var actual = birdCount.BirdsToday();
        Assert.AreEqual(3, actual);
    }

    [Test]
    public void ReturnTrueIfAnyDayHasZeroBirds()
    {
        var expected = birdCount.HasDayWithoutBirds();
        Assert.True(expected);
    }

    [Test]
    public void ReturnSumOfBirdsForGivenDays()
    {
        var actual = birdCount.CountForDays(4);
        Assert.AreEqual(15, actual);
    }

    [Test]
    public void ReturnAverageOfBirds()
    {
        var actual = birdCount.GetAverageNumberOfBirds();
        Assert.AreEqual(3, actual);
    }

    [Test]
    public void ReturnBirdsOnAGivenDay()
    {
        var actual = birdCount.BirdOnDay(4);
        Assert.AreEqual(0, actual);
    }
}

public interface IBirdCount
{
    /// <summary>
    /// Returns how many birds have visited today.
    /// The first element in the array is the oldest day
    /// and the last element is today.
    /// </summary>
    int BirdsToday();

    /// <summary>
    /// Add one bird to todays count
    /// </summary>
    void IncrementTodaysCount();

    /// <summary>
    /// Check if array contains a day without any birds
    /// </summary>
    /// <returns></returns>
    bool HasDayWithoutBirds();

    /// <summary>
    /// Return how many birds have visited in the given number of days
    /// </summary>
    /// <returns></returns>
    int CountForDays(int days);

    /// <summary>
    /// Return the average number of  birds that visited
    /// </summary>
    /// <returns></returns>
    double GetAverageNumberOfBirds();

    /// <summary>
    /// Return number of birds that visited on a given day
    /// </summary>
    /// <param name="day"></param>
    /// <returns></returns>
    int BirdOnDay(int day);
}