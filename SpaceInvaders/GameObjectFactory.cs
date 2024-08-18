using Microsoft.Xna.Framework;
using SpaceInvaders.GameObjects;
using SpaceInvaders.SpriteStuff;

namespace SpaceInvaders
{
    public static class GameObjectFactory
    {
        public static Invader CreateInvader(Vector2 position, float size, float speed)
        {
            var enemySpriteSheet = new SpriteSheetAnimation(
                         GameSettings.SpriteSheetTexture,
                         new Rectangle(0, 0, 76, 10),
                         1, 4, 4, 0, 3);

            return new Invader(enemySpriteSheet,
                position,
                new Vector2(size),
                new Vector2(speed, 0));
        }
    }
}
