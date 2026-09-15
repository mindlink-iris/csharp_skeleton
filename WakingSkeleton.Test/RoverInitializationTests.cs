using NUnit.Framework.Constraints;
using MarsRover;

namespace WakingSkeleton.Test;

[TestFixture]
public class RoverInitializationTests
{
   
    [Test]
    public void InitializeHeading()
    {
        Rover rover = new Rover(new Position(2, 3), Heading.North);
        Assert.That(rover.Heading, Is.EqualTo(Heading.North));
    }

    [Test]
    public void InitializePosition()
    {
        var rover = new Rover(new Position(2, 3), Heading.North);
        Assert.That(rover.Position, Is.EqualTo(new Position(2, 3)));
    }
}