using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using Microsoft.SPOT.Presentation;
using Microsoft.SPOT.Presentation.Media;
using System.Threading;
using Microsoft.Xna.Framework;

namespace TestMonoGame
{
    public class Program
    {
        static Bitmap _display;

        public static void Main()
        {
            // initialize display buffer
            _display = new Bitmap(Bitmap.MaxWidth, Bitmap.MaxHeight);

            // create a game object
            TestGame game = new TestGame();

            // run the game, passing in both the display and the display manager of the project
            game.Run(_display, Resources.ResourceManager);


            // go to sleep; all further code should be timer-driven or event-driven
            Thread.Sleep(Timeout.Infinite);
        }

    }
}
