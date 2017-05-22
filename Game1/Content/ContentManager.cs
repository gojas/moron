using Object;
using Object.Factory;
using Core.Service;

namespace Content
{
    using Game1;

    public class ContentManager : IContentManager
    {
        Game1 game;

        GameObjectContainer gameObjectContainer;
        GameObjectFactory gameObjectFactory;

        public ContentManager(Game1 game1)
        {
            game = game1;

            gameObjectContainer = new GameObjectContainer();
        }

        public void loadContent()
        {
            gameObjectFactory = ServiceContainer.GetService<GameObjectFactory>();

            // will use add range when we initialize ALL game objects of the current scene...
            gameObjectContainer.add(gameObjectFactory.get(0));
        }

        public void updateInput()
        {
            gameObjectContainer.getAll().ForEach((gameObject) =>
            {
                gameObject.getComponentContainer().getInputComponent().update(gameObject);
            });
        }

        public void updatePhysics()
        {
            // check for collision, explosion, and other stuff...
        }

        public void updateGraphic()
        {

            gameObjectContainer.getAll().ForEach((gameObject) =>
            {
                gameObject.getComponentContainer().getGraphicComponent().update(gameObject);
            });

        }
    }
}
