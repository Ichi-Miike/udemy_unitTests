using System.Runtime.Serialization;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.MSTest;

[TestClass]
public class DemeritPointsCalculatorTests
{
    private DemeritPointsCalculator _demeritPointsCalculator;

    [TestInitialize]
    public void Setup()
    {
        _demeritPointsCalculator = new DemeritPointsCalculator();
    }
    
    [TestMethod]
    [DataRow (-1)]
    [DataRow (301)]
    public void CalculateDemeritPoints_SpeedIsOutOfRange_ArgumentOutOfRangeException(int speed)
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => _demeritPointsCalculator.CalculateDemeritPoints(speed));
    }

    [TestMethod]
    [DataRow (0, 0)]
    [DataRow (50, 0)]
    [DataRow (65, 0)]
    [DataRow (69, 0)]
    [DataRow (70, 1)]
    [DataRow (75, 2)]
    public void CalculateDemeritPoints_SpeedBelowSpeedLimit_ReturnZero(int speed, int expectedResult)
    {
        var result = _demeritPointsCalculator.CalculateDemeritPoints(speed);

        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void CalculateDemeritPoints_SpeedExceedsSpeedLimit_ReturnNumberOfPoints()
    {
        var result = _demeritPointsCalculator.CalculateDemeritPoints(75);
        
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void CalculateDemeritPoints_SpeedExceedsSpeedLimitByLessThanThreshold_ReturnZero()
    {
        var result = _demeritPointsCalculator.CalculateDemeritPoints(69);

        Assert.AreEqual(0, result);
    }
}