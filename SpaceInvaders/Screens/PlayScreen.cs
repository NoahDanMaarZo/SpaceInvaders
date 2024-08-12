using SpaceInvaders.GameObjects;
using SpaceInvaders.SpriteStuff;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace SpaceInvaders.Screens
{
    public class PlayScreen : Screen
    {
        public override void LoadContent()
        {
            ScreenObjects = new List<GameObject>();

            CreateInvaders(new Vector2(1, 30));
            CreateInvaders(new Vector2(500, 30));
        }

        private void CreateInvaders(Vector2 blockPosition)
        {
            var enemySpriteSheet = new SpriteSheetAnimation(
                GameSettings.SpriteSheetTexture, 
                new Rectangle(0, 0, 76, 10),
                1, 4, 70, 0, 3);

            for (int column = 0; column < 3; column++)
            {
                for (int row = 0; row < 3; row++)
                {
                    GameObject newInvader = new Invader(enemySpriteSheet,
                        blockPosition,
                        new Vector2(GameSettings.InvaderSize), 
                        new Vector2(GameSettings.InvaderSpeed, 0));
                    newInvader.Position.X += column * 2 * newInvader.GetPixelSize().X;
                    newInvader.Position.Y += row    * 2 * newInvader.GetPixelSize().Y;
                    ScreenObjects.Add(newInvader);
;
                }
            }

            //GameObject missile = new Missile(enemySpriteSheet, new Vector2(100, 1000), new Vector2(4));
            //ScreenObjects.Add(missile);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            SpaceInvaders.ShouldTurnAround = false;

            // Loop over Invaders
            foreach (var obj in ScreenObjects)
            {
                if (obj.GetType() == typeof(Invader) &&
                obj.Position.X <= 0 || obj.Position.X + obj.GetPixelSize().X >= GameSettings.ScreenWidth)
                {
                    SpaceInvaders.ShouldTurnAround = true;


                    break;
                }

            }
        }
    }
}