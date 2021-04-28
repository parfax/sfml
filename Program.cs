using SFML.Window;
using SFML.Graphics;
using System;
using System.Numerics;
using SFML.System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            RenderWindow window = new RenderWindow(new VideoMode(1600, 900), "Game window");
            window.Closed += WindowClosed;
            
            CircleShape circle = new CircleShape();
            circle.Radius = 50;
            circle.FillColor = Color.Red;
            Vector2f vec2 = new Vector2f();
            vec2.X = window.Size.X/2;
            vec2.Y = window.Size.Y/2;
            circle.Position=vec2;
            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(Color.White);
                window.Draw(circle);
                window.Display();
            }
        }
 
        static void WindowClosed(object sender, EventArgs e)
        {
            RenderWindow w = (RenderWindow)sender;
            w.Close();
        }
    }
}