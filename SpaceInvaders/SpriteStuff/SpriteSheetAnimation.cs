﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceInvaders.SpriteStuff
{
    public class SpriteSheetAnimation : SpriteSheet
    {

        public int Rows { get; set; }
        public int Columns { get; set; }
        public int SpriteDelayInFrames { get; set; }
        public int StartSpriteIndex { get; set; }
        public int EndSpriteIndex { get; set; }

        //public float Rotation { get; set; } = (float)Math.PI;

        //public float RotationSpeed { get; internal set; } = 0.05f;

        private int _currentSpriteIndex;
        private int _currentSpriteFrame; //number of frames this sprite is already shown

        public SpriteSheetAnimation(Texture2D texture, Rectangle sourceRect,
            int rows, int columns,
            int spriteDelayInFrames, 
            int startSpriteIndex, int endSpriteIndex)
            : base(texture, sourceRect)
        {
            Rows = rows;
            Columns = columns;
            SpriteDelayInFrames = spriteDelayInFrames;
            StartSpriteIndex = startSpriteIndex;
            EndSpriteIndex = endSpriteIndex;
        }

        protected override Rectangle CalculateSourceRect()
        {
            float spriteWidth = _sourceRect.Width / (float)Columns;
            float spriteHeight = _sourceRect.Height / (float)Rows;

            int column = _currentSpriteIndex % Columns;
            int row = _currentSpriteIndex / Columns;

            float x = spriteWidth * column + _sourceRect.X;
            float y = spriteHeight * row + _sourceRect.Y;

            return new Rectangle((int)x, (int)y, (int)spriteWidth, (int)spriteHeight);
        }

        public override void Update()
        {
            _currentSpriteFrame++;
            if (_currentSpriteFrame > SpriteDelayInFrames)
            {
                _currentSpriteFrame = 0;
                _currentSpriteIndex++;
                if (_currentSpriteIndex > EndSpriteIndex)
                {
                    _currentSpriteIndex = StartSpriteIndex;
                }
            }
        }

    }
}
