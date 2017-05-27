using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace Texture
{
    public class TextureAtlasLoader
    {
        private const int TILE_TEXTURE_WIDTH = 128;
        private const int TILE_TEXTURE_HEIGHT = 128;

        private const int TILE_WIDTH = 128;
        private const int TILE_HEIGHT = 128;

        ContentManager contentManager;

        public TextureAtlasLoader(ContentManager aContentManager)
        {
            contentManager = aContentManager;
        }

    }
}
