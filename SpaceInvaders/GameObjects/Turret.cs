using Microsoft.Xna.Framework;
using SpaceInvaders.SpriteStuff;
using Microsoft.Xna.Framework.Input;

namespace SpaceInvaders.GameObjects
{
    internal class Turret : GameObject
    {
        public Turret(SpriteSheet visualisation, Vector2 position, Vector2 scale) : base(visualisation, position, scale)
        {

        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                Position.X -= GameSettings.TurretSpeed;
                if (Position.X <= 0)
                    Position.X = 0;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                Position.X += GameSettings.TurretSpeed;
                if (Position.X >= GameSettings.ScreenWidth - GetPixelSize().X)
                    Position.X = GameSettings.ScreenWidth - GetPixelSize().X;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && 
                SpaceInvaders.previousKeyboardState.IsKeyUp(Keys.Space))
            {
                GameSettings.ActiveScreen.SpawnMissileAt(Position);
            }
        }
    }
}
