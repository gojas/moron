using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Texture
{

    public class SpriteManager
    {

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

            int columns = texture.Width / TILE_WIDTH;
            int rows = texture.Height / TILE_HEIGHT;

            var spriteContainer = new SpriteContainer();

            if(rows == 0)
                rows = 1;

            for (var column = 0; column < columns; column++)
            {
                for (var row = 0; row < rows; row++)
                {
                    Rectangle sourceRectangle = new Rectangle(TILE_WIDTH * column, TILE_HEIGHT * row, TILE_WIDTH, TILE_HEIGHT);
                    Vector2 size = new Vector2(1, 1);

                    string spriteTextureMap = textureName + "_" + column + "_" + row;

                    spriteContainer.Add(spriteTextureMap, new Sprite(texture, sourceRectangle, size, 0.5f));
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
