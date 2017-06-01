using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

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
        List<GameObject> gameObjectList;

        public ContentManager(Game1 game1)
        {
            game = game1;
        }

        public void loadContent(GraphicsDevice graphicsDevice)
        {
            sceneManager = new SceneManager(graphicsDevice, game.Content);

            sceneManager.FirstGet(1).ThenLoadScene().InitScene();

            quadTree = new QuadTree(new Rectangle(0, 0, game.GraphicsDevice.Viewport.Bounds.Width, game.GraphicsDevice.Viewport.Bounds.Height));

            spriteRender = new SpriteRender(game.getSpriteBatch());

            int cameraOffsetX = (int)game.getCamera().PositionOffset.X;
            int cameraOffsetY = (int)game.getCamera().PositionOffset.Y;

            gameObjectList = sceneManager.GetSceneObjectsContainer(cameraOffsetX, cameraOffsetY).GetAll();
        }

        public void updateInput(GameTime gameTime)
        {
            game.getCamera().Update(gameTime);

            quadTree.clear();

            lock (gameObjectList)
            {
                foreach (var gameObject in gameObjectList)
                {
                    if (null != gameObject.ComponentContainer.GetPhysicsComponent())
                        quadTree.insert(gameObject);
                }
            }

            lock (gameObjectList)
            {
                foreach (var gameObject in gameObjectList.ToArray())
                {
                    /** checking the state of a game, did player hit the wall? **/
                    if (null != gameObject.ComponentContainer.GetPhysicsComponent())
                        gameObject.ComponentContainer.GetPhysicsComponent().update(gameObject, quadTree, sceneManager);

                    /** did player enter specific zone **/
                    if (null != gameObject.ComponentContainer.GetScriptComponent())
                        gameObject.ComponentContainer.GetScriptComponent().update(gameObject, game);

                    /** handle user input here **/
                    if (null != gameObject.ComponentContainer.GetInputComponent())
                        gameObject.ComponentContainer.GetInputComponent().update(gameObject, game);
                }
            }
        }

        public void updateGraphic(GameTime gameTime)
        {

            lock (gameObjectList)
            {
                foreach (var gameObject in gameObjectList)
                {
                    if (null != gameObject.ComponentContainer.GetGraphicComponent())
                        gameObject.ComponentContainer.GetGraphicComponent().update(gameObject, spriteRender, gameTime);
                }
            }

        }
    }
}
