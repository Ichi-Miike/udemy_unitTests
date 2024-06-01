using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.NUnit;

[TestFixture]
public class DemeritPointsCalculatorTests
{
    private DemeritPointsCalculator _demeritPointsCalculator;

    [SetUp]
    public void Setup()
    {
        _demeritPointsCalculator = new DemeritPointsCalculator();
    }
    
    [Test]
    [TestCase (-1)]
    [TestCase (301)]
    public void CalculateDemeritPoints_SpeedIsOutOfRange_ArgumentOutOfRangeException(int speed)
    {
        Assert.That(() => _demeritPointsCalculator.CalculateDemeritPoints(speed),
            Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
    }

    [Test]
    [TestCase (0, 0)]
    [TestCase (50, 0)]
    [TestCase (65, 0)]
    [TestCase (69, 0)]
    [TestCase (70, 1)]
    [TestCase (75, 2)]
    public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
    {
        var result = _demeritPointsCalculator.CalculateDemeritPoints(speed);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void CalculateDemeritPoints_SpeedExceedsSpeedLimitPlusThreshold_ReturnNumberOfPoints()
    {
        var result = _demeritPointsCalculator.CalculateDemeritPoints(75);
        
        Assert.That(result, Is.EqualTo(2));
    }

}