using System;
using Microsoft.SPOT.Presentation.Media;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TestMonoGame
{
    public class TestGame : Game
    {
        private Vector2 textPosition = Vector2.Zero;
        private Vector2 imagePosition = Vector2.Zero;
        private readonly TimeSpan threeSeconds = new TimeSpan(0, 0, 3);
        private readonly TimeSpan fourSeconds = new TimeSpan(0, 0, 4);
        private SpriteFont font;
        private Texture2D image;

        public override void LoadContent()
        {
            base.LoadContent();

            // Unlike in normal XNA/MonoGame Content is loaded using resource specific functions and named from an enumeration, no by a string

            font = Content.LoadSpriteFont(Resources.FontResources.NinaB);

            image = Content.LoadTexture(Resources.BinaryResources.drawSmall);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            textPosition.Y = (int)Math.Floor(100.0 * ((gameTime.TotalGameTime.Ticks % threeSeconds.Ticks) / (double)threeSeconds.Ticks));
            imagePosition.Y = (int)Math.Floor(100.0 * ((gameTime.TotalGameTime.Ticks % fourSeconds.Ticks) / (double)fourSeconds.Ticks));
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);

            Graphics.GraphicsDevice.Clear();

            SpriteBatch.Begin();

            SpriteBatch.Draw(image, imagePosition);
            // Note that unlike in normal XNA/MonoGame color is an enumeration from Microsoft.SPOT.Presentation.Media that only contains black and white.
            SpriteBatch.DrawString(font, "Hello World", textPosition, Color.White);

            SpriteBatch.End();
        }
    }
}
