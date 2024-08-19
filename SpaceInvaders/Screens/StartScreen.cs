using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using SpaceInvaders.GameObjects;
using SpaceInvaders.SpriteStuff;
using System;
using System.Diagnostics.Eventing.Reader;

namespace SpaceInvaders.Screens
{
    public class StartScreen : Screen
    {
        Random random = new Random();

        public override void LoadContent()
        {
            base.LoadContent();

            CreateInvaders(10);
            CreateText();
        }

        private void CreateText()
        {
            var textVisualisation = new TextVisualisation();
            textVisualisation.Text = "Press space to play :-)";

            ScreenObjects.Add(new TextObject(textVisualisation,
                new Vector2(GameSettings.ScreenWidth / 3, GameSettings.ScreenHeight / 2 + 50), new Vector2(1.5f)));
        }

        private void CreateInvaders(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                bool overlaps = true;
                var newInvader = GameObjectFactory.CreateInvader(new Vector2(), GameSettings.InvaderSize, 0);

                while (overlaps)
                {
                    newInvader.Position = new Vector2(random.Next(GameSettings.ScreenWidth - newInvader.GetPixelSize().X),
                     random.Next(GameSettings.ScreenHeight / 2));
                    overlaps = false;
                    foreach (GameObject obj in ScreenObjects)
                    {
                        if (obj.GetBoundingRect().Intersects(newInvader.GetBoundingRect()))
                        {
                            overlaps = true;
                            break;
                        }
                    }
                }
                ScreenObjects.Add(newInvader);
            }
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                GameSettings.ActiveScreen = new PlayScreen();
                GameSettings.ActiveScreen.LoadContent();
            }
        }

    }
}