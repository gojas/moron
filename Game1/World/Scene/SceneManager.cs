using Microsoft.Xna.Framework.Content;

namespace World.Scene
{
    using World.Scene.Factory;
    using World.Scene.Loader;
    using World.GameObject;
    using Texture;

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

        public SceneObjectContainer GetSceneObjectsContainer(int x, int y)
        {
            int[,] matrix = scene.GetGameObjectMatrix();

            // not optimised at all, grrrr...
            // do something like TerainObjects, GameObjects?
            SceneObjectContainer sceneObjects = new SceneObjectContainer();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int firstLayerObjectId = matrix[i, 0];
                int secondLayerObjectId = matrix[i, 1];

                GameObject firstLayerObject = gameObjectManager.Get(firstLayerObjectId);
                GameObject secondLayerObject = gameObjectManager.Get(secondLayerObjectId);
                
                firstLayerObject.position.X = i * 128;
                firstLayerObject.position.Y = i * 128;
                firstLayerObject.depth = 0;

                secondLayerObject.depth = 0.5f;

                sceneObjects.Add(firstLayerObject);
                sceneObjects.Add(secondLayerObject);
            }

            return sceneObjects;
        }

        public void InitScene()
        {
            
        }

        public void DestroyScene()
        {

        }

    }
}
