namespace World.Terrain
{
    using Texture;
    
    using Terrain.Factory;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Content;
    using Scene;

    public class TerrainManager
    {
        ContentManager ContentManager;
        TerrainContainer TerrainContainer;
        TerrainFactory TerrainFactory;

        public TerrainManager(ContentManager ContentManager)
        {
            this.ContentManager = ContentManager;
            TerrainFactory = new TerrainFactory();
            TerrainContainer = new TerrainContainer();
        }

        public void Load(int id)
        {
            //TerrainFactory.Load(id);
        }

        public void Draw(SpriteRender spriteRender, SceneManager sceneManager)
        {
            int[,] matrix = sceneManager.Scene.GetTerrainMatrix();

            float depth = 0.3f;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int offset_x = 0;
                if (IsOdd(row))
                {
                    offset_x = Sprite.TILE_TEXTURE_WIDTH / 2;
                }

                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    int terrainId = matrix[row, column];

                    Tile tile = TerrainFactory.Get(terrainId);

                    int positionX = column * Sprite.TILE_TEXTURE_WIDTH + offset_x;
                    int positionY = row * Sprite.TEXTURE_HEIGHT / 2;

                    Rectangle sourceRectangle = new Rectangle(Sprite.TILE_TEXTURE_WIDTH * column, Sprite.TILE_TEXTURE_HEIGHT * row, Sprite.TILE_TEXTURE_WIDTH, Sprite.TILE_TEXTURE_HEIGHT);

                    string spriteName = tile.GetSpriteNameBasedOnMapping();

                    Sprite sprite = sceneManager.sceneLoader.SpriteManager.GetSpriteContainer(tile.SpriteSheetName).GetSpriteByName(spriteName);

                    depth += 0.001f;

                    sprite.Depth = depth;

                    spriteRender.Draw(sprite, new Vector2(positionX, positionY));
                }

            }
        }

        // not here!
        private bool IsOdd(int value)
        {
            return value % 2 != 0;
        }



    }
}
