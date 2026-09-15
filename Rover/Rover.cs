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

        public void Move(Command command)
        {
            if (command == Command.Backward && heading == Heading.North)
            {
                this.position = new Position(this.position.X, this.position.Y - 1);
            }
            if (command == Command.Backward && heading == Heading.East)
            {
                this.position = new Position(this.position.X - 1, this.position.Y);
            }
        }
    }
}
