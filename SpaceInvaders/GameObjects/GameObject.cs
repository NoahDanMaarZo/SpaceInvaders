using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.DirectWrite;
using SpaceInvaders.SpriteStuff;

namespace SpaceInvaders.GameObjects
{
    public abstract class GameObject
    {
        public SpriteSheet Visualisation;

        public Vector2 Position;
        public Vector2 Scale;
        public bool IsActive;

        protected GameObject(SpriteSheet visualisation, Vector2 position, Vector2 scale)
        {
            Visualisation = visualisation;
            Position = position;
            Scale = scale;
            IsActive = true;
        }

        public Point GetPixelSize()
        {
            return Visualisation.CalculateDestinationRectangle(Position, Scale).Size;
        }

        public Rectangle GetBoundingRect()
        { 
            return Visualisation.CalculateDestinationRectangle(Position, Scale);
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