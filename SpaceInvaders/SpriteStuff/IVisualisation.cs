using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace SpaceInvaders.SpriteStuff
{
    public interface IVisualisation
    {
        public Color DisplayedColor { get; set; }

        public void Draw(SpriteBatch spriteBatch, Vector2 pos, Vector2 scale);

        public void Update();

        public Rectangle CalculateDestinationRectangle(Vector2 pos, Vector2 scale);


    }
}
