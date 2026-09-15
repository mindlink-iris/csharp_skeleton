using MarsRover;

namespace WakingSkeleton.Test
{
    internal class MoveBackwardTests
    {
        [Test]
        public void MoveBackwardFromNorthMovesDownByOne()
        {
            var rover = new Rover(new Position(1, 1), Heading.North);
            rover.MoveBackward();
            Assert.That(rover.Position, Is.EqualTo(new Position(1,0)));
        }

        [Test]
        public void MoveBackwardFromEastMovesLeftByOne()
        {
            var rover = new Rover(new Position(1, 1), Heading.East);
            rover.MoveBackward();
            Assert.That(rover.Position, Is.EqualTo(new Position(0, 1)));
        }

        [Test]
        public void MoveBackwardFromSouthMovesUpByOne()
        {
            var rover = new Rover(new Position(1, 1), Heading.South);
            rover.MoveBackward();
            Assert.That(rover.Position, Is.EqualTo(new Position(1, 2)));
        }

        [Test]
        public void MoveBackwardFromWestMovesRightByOne()
        {
            var rover = new Rover(new Position(1, 1), Heading.West);
            rover.MoveBackward();
            Assert.That(rover.Position, Is.EqualTo(new Position(2, 1)));
        }
    }
}
