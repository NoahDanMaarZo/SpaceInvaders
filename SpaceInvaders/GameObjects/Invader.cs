using Microsoft.Xna.Framework;
using SpaceInvaders.SpriteStuff;

namespace SpaceInvaders.GameObjects
{
    public class Invader : GameObject
    {
        public Vector2 Velocity;

        public Invader(SpriteSheet visualisation, Vector2 position, Vector2 scale, Vector2 velocity) : base(visualisation, position, scale)
        {
            Velocity = velocity;
        }

        public void CheckIfWeShouldTurnAround()
        {
            if (Position.X <= 0 || Position.X + GetPixelSize().X >= GameSettings.ScreenWidth)
            {
                //GameSettings.PlayScreen.InvadersShouldTurnAround
                //SpaceInvaders.ShouldTurnAround = true;
            }
        }

        private void TurnAround()
        {
            Velocity = -Velocity;
            Position += Velocity;
            Position.Y += GetPixelSize().Y;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if (SpaceInvaders.ShouldTurnAround)
            {
                TurnAround();
            }
            Position += Velocity;
        }
    }
}
