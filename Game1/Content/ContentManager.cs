using Microsoft.Xna.Framework;

namespace Content
{
    using Game1;
    using QuadTree;
    using Texture;
    using World.Scene;
    using World.GameObject;
    using System.Collections.Generic;

    public class ContentManager : IContentManager
    {
        Game1 game;

        SceneManager sceneManager;
        
        QuadTree quadTree;
        SpriteRender spriteRender;

        public ContentManager(Game1 game1)
        {
            game = game1;
        }

        public void loadContent()
        {
            sceneManager = new SceneManager(game.Content);

            sceneManager.FirstGet(1).ThenLoadScene();

            quadTree = new QuadTree(new Rectangle(0, 0, game.GraphicsDevice.Viewport.Bounds.Width, game.GraphicsDevice.Viewport.Bounds.Height));

            spriteRender = new SpriteRender(game.getSpriteBatch());
        }

        public void updateInput(GameTime gameTime)
        {
            game.getCamera().Update(gameTime);

            quadTree.clear();

            // 1, 2 means get only specific objects, based on position.X and position.Y
            IDictionary<int, GameObject> objectList = sceneManager.GetGameObjectContainer(1, 2).GetAll();

            foreach (var item in objectList)
            {
                // prepare data for physics component
                if (null != item.Value.getComponentContainer().getPhysicsComponent())
                    quadTree.insert(item.Value);
            }

            foreach (var item in objectList)
            {
                /** handle user input here **/
                if (null != item.Value.getComponentContainer().getInputComponent())
                    item.Value.getComponentContainer().getInputComponent().update(item.Value, game);

                /** checking the state of a game, did player hit the wall? **/
                if (null != item.Value.getComponentContainer().getPhysicsComponent())
                    item.Value.getComponentContainer().getPhysicsComponent().update(item.Value, quadTree);
            }
        }

        public void updateGraphic(GameTime gameTime)
        {
            IDictionary<int, GameObject> objectList = sceneManager.GetGameObjectContainer(1, 2).GetAll();

            foreach (var item in objectList)
            {
                if (null != item.Value.getComponentContainer().getGraphicComponent())
                    item.Value.getComponentContainer().getGraphicComponent().update(item.Value, spriteRender, gameTime);
            }

        }
    }
}
