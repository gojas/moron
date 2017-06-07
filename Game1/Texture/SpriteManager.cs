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

            int spriteHeight = 128;
            int spriteWidth = 128;

            string sizeParams = textureName.Substring(MathHelper.Max(0, textureName.Length - 3));

            // bla_2_1
            // width 2 x 64
            // height 1 x 64

            if (textureName == "orange_wall_halfcorner_2_1") {
                spriteHeight = 1 * 64;
            }

            if (textureName == "orange_tile_2_1")
            {
                spriteHeight = 1 * 64;
            }


            int columns = texture.Width / spriteWidth;
            int rows = texture.Height / spriteHeight;

            var spriteContainer = new SpriteContainer();

            if(rows == 0)
                rows = 1;

            for (var column = 0; column < columns; column++)
            {
                for (var row = 0; row < rows; row++)
                {
                    Rectangle sourceRectangle = new Rectangle(spriteWidth * column, spriteHeight * row, spriteWidth, spriteHeight);
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
