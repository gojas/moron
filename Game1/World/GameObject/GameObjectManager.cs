using Microsoft.Xna.Framework.Content;

namespace World.GameObject
{
    using World.GameObject.Factory;
    using Texture;

    public class GameObjectManager
    {
        ContentManager contentManager;

        GameObjectContainer gameObjectContainer;
        GameObjectFactory gameObjectFactory;

        public GameObjectManager(ContentManager contentManager, SpriteManager spriteManager)
        {
            this.contentManager = contentManager;
            this.gameObjectFactory = new GameObjectFactory(spriteManager.GetSpriteContainerList());
            this.gameObjectContainer = new GameObjectContainer();
        }

        public GameObject Get(int id)
        {
            return gameObjectFactory.Get(id);
        }

        public GameObjectContainer GetGameObjectContainer()
        {
            return gameObjectContainer;
        }

    }
}
