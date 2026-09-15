using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover;

namespace WakingSkeleton.Test
{
    internal class MoveBackwardTests
    {
        [Test]
        public void MoveBackwardFromNorthMovesPositionByOne()
        {
            var rover = new Rover(new Position(1, 1), Heading.North);
            rover.Move(Command.Backward);
            Assert.That(rover.Position, Is.EqualTo(new Position(1,0)));
        }
    }
}
