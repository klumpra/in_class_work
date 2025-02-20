using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExample20250219
{
    internal interface Movable
    {
        public void Move(double dx, double dy);   // do not label abstract even though it is.
        public void RandomMove(Random rnd);
    }
}
