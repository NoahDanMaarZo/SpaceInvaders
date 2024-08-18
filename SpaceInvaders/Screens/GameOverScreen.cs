using Microsoft.Xna.Framework;
using SpaceInvaders.GameObjects;
using SpaceInvaders.SpriteStuff;

namespace SpaceInvaders.Screens
{
    public class GameOverScreen : Screen
    {
        public override void LoadContent()
        {
            base.LoadContent();
            CreateText();
        }

        private void CreateText()
        {
            var textVisualisation = new TextVisualisation();
            textVisualisation.Text = "Thank you so much for-a playing my game";

            ScreenObjects.Add(new TextObject(textVisualisation, new Vector2(3), new Vector2(2)));
        }
    }
}