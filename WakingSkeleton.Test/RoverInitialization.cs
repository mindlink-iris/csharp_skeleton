using NUnit.Framework.Constraints;

namespace WakingSkeleton.Test;

[TestFixture]
public class Tests
{
   
    [Test]
    public void InitializeHeading()
    {
        Rover rover = new Rover(Heading.North);
        Assert.That(rover.Heading, Is.EqualTo(Heading.North));
    }

    private class Rover
    {
        private Heading heading;

        public Rover(Heading heading)
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
}