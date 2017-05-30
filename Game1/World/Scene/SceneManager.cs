using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace World.Scene
{
    using World.Scene.Factory;
    using World.Scene.Loader;
    using World.GameObject;
    using Texture;
    using Core.Service;
    using Terrain;

    public class SceneManager
    {
        ContentManager contentManager;
        SpriteManager spriteManager;
        GameObjectManager gameObjectManager;
        SceneLoader sceneLoader;

        Scene scene;

        public SceneManager(ContentManager contentManager)
        {
            this.contentManager = contentManager;
            this.spriteManager = new SpriteManager(contentManager);
            this.gameObjectManager = new GameObjectManager(contentManager, spriteManager);
        }

        public SceneManager FirstGet(int id)
        {
            scene = SceneFactory.Get(id);

            return this;
        }

        public SceneManager ThenLoadScene()
        {
            sceneLoader = new SceneLoader(spriteManager, gameObjectManager, scene);

            sceneLoader.Load();

            return this;
        }

        public Scene FinallyGetScene()
        {
            return scene;
        }

        public SceneObjectContainer GetSceneObjectsContainer(int materX, int materY)
        {
            int[,] matrix = scene.GetGameObjectMatrix();

            // not optimised at all, grrrr...
            // do something like TerainObjects, GameObjects?
            SceneObjectContainer sceneObjects = new SceneObjectContainer();

            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int offset_x = 0;
                if (isOdd(row)) {
                    offset_x = Sprite.TILE_TEXTURE_WIDTH / 2;
                }

                for (int column = 0; column < matrix.GetLength(1); column++) {
                    int gameObjectId = matrix[row, column];

                    GameObject gameObject = gameObjectManager.Get(gameObjectId);
                    
                    gameObject.position.X = column * Sprite.TILE_TEXTURE_WIDTH + offset_x;
                    gameObject.position.Y = row * Sprite.TEXTURE_HEIGHT / 2;
                    gameObject.depth = 0;

                    sceneObjects.Add(gameObject);
                }
                
            }

            return sceneObjects;
        }

        public void InitScene()
        {
            
        }

        public void DestroyScene()
        {

        }

        // not here!
        private bool isOdd(int value)
        {
            return value % 2 != 0;
        }

    }
}
