using System.Collections.Generic;

namespace Texture
{
    public class SpriteSheetContainer
    {
        private readonly IDictionary<string, Sprite> spriteList;

        public SpriteSheetContainer()
        {
            spriteList = new Dictionary<string, Sprite>();
        }

        public void Add(string name, Sprite sprite)
        {
            spriteList.Add(name, sprite);
        }

        public void Add(SpriteSheetContainer otherSheet)
        {
            foreach (var sprite in otherSheet.spriteList)
            {
                spriteList.Add(sprite);
            }
        }

        public Sprite Sprite(string sprite)
        {
            return this.spriteList[sprite];
        }

    }
}