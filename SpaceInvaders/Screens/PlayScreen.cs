using SpaceInvaders.GameObjects;
using SpaceInvaders.SpriteStuff;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace SpaceInvaders.Screens
{
    public class PlayScreen : Screen
    {
        public override List<GameObject> CreateScreenObjects()
        {
            var enemySpriteSheet = new SpriteSheet(GameSettings.SpriteSheetTexture, new Rectangle(0,0,18,10));

            List<GameObject> list = new List<GameObject>();
            
            list.Add(new Invader(enemySpriteSheet));

            return list;
        }
    }
}