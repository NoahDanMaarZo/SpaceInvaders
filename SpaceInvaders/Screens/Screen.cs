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

        //public SpriteSheet enemySpriteSheet = new SpriteSheetAnimation(
        //       GameSettings.SpriteSheetTexture,
        //       new Rectangle(0, 0, 76, 10),
        //       1, 4, 70, 0, 3);

        //the spritesheets shouldn't just be available to the playscreen

        public void MakeSpriteSheets()
        {

        }
        public virtual void LoadContent()
        {
            //List<GameObject> ScreenObjects = new List<GameObject>();
            List<GameObject> NewScreenObjects = new List<GameObject>();
        }

        public virtual void Update(GameTime gameTime)
        {

            foreach (GameObject obj in ScreenObjects)
            {
                //if (!obj.IsActive)
                //    continue;
                obj.Update(gameTime);
            }
            AddNewObjects();
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
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
            if (NewScreenObjects.Count > 0)
            foreach (GameObject obj in NewScreenObjects)
            {
                ScreenObjects.Add(obj);
            }
            NewScreenObjects.Clear();
        }
    }
}