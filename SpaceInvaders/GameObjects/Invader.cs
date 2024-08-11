using Microsoft.Xna.Framework;
using SpaceInvaders.SpriteStuff;
using System.Windows.Forms;

namespace SpaceInvaders.GameObjects
{
    internal class Invader : GameObject
    {
        public Invader(SpriteSheet visualisation, Vector2 position, Vector2 scale) : base(visualisation, position, scale)
        {

        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);


        }
    }
}
