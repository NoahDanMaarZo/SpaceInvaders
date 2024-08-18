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
            base.LoadContent();
            ScreenObjects = new List<GameObject>();
            NewScreenObjects = new List<GameObject>();

            CreateInvaders(new Vector2(1, 30));
            CreateInvaders(new Vector2(500, 30));

            var turretSpriteSheet = new SpriteSheetAnimation(
                  GameSettings.SpriteSheetTexture,
                  new Rectangle(0, 10, 57, 10),
                  1, 3, 10, 0, 2);

            GameObject turret = new Turret(turretSpriteSheet,
              new Vector2(GameSettings.ScreenWidth / 2,
             GameSettings.ScreenHeight - 40),
              new Vector2(4));
            ScreenObjects.Add(turret);
        }

        private void CreateInvaders(Vector2 blockPosition)
        {
            for (int column = 0; column < 3; column++)
            {
                for (int row = 0; row < 3; row++)
                {

                    var newInvader = GameObjectFactory.CreateInvader(blockPosition, GameSettings.InvaderSize, GameSettings.InvaderSpeed);
                    newInvader.Position.X += column * 2 * newInvader.GetPixelSize().X;
                    newInvader.Position.Y += row    * 2 * newInvader.GetPixelSize().Y;
                    ScreenObjects.Add(newInvader);
;
                }
            }
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            SpaceInvaders.ShouldTurnAround = false;

            // Loop over Invaders
            if (ScreenObjects != null)
            foreach (var obj in ScreenObjects)
            {
                if (obj is Invader && 
                   (obj.Position.X <= 0 || obj.Position.X + obj.GetPixelSize().X >= GameSettings.ScreenWidth))
                {
                    SpaceInvaders.ShouldTurnAround = true;

                    break;
                }

            }
            if (ScreenObjects != null)
            if (!ThereAreInvaders())
            {
               ScreenObjects.Clear();
                    GameSettings.ActiveScreen = new GameOverScreen();
                    GameSettings.ActiveScreen.LoadContent();
            }

        }
        public override void SpawnMissileAt(Vector2 pos)
        {
            base.SpawnMissileAt(pos);
        }

        private bool ThereAreInvaders()
        {
            if (ScreenObjects != null)
            foreach(var obj in ScreenObjects)
            {
                if (obj is Invader) return true;
            }
            return false;
        }

}
}