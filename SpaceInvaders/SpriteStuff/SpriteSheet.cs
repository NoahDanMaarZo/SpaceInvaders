using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace SpaceInvaders.SpriteStuff
{
    public class SpriteSheet
    {
        public Texture2D Texture { get; set; }
        protected Rectangle _sourceRect;
        
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

        public void Draw(SpriteBatch spriteBatch, Vector2 pos, Vector2 scale /*, float rot = (float)Math.PI*/)
        {
            var sourceRect = CalculateSourceRect();
            var destinationRect = CalculateDestinationRectangle(pos, scale);

            spriteBatch.Draw(Texture, destinationRect, sourceRect, DisplayedColor);
        }

        public Rectangle CalculateDestinationRectangle(Vector2 pos, Vector2 scale)
        {
            return new Rectangle(pos.ToPoint(), CalculateSourceRect().Size * scale.ToPoint());
        }

        public virtual void Update() { }
    }
}
