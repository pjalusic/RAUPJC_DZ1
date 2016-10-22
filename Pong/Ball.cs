using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    /*
    /// <summary>
    /// Ball direction representation
    /// </summary>
    public struct Direction
    {
        public int xAxis;
        public int yAxis;

        /// <summary>
        /// NISAM SIGURAN DA JE DOBRO IMPLEMENTIRANO OVO S -1 I 1
        /// ZBOG METODE OPERATOR* KOJI KREIRA NOVI DIRECTION
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Direction (int x, int y)
        {
            Random rand = new Random();
            if (x != 1 || x!= -1)
            {
                int randX = rand.Next(0, 2);
                if (randX == 0)
                {
                    xAxis = -1;
                } else
                {
                    xAxis = 1;
                }
            } else
            {
                xAxis = x;
            }
            if (y != 1 || y != -1)
            {
                int randY = rand.Next(0, 2);
                if (randY == 0)
                {
                    yAxis = -1;
                }
                else
                {
                    yAxis = 1;
                }
            }
            else
            {
                yAxis = y;
            }
        }

        public static Direction operator *(Direction initial, Direction multiply)
        {
            return new Direction(initial.xAxis * multiply.xAxis, initial.yAxis * multiply.yAxis);
        }

        public static implicit operator Direction(Vector2 v)
        {
            throw new NotImplementedException();
        }
    }*/

    /// <summary >
    /// Game ball object representation
    /// </ summary >
    public class Ball : Sprite
    {
        /// <summary >
        /// Defines current ball speed in time .
        /// </ summary >
        public float Speed { get; set; }
        public float BumpSpeedIncreaseFactor { get; set; }

        /// <summary >
        /// Defines ball direction .
        /// Valid values ( -1 , -1) , (1 ,1) , (1 , -1) , ( -1 ,1).
        /// Using Vector2 to simplify game calculation . Potentially
        /// dangerous because vector 2 can swallow other values as well .
        /// OPTIONAL TODO : create your own , more suitable type
        /// </ summary >
        public Vector2 Direction { get; set; }

        public Ball(int size, float speed, float defaultBallBumpSpeedIncreaseFactor) : base(size, size)
        {
            this.Speed = speed;
            BumpSpeedIncreaseFactor = defaultBallBumpSpeedIncreaseFactor;
            
            Random rand = new Random();
            int randX = rand.Next(0, 2);
            if (randX < 1)
            {
                randX = -1;
            }
            int randY = rand.Next(0, 2);
            if (randY < 1)
            {
                randY = -1;
            }
            // Initial direction
            Direction = new Vector2(randX, randY);
        }
    }

}
