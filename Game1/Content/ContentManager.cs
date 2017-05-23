using Microsoft.Xna.Framework;
using Object;
using Object.Factory;
using Core.Service;
using System.Diagnostics;


namespace Content
{
    using Game1;
    using QuadTree;
    using System.Collections.Generic;

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
            quadTree.clear();

            quadTree.insert(new QuadTreeObject(1800, 1200, 10, 10))
                .insert(new QuadTreeObject(42, 32, 10, 10))
                .insert(new QuadTreeObject(43, 33, 10, 10))
                .insert(new QuadTreeObject(623, 12, 10, 10))
                .insert(new QuadTreeObject(1, 900, 10, 10))
                .insert(new QuadTreeObject(1442, 932, 10, 10))
                .insert(new QuadTreeObject(242, 44, 10, 10))
                .insert(new QuadTreeObject(1542, 1052, 10, 10))
                .insert(new QuadTreeObject(2, 12, 10, 10))
                .insert(new QuadTreeObject(442, 82, 10, 10))
                .insert(new QuadTreeObject(32, 333, 10, 10));


            // quad tree, read
            // http://gameprogrammingpatterns.com/spatial-partition.html
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
