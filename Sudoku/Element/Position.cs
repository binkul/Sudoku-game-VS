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
        private int x { get; set; }
        private int y { get; set; }

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   x == position.x &&
                   y == position.y;
        }

        public override int GetHashCode()
        {
            int hashCode = 1502939027;
            hashCode = hashCode * -1521134295 + x.GetHashCode();
            hashCode = hashCode * -1521134295 + y.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString() +
                "[x: " + x.ToString() +
                ", y: " + y.ToString() + "]";
        }
    }
}
