using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku.Sudoku.Element
{
    class Position
    {
        private int X { get; }
        private int Y { get; }

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   X == position.X &&
                   Y == position.Y;
        }

        public override int GetHashCode()
        {
            int hashCode = 1502939027;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString() +
                "[_x: " + X.ToString() +
                ", y: " + Y.ToString() + "]";
        }
    }
}
