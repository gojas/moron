using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Texture
{

    public class SpriteManager
    {

        ContentManager contentManager;
        SpriteContainerList spriteContainerList;

        public SpriteManager(ContentManager contentManager)
        {
            this.contentManager = contentManager;
            this.spriteContainerList = new SpriteContainerList();
        }

        public void LoadSpriteSheet(string spriteSheetName, int spriteWidth, int spriteHeight)
        {
            var spriteSheet = contentManager.Load<Texture2D>(spriteSheetName);

            int columns = spriteSheet.Width / spriteWidth;
            int rows = spriteSheet.Height / spriteHeight;

            var spriteContainer = new SpriteContainer();
            
            if(rows == 0)
                rows = 1;

            if (columns == 0)
                columns = 1;

            for (var column = 0; column < columns; column++)
            {
                for (var row = 0; row < rows; row++)
                {
                    Rectangle sourceRectangle = new Rectangle(spriteWidth * column, spriteHeight * row, spriteWidth, spriteHeight);
                    Vector2 size = new Vector2(1, 1);

                    string spriteTextureMap = spriteSheet + "_" + column + "_" + row;

                    spriteContainer.Add(spriteTextureMap, new Sprite(spriteSheet, sourceRectangle, size, 0.5f));
                }
            }

            spriteContainerList.Add(spriteSheetName, spriteContainer);
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
