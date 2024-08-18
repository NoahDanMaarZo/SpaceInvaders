using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.SpriteStuff
{
    public class TextVisualisation : IVisualisation
    {
        public Color DisplayedColor { get; set; } = Color.Black;

        public string Text { get; set; } = "lorem ipsum";

        public Rectangle CalculateDestinationRectangle(Vector2 pos, Vector2 scale)
        {
            return new Rectangle();
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 pos, Vector2 scale)
        {
            spriteBatch.DrawString(GameSettings.ArialFont, Text,
                pos, DisplayedColor, 0, 
                Vector2.Zero, scale, SpriteEffects.None, 0);
        }

        public void Update()
        {
        }
    }
}
