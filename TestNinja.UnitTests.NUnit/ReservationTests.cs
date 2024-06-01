using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.NUnit;

[TestFixture]
public class ReservationTests
{
    [Test]
    public void CanBeCancelledBy_AdminCancelling_ReturnTrue()
    {
        //  Arrange
        var reservation = new Reservation();

        //  Act
        var value = reservation.CanBeCancelledBy(new User { IsAdmin = true });

        //  Assert
        Assert.IsTrue(value);
        Assert.That(value, Is.True);
        Assert.That(value == true);
    }

    [Test]
    public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
    {
        //  Arrange
        var user = new User { IsAdmin = false };
        var reservation = new Reservation { MadeBy = user };

        //  Act
        var value = reservation.CanBeCancelledBy(user);

        //  Assert
        Assert.IsTrue(value);
    }

    [Test]
    public void CanBeCancelledBy_DifferentUserCancelling_ReturnsFalse()
    {
        //  Arrange
        var reservation = new Reservation { MadeBy = new User() };

        //  Act
        var value = reservation.CanBeCancelledBy(new User());

        //  Assert
        Assert.IsFalse(value);
    }
}