using Microsoft.Xna.Framework;
using SpaceInvaders.SpriteStuff;

namespace SpaceInvaders.GameObjects
{
    public class Missile : GameObject
    {
        public Missile(SpriteSheet visualisation, Vector2 position, Vector2 scale) : base(visualisation, position, scale)
        {

        }
        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);

            foreach (var gameObject in GameSettings.ActiveScreen.ScreenObjects)
            {
                if (gameObject == this || !gameObject.IsActive)
                    continue;

                if (gameObject.GetType() == typeof(Invader)
                    && gameObject.GetBoundingRect().Intersects(GetBoundingRect()))
                {
                    gameObject.IsActive = false;
                    this.IsActive = false;
                }
            }
            

            Position.Y -= 2;
        }
    }
}
