using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace Texture.Animation
{
    public class Animation
    {
        public List<Sprite> Sprites;
        private SpriteRender SpriteRender;
        private GameTime GameTime;

        private int SpriteIndex;
        private float timeElapsed = 0;

        public bool isFinished = false;
        private bool IsRunning = true;
        private bool IsLooping = true;

        private float timeToUpdate = 1f; // 1 second
        private int FramesPerSecond
        {
            set { timeToUpdate = (1f / value); }
        }

        public Animation(SpriteRender SpriteRender, GameTime GameTime)
        {
            Sprites = new List<Sprite>();
            this.SpriteRender = SpriteRender;
            this.GameTime = GameTime;
        }

        public void Play()
        {
            timeElapsed += (float)GameTime.ElapsedGameTime.TotalSeconds; 

            if (timeElapsed > timeToUpdate && IsRunning)
            {
                timeElapsed -= timeToUpdate;

                if (SpriteIndex < Sprites.Count - 1)
                {
                    SpriteIndex++;
                }
                else if (IsLooping)
                {
                    SpriteIndex = 0;

                    isFinished = true;
                }
            }

            SpriteRender.Draw(Sprites[SpriteIndex], new Vector2(300, 300) /**gameObject.position**/);
        }

        public void AddSprite(Sprite sprite)
        {
            Sprites.Add(sprite);
        }

        public void Stop()
        {
            IsRunning = false;
        }
    }
}
