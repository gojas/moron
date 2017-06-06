namespace World.Terrain
{
    using Texture;
    
    using Terrain.Factory;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using World;
    using Scene;
    using Microsoft.Xna.Framework.Graphics;

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
                    offset_x = Tile.WIDTH / 2;
                }

                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    int terrainId = matrix[row, column];

                    Tile tile = TerrainFactory.Get(terrainId);

                    int positionX = column * Tile.WIDTH + offset_x;
                    int positionY = row * Tile.HEIGHT / 2;

                    var texture = ContentManager.Load<Texture2D>(tile.SpriteSheetName);

                    depth += 0.001f;

                    Sprite sprite = new Sprite(
                        texture, 
                        new Rectangle(tile.SpriteSheetContainerMappingX, tile.SpriteSheetContainerMappingY, Tile.WIDTH, Tile.HEIGHT), // 0, 0 draw from upper left corner
                        new Vector2(1,1), // normal size draw
                        depth
                    );

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
