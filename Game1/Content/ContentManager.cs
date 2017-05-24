using Microsoft.Xna.Framework;
using GameObject.Factory;
using Core.Service;
using System.Diagnostics;


namespace Content
{
    using GameObject;
    using Game1;
    using QuadTree;

    public class ContentManager : IContentManager
    {
        Game1 game;

        GameObjectContainer gameObjectContainer;
        GameObjectFactory gameObjectFactory;
        QuadTree quadTree;

        public ContentManager(Game1 game1)
        {
            game = game1;

            gameObjectContainer = new GameObjectContainer();
        }

        public void loadContent()
        {
            gameObjectFactory = ServiceContainer.GetService<GameObjectFactory>();

            quadTree = new QuadTree(new Rectangle(0, 0, game.GraphicsDevice.Viewport.Bounds.Width, game.GraphicsDevice.Viewport.Bounds.Height));

            Debug.WriteLine(game.GraphicsDevice.Viewport.Bounds.Width + " " + game.GraphicsDevice.Viewport.Bounds.Height);

            

             // will use add range when we initialize ALL game objects of the current scene...
            gameObjectContainer.add(gameObjectFactory.get(2));
            gameObjectContainer.add(gameObjectFactory.get(0));
            gameObjectContainer.add(gameObjectFactory.get(1));
            gameObjectContainer.add(gameObjectFactory.get(3));
            gameObjectContainer.add(gameObjectFactory.get(4));
            gameObjectContainer.add(gameObjectFactory.get(5));
        }

        public void updateInput(GameTime gameTime)
        {
            game.getCamera().Update(gameTime);

            quadTree.clear();

            gameObjectContainer.getAll().ForEach((gameObject) =>
            {
                if(null != gameObject.getComponentContainer().getInputComponent())
                    gameObject.getComponentContainer().getInputComponent().update(gameObject);

                // prepare data for physics component
                if (null != gameObject.getComponentContainer().getPhysicsComponent())
                    quadTree.insert(gameObject);
            });
        }

        public void updatePhysics()
        {

            // check for collision, explosion, and other stuff...
            gameObjectContainer.getAll().ForEach((gameObject) =>
            {
                if (null != gameObject.getComponentContainer().getPhysicsComponent())
                    gameObject.getComponentContainer().getPhysicsComponent().update(gameObject, quadTree);
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
