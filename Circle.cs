using System.Threading.Tasks;
using System.Threading;
using SFML.Graphics;
using SFML.System;
using System;
using System.Numerics;

namespace ConsoleApp1
{
    struct Circle
    {
         CircleShape c;

        public Circle(Color color, float radius)
        {
            c = new CircleShape();
            c.Radius = radius;
            c.FillColor = color;
        }
        
        public CircleShape ball()
        {
            return c;
        }
        public void setPos(Vector2f vector)
        {
            c.Position = vector;
        }
    }

}