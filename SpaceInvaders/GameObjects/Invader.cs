using Microsoft.Xna.Framework;
using SpaceInvaders.SpriteStuff;
using System.Windows.Forms;

namespace SpaceInvaders.GameObjects
{
    internal class Invader : GameObject
    {
        public Vector2 Velocity;

        public Invader(SpriteSheet visualisation, Vector2 position, Vector2 scale, Vector2 velocity) : base(visualisation, position, scale)
        {
            Velocity = velocity;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);


        }
    }
}
