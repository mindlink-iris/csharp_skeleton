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

    [Test]
    public void InitializePosition()
    {
        var rover = new Rover(new Position(2, 3), Heading.North);
        Assert.That(rover.Position, Is.EqualTo(new Position(2, 3)));
    }

    private class Rover
    {
        private Heading heading;
        private Position position;

        public Rover(Position position, Heading heading)
        {
            this.heading = heading;
            this.position = position;
        }

        public Heading Heading => this.heading;

        public Position Position => this.position;
    }

    public enum Heading
    {
        North,
        South
    }

    private class Position
    {
        private int x;
        private int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X => this.x;
        public int Y => this.y;

       public override bool Equals(object? other)
        {
            if (other is Position otherPosition)
            {
                return this.x == otherPosition.x && this.y == otherPosition.y;
            }
            return false;
        }
    }
}