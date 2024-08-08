using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SpaceInvaders.SpriteStuff;

namespace SpaceInvaders.GameObjects
{
    public abstract class GameObject
    {
        public SpriteSheet Visualisation;

        public Vector2 Position;
        public Vector2 Scale;
        public bool IsActive;

        protected GameObject(SpriteSheet visualisation)
        {
            Visualisation = visualisation;
            Position = Vector2.Zero;
            Scale = Vector2.One;
            IsActive = true;
        }
        public virtual void Update(GameTime gameTime)
        {
            if (IsActive)
                Visualisation.Update();
        }

        public virtual void Draw(SpriteBatch spritebatch)
        {
            if (IsActive)
                Visualisation.Draw(spritebatch, Position, Scale);
        }

    }
}