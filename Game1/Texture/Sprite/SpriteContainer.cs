using System.Collections.Generic;

namespace Texture
{
    public class SpriteContainer
    {
        private readonly IDictionary<string, Sprite> spriteList;

        public SpriteContainer()
        {
            spriteList = new Dictionary<string, Sprite>();
        }

        public void Add(string name, Sprite sprite)
        {
            spriteList.Add(name, sprite);
        }

        public void Add(SpriteContainer otherSheet)
        {
            foreach (var sprite in otherSheet.spriteList)
            {
                spriteList.Add(sprite);
            }
        }

        public Sprite GetSpriteByName(string sprite)
        {
            return this.spriteList[sprite];
        }

    }
}