using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public class CollisionDetector
    {
        /// <summary>
        /// Return tru if objects overlaps, false otherwise.
        /// </summary>
        /// <param name="a"></param> ball
        /// <param name="b"></param> other objects, like PaddleBottom or WinningWall
        /// <returns></returns>
        public static bool Overlaps(IPhysicalObject2D a, IPhysicalObject2D b)
        {
            if (((a.X <= b.X + b.Width) && (a.X >= b.X) || (a.X + a.Width <= b.X + b.Width) && (a.X + a.Width >= b.X))
                && ((a.Y <= b.Y + b.Height) && (a.Y >= b.Y) || (a.Y + a.Height <= b.Y + b.Height) && (a.Y + a.Height >= b.Y))
                )
            {
                return true;
            }
            return false;
        }
    }
}
