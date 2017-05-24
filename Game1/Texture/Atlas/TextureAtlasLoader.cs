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

        // works only for 64x64 and 128x128 
        public SpriteSheetContainer load(string imageResource)
        {
            var texture = contentManager.Load<Texture2D>(imageResource);

            int columns = texture.Width / TILE_TEXTURE_WIDTH;
            int rows = texture.Height / TILE_TEXTURE_HEIGHT;

            var sheet = new SpriteSheetContainer();

            var scaleWidth = TILE_WIDTH != TILE_TEXTURE_HEIGHT ? TILE_WIDTH / TILE_TEXTURE_WIDTH : 1;
            var scaleHeight = TILE_HEIGHT != TILE_TEXTURE_HEIGHT ? TILE_HEIGHT / TILE_TEXTURE_HEIGHT : 1;

            for (var column = 0; column < columns; column++)
            {
                for (var row = 0; row < rows; row++)
                {
                    //column_1_row_1

                    Rectangle sourceRectangle = new Rectangle(TILE_TEXTURE_WIDTH * column, TILE_TEXTURE_HEIGHT * row, TILE_TEXTURE_WIDTH, TILE_TEXTURE_HEIGHT);
                    Vector2 size = new Vector2(scaleWidth, scaleHeight);

                    sheet.Add(imageResource + "_" + column + "_" + row, new Sprite(texture, sourceRectangle, size));
                }
            }

            return sheet;
        }

    }
}
