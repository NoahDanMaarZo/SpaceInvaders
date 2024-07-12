using Microsoft.Xna.Framework.Graphics;
using SpaceInvaders.Screens;
using System.Numerics;

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

        StartScreen StartScreen;

        PlayScreen PlayScreen;

        GameOverScreen GameOverScreen;

        public Screen ActiveScreen;

        public Texture2D SpriteSheetTexture;

    }
}