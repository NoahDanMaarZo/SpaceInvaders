using Microsoft.Xna.Framework;
using SpaceInvaders.GameObjects;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using SpaceInvaders.SpriteStuff;

namespace SpaceInvaders.Screens
{
    public abstract class Screen
    {
        public List<GameObject> ScreenObjects;
        public List<GameObject> NewScreenObjects;

        public void MakeSpriteSheets()
        {

        }
        public virtual void LoadContent()
        {
            ScreenObjects = new List<GameObject>();
            NewScreenObjects = new List<GameObject>();
        }

        public virtual void Update(GameTime gameTime)
        {
            if (ScreenObjects != null)
            {
                foreach (GameObject obj in ScreenObjects)
                {
                    if (!obj.IsActive)
                        continue;
                    obj.Update(gameTime);
                }
                AddNewObjects();
                DestroyObjects();
            }

        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (ScreenObjects != null)
            foreach (GameObject obj in ScreenObjects)
                obj.Draw(spriteBatch);
        }

        public virtual void SpawnMissileAt(Vector2 pos)
        {
            var missileSpriteSheet = new SpriteSheet(
              GameSettings.SpriteSheetTexture,
              new Rectangle(57, 10, 19, 10));

            GameObject missile = new Missile(missileSpriteSheet, pos, new Vector2(4));
            NewScreenObjects.Add(missile);
        }

        public virtual void AddNewObjects()
        {
            if (NewScreenObjects != null)
            {
                 if (NewScreenObjects.Count > 0)
                 foreach (GameObject obj in NewScreenObjects)
                 {
                     ScreenObjects.Add(obj);
                 }
            NewScreenObjects.Clear();
            }
        }
        public virtual void DestroyObjects()
        {
            if (ScreenObjects != null)
            for (int i = ScreenObjects.Count-1; i > -1; i--)
            {
                if (!ScreenObjects[i].IsActive)
                {
                    ScreenObjects.Remove(ScreenObjects[i]);
                }
            }
        }
    }
}