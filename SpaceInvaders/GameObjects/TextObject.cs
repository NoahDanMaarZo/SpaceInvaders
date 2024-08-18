using Microsoft.Xna.Framework;
using SpaceInvaders.SpriteStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.GameObjects
{
    public class TextObject : GameObject
    {
        public TextObject(TextVisualisation visualisation, Vector2 position, Vector2 scale) : base(visualisation, position, scale)
        {
        }
    }
}
