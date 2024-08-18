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
            ScreenObjects = new List<GameObject>();
            NewScreenObjects = new List<GameObject>();

            for (int i = 0; i < 10; i++)
            {
            var newInvader = GameObjectFactory.CreateInvader(new Vector2(random.Next(GameSettings.ScreenWidth), 
                 random.Next(GameSettings.ScreenHeight)), GameSettings.InvaderSize, 0);
            ScreenObjects.Add(newInvader);
            }

            var spriteFont = GameSettings.ArialFont;

            var newText = new TextObject(GameSettings.ArialFont, new Vector2(30),new Vector2(20));
            ScreenObjects.Add(newText);

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