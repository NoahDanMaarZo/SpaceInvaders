using Microsoft.Xna.Framework;
using SpaceInvaders.SpriteStuff;

namespace SpaceInvaders.GameObjects
{
    public class TextObject : GameObject
    {
        public TextObject(TextVisualisation visualisation, Vector2 position, Vector2 scale) : base(visualisation, position, scale)
        {
        }
    }
}
