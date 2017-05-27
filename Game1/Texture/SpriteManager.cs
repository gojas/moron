using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Texture
{
    public class SpriteManager
    {

        private const int TILE_TEXTURE_WIDTH = 128;
        private const int TILE_TEXTURE_HEIGHT = 128;

        private const int TILE_WIDTH = 128;
        private const int TILE_HEIGHT = 128;

        ContentManager contentManager;
        SpriteContainerList spriteContainerList;

        public SpriteManager(ContentManager contentManager)
        {
            this.contentManager = contentManager;
            this.spriteContainerList = new SpriteContainerList();
        }

        public void Load(string textureName)
        {
            var texture = contentManager.Load<Texture2D>(textureName);

            int columns = texture.Width / TILE_TEXTURE_WIDTH;
            int rows = texture.Height / TILE_TEXTURE_HEIGHT;

            var spriteContainer = new SpriteContainer();

            var scaleWidth = TILE_WIDTH != TILE_TEXTURE_HEIGHT ? TILE_WIDTH / TILE_TEXTURE_WIDTH : 1;
            var scaleHeight = TILE_HEIGHT != TILE_TEXTURE_HEIGHT ? TILE_HEIGHT / TILE_TEXTURE_HEIGHT : 1;

            for (var column = 0; column < columns; column++)
            {
                for (var row = 0; row < rows; row++)
                {
                    //column_1_row_1

                    Rectangle sourceRectangle = new Rectangle(TILE_TEXTURE_WIDTH * column, TILE_TEXTURE_HEIGHT * row, TILE_TEXTURE_WIDTH, TILE_TEXTURE_HEIGHT);
                    Vector2 size = new Vector2(scaleWidth, scaleHeight);

                    spriteContainer.Add(textureName + "_" + column + "_" + row, new Sprite(texture, sourceRectangle, size));
                }
            }

            spriteContainerList.Add(textureName, spriteContainer);
        }

        public SpriteContainer GetSpriteContainer(string spriteContainerName)
        {
            return spriteContainerList.GetSpriteContainer(spriteContainerName);
        }

        public SpriteContainerList GetSpriteContainerList()
        {
            return spriteContainerList;
        }
    }
}
