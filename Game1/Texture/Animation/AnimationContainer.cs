using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Texture
{
    using Texture.GameObjectTextureDefinition;
    using System;

    public class AnimationContainer
    {
        private readonly IDictionary<string, SpriteContainer> spriteSheetContainerList;

        public AnimationContainer()
        {
            spriteSheetContainerList = new Dictionary<string, SpriteContainer>();
        }

        public Sprite getCurrentSprite(TextureDefinition textureDefinition, GameTime gameTime)
        {
            float gameTotalSeconds = (float)gameTime.TotalGameTime.TotalSeconds;

            float spritesPerSecond = textureDefinition.GetSriteTotal();
            float second = 1;

            float refreshRate = second / spritesPerSecond;
            float totalSecondsPerRefreshRate = gameTotalSeconds / refreshRate;

            int animationIndex = (int)Math.Round(totalSecondsPerRefreshRate) % 10;


            // CowboyStandingPistol.spriteList[1]
            string sprite = textureDefinition.GetSpriteIndex(animationIndex);

            

            return SpriteSheetContainer(textureDefinition.GetContentFile()).GetSpriteByName(textureDefinition.GetSpriteIndex(animationIndex));
        }

        public Sprite GetSpriteBasedOnTextureDefinitionAndIndex(TextureDefinition textureDefinition, int spriteIndex)
        {
            return SpriteSheetContainer(textureDefinition.GetContentFile()).GetSpriteByName(textureDefinition.GetSpriteIndex(spriteIndex));
        }

        public void Add(string spriteSheetContainerName, SpriteContainer spriteSheetContainer)
        {
            spriteSheetContainerList.Add(spriteSheetContainerName, spriteSheetContainer);
        }

        public SpriteContainer SpriteSheetContainer(string spriteSheetContainerName)
        {
            return spriteSheetContainerList[spriteSheetContainerName];
        }

    }
}
