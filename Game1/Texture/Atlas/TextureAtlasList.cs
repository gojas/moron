using System.Collections.Generic;

namespace Texture
{
    public class TextureAtlasList
    {
        private readonly IDictionary<string, TextureAtlas> textureAtlasList;

        public TextureAtlasList()
        {
            textureAtlasList = new Dictionary<string, TextureAtlas>();
        }

        public void Add(string name, TextureAtlas textureAtlas)
        {
            textureAtlasList.Add(name, textureAtlas);
        }

        public TextureAtlas Texture(string texture)
        {
            return this.textureAtlasList[texture];
        }

    }
}