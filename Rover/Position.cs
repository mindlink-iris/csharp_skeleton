using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Position
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
