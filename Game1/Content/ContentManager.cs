using Microsoft.Xna.Framework;
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
            gameObjectContainer.add(gameObjectFactory.get(1));
        }

        public void updateInput(GameTime gameTime)
        {
            game.getCamera().Update(gameTime);

            gameObjectContainer.getAll().ForEach((gameObject) =>
            {
                if(null != gameObject.getComponentContainer().getInputComponent())
                    gameObject.getComponentContainer().getInputComponent().update(gameObject);
            });
        }

        public void updatePhysics()
        {
            // check for collision, explosion, and other stuff...
            gameObjectContainer.getAll().ForEach((gameObject) =>
            {
                if (null != gameObject.getComponentContainer().getPhysicsComponent())
                    gameObject.getComponentContainer().getPhysicsComponent().update(gameObject);
            });
        }

        public void updateGraphic()
        {

            gameObjectContainer.getAll().ForEach((gameObject) =>
            {
                if(null != gameObject.getComponentContainer().getGraphicComponent())
                    gameObject.getComponentContainer().getGraphicComponent().update(gameObject);
            });

        }
    }
}
