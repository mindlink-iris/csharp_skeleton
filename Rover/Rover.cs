namespace MarsRover
{
    public class Rover
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

        public void MoveBackward()
        {
            this.position = this.heading switch
            {
                Heading.North => new Position(this.position.X, this.position.Y - 1),
                Heading.South => new Position(this.position.X, this.position.Y + 1),
                Heading.East => new Position(this.position.X - 1, this.position.Y),
                Heading.West => new Position(this.position.X + 1, this.position.Y),
                _ => throw new NotImplementedException()
            };
        }
    }
}
