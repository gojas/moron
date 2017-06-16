using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace Texture.Animation
{
    public class Animation
    {
        private List<Sprite> Sprites;
        private SpriteRender SpriteRender;
        private GameTime GameTime;
        private float Speed = 1f; // 1 second
        private Vector2 Position;

        private int SpriteIndex;
        private float timeElapsed = 0;

        public bool isFinished = false;
        private bool IsRunning = true;
        private bool IsLooping = true;

        
        private int FramesPerSecond
        {
            set { Speed = (1f / value); }
        }

        public Animation(SpriteRender SpriteRender, GameTime GameTime, float Speed, Vector2 Position)
        {
            Sprites = new List<Sprite>();
            this.SpriteRender = SpriteRender;
            this.GameTime = GameTime;
            this.Speed = Speed;
            this.Position = Position;
        }

        public void Draw()
        {
            timeElapsed += (float)GameTime.ElapsedGameTime.TotalSeconds; 

            if (timeElapsed > Speed && IsRunning)
            {
                timeElapsed -= Speed;

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

            SpriteRender.Draw(Sprites[SpriteIndex], Position);
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
