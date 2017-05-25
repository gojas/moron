using Microsoft.Xna.Framework.Content;

namespace World.Scene
{
    using World.Scene.Factory;
    using World.Scene.Loader;
    using World.GameObject;

    public class SceneManager
    {
        ContentManager contentManager;
        GameObjectManager gameObjectManager;
        SceneLoader sceneLoader;

        Scene scene;

        public SceneManager(ContentManager contentManager)
        {
            this.contentManager = contentManager;
            this.gameObjectManager = new GameObjectManager(contentManager);
        }

        public SceneManager FirstGet(int id)
        {
            scene = SceneFactory.Get(id);

            return this;
        }

        public SceneManager ThenLoadScene()
        {
            sceneLoader = new SceneLoader(contentManager, gameObjectManager, scene);

            sceneLoader.Load();

            return this;
        }

        public Scene FinallyGetScene()
        {
            return scene;
        }

        public GameObjectContainer GetGameObjectContainer(int x, int y)
        {
            // based on scene matrix, get array of objects you want to render, i guess...
            // still didn't figure this out XD

            return gameObjectManager.GetGameObjectContainer();
        }

        public void InitScene()
        {

        }

        public void DestroyScene()
        {

        }

    }
}
