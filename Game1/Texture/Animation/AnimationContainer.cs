using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Texture
{
    using Texture.GameObjectTextureDefinition;
    using System;

    public class AnimationContainer
    {
        private readonly IDictionary<string, SpriteSheetContainer> spriteSheetContainerList;

        public AnimationContainer()
        {
            spriteSheetContainerList = new Dictionary<string, SpriteSheetContainer>();
        }

        public Sprite getCurrentSprite(TextureDefinition textureDefinition, GameTime gameTime)
        {
            float gameTotalSeconds = (float)gameTime.TotalGameTime.TotalSeconds;

            float spritesPerSecond = 10;
            float second = 1;

            float refreshRate = second / spritesPerSecond;
            float totalSecondsPerRefreshRate = gameTotalSeconds / refreshRate;

            int animationIndex = (int)Math.Round(totalSecondsPerRefreshRate) % 10;


            // CowboyStandingPistol.spriteList[1]
            string sprite = textureDefinition.GetSpriteIndex(animationIndex);

            return SpriteSheetContainer(textureDefinition.GetContentFile()).Sprite(textureDefinition.GetSpriteIndex(animationIndex));
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
