using System;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace ConsoleApp1
{
    public class Game
    {
        public void LetsGo()
        {
            RenderWindow window = new(mode: new VideoMode(width: 1280, height: 720), title: "Aero-hockey");
            window.Closed += WindowClosed;

            Circle circle = new Circle(color: Color.Red, radius: 20);
            circle.setPos(vector: new Vector2f(x: (window.Size.X / 2)-20, y: (window.Size.Y / 2)-20));                                 
            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(color: Color.White);
                window.Draw(circle.ball());
                window.Display();
            }
        }

        private void WindowClosed(object sender, EventArgs e)
        {
            var w = (RenderWindow) sender;
            w.Close();
        }
    }
}