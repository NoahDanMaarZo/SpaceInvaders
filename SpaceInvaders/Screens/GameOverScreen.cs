using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using SpaceInvaders.GameObjects;
using SpaceInvaders.SpriteStuff;
using System;
using System.Collections.Generic;

namespace SpaceInvaders.Screens
{
    public class GameOverScreen : Screen
    {
        public override void LoadContent()
        {
            base.LoadContent();
            ScreenObjects = new List<GameObject>();
            NewScreenObjects = new List<GameObject>();

            var enemySpriteSheet = new SpriteSheetAnimation(
                         GameSettings.SpriteSheetTexture,
                         new Rectangle(0, 0, 76, 10),
                         1, 4, 4, 0, 3);

        }
    }
}