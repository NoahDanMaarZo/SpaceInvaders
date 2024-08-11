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

            CreateInvaders(new Vector2(30, 30));
            CreateInvaders(new Vector2(300, 30));
        }

        private void CreateInvaders(Vector2 blockPosition)
        {
            var enemySpriteSheet = new SpriteSheetAnimation(
                GameSettings.SpriteSheetTexture, 
                new Rectangle(0, 0, 76, 10),
                1, 4, 70, 0, 3);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    GameObject newInvader = new Invader(enemySpriteSheet,
                        blockPosition,
                        new Vector2(GameSettings.InvaderSize));
                    newInvader.Position.X += i * 2 * newInvader.GetPixelSize().X;
                    newInvader.Position.Y += j * 2 * newInvader.GetPixelSize().Y;
                    ScreenObjects.Add(newInvader);
                }
            }
        }
    }
}