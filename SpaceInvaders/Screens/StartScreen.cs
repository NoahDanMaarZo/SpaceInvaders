using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using SpaceInvaders.GameObjects;
using SpaceInvaders.SpriteStuff;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;


namespace SpaceInvaders.Screens
{
    public class StartScreen : Screen
    {
        Random random = new Random();

        public override void LoadContent()
        {
            base.LoadContent();

            CreateInvaders();
            CreateText();
        }

        private void CreateText()
        {
            var textVisualisation = new TextVisualisation();
            textVisualisation.Text = "Press space to play :-)";

            ScreenObjects.Add(new TextObject(textVisualisation, new Vector2(3), new Vector2(2)));
        }

        private void CreateInvaders()
        {
            for (int i = 0; i < 10; i++)
            {
                var newInvader = GameObjectFactory.CreateInvader(new Vector2(random.Next(GameSettings.ScreenWidth),
                     random.Next(GameSettings.ScreenHeight)), GameSettings.InvaderSize, 0);
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