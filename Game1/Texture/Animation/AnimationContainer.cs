using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Texture
{
    using Core.Service;
    using System;

    public class AnimationContainer
    {
        private readonly IDictionary<string, SpriteSheetContainer> spriteSheetContainerList;

        public AnimationContainer()
        {
            spriteSheetContainerList = new Dictionary<string, SpriteSheetContainer>();
        }

        public Sprite getCurrentSprite(string spriteSheetContainerName, string spriteName, GameTime gameTime)
        {
            float gameTotalSeconds = (float)gameTime.TotalGameTime.TotalSeconds;

            float spritesPerSecond = 10;
            float second = 1;

            float refreshRate = second / spritesPerSecond;
            float totalSecondsPerRefreshRate = gameTotalSeconds / refreshRate;

            int animationIndex = (int)Math.Round(totalSecondsPerRefreshRate) % 10;
            
            return SpriteSheetContainer(spriteSheetContainerName).Sprite("cowboy_" + animationIndex + "_0");
        }

        public void Add(string spriteSheetContainerName, SpriteSheetContainer spriteSheetContainer)
        {
            spriteSheetContainerList.Add(spriteSheetContainerName, spriteSheetContainer);
        }

        public SpriteSheetContainer SpriteSheetContainer(string spriteSheetContainerName)
        {
            return spriteSheetContainerList[spriteSheetContainerName];
        }

    }
}
