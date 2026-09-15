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
    }
}
