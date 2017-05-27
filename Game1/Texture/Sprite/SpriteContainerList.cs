using System.Collections.Generic;

namespace Texture
{
    public class SpriteContainerList
    {
        private readonly IDictionary<string, SpriteContainer> spriteContainerList;

        public SpriteContainerList()
        {
            spriteContainerList = new Dictionary<string, SpriteContainer>();
        }

        public void Add(string name, SpriteContainer spriteContainer)
        {
            spriteContainerList.Add(name, spriteContainer);
        }

        public SpriteContainer GetSpriteContainer(string spriteContainerName)
        {
            return this.spriteContainerList[spriteContainerName];
        }

    }
}