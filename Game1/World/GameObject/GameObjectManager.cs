using Microsoft.Xna.Framework.Content;

namespace World.GameObject
{
    using World.GameObject.Factory;

    public class GameObjectManager
    {
        ContentManager contentManager;

        GameObjectContainer gameObjectContainer;
        private GameObjectFactory gameObjectFactory;

        public GameObjectManager(ContentManager contentManager)
        {
            this.contentManager = contentManager;
            this.gameObjectFactory = new GameObjectFactory(contentManager);
            this.gameObjectContainer = new GameObjectContainer();
        }

        public void Load(int id)
        {
            gameObjectFactory.Load(gameObjectContainer, id);
        }

        public GameObject Get(int id)
        {
            return gameObjectContainer.Get(id);
        }

        public GameObjectContainer GetGameObjectContainer()
        {
            return gameObjectContainer;
        }

    }
}
