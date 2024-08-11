using Microsoft.Xna.Framework;
using SpaceInvaders.GameObjects;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceInvaders.Screens
{
    public abstract class Screen
    {
        public List<GameObject> ScreenObjects;
        public virtual void LoadContent()
        {
            List<GameObject> ScreenObjects = new List<GameObject>();
        }

        public virtual void Update(GameTime gameTime)
        {
            foreach (GameObject obj in ScreenObjects)
                obj.Update(gameTime);
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            foreach (GameObject obj in ScreenObjects)
                obj.Draw(spriteBatch);
        }
    }
}