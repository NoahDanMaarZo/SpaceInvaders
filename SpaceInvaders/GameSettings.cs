using Microsoft.Xna.Framework.Graphics;
using SpaceInvaders.Screens;
using System.Collections.Generic;

namespace SpaceInvaders
{

    public class GameSettings
    {
        const int ScreenWidth = 1200;
        const int ScreenHeight = 800;

        public static float InvaderSize => 10f;
        public static float TurretSize => 10f;
        public static float MissileSize => 10f;

        public static float InvaderSpeed => 1f;
        public static float TurretSpeed => 1f;
        public static float MissileSpeed => 1f;

        public static StartScreen StartScreen = new StartScreen();
        public static PlayScreen PlayScreen = new PlayScreen();
        public static GameOverScreen GameOverScreen = new GameOverScreen();

        public static Screen ActiveScreen = null;

        public static Texture2D SpriteSheetTexture = null;

    }
}