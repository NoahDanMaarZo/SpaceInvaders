using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceInvaders.SpriteStuff
{
    public class SpriteSheet
    {
        public Texture2D Texture { get; set; }
        private Rectangle _sourceRect;
        
        public Color DisplayedColor { get; set; } = Color.White;

        public SpriteSheet(Texture2D texture, Rectangle sourceRect)
        {
            Texture = texture;
            _sourceRect = sourceRect;
        }

        protected virtual Rectangle CalculateSourceRect()
        {
            return _sourceRect;
        }

        private Rectangle CalculateDestinationRect(Rectangle sourceRect, Vector2 scale)
        {
            var size = sourceRect.Size.ToVector2() * scale;
            return new Rectangle(sourceRect.Location, size.ToPoint());
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 pos, Vector2 scale /*, float rot = (float)Math.PI*/)
        {
            var sourceRect = CalculateSourceRect();
            spriteBatch.Draw(Texture, CalculateDestinationRect(sourceRect, scale), sourceRect, DisplayedColor);
        }

        public virtual void Update() { }
    }
}
