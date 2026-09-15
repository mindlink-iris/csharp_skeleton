using NUnit.Framework.Constraints;

namespace WakingSkeleton.Test;

[TestFixture]
public class Tests
{
   
    [Test]
    public void InitializeHeading()
    {
        Rover rover = new Rover(new Position(2, 3), Heading.North);
        Assert.That(rover.Heading, Is.EqualTo(Heading.North));
    }

    private class Rover
    {
        private Heading heading;

        public Rover(Position position, Heading heading)
        {
            this.heading = heading;
        }

        public Heading Heading => this.heading;
    }

    public enum Heading
    {
        North,
        South
    }

    private class Position
    {
        public Position(int x, int y)
        {
        }
    }
}