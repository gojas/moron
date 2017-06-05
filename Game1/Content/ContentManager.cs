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

            gameObjectList = sceneManager.GameObjectManager.Get(
                sceneManager,
                (int)game.getCamera().PositionOffset.X,
                (int)game.getCamera().PositionOffset.Y
            );
        }

        public void updateInput(GameTime gameTime)
        {
            game.getCamera().Update(gameTime);

            quadTree.clear();

            sceneManager.GameObjectManager.Update(sceneManager, quadTree, game.getCamera());

        }

        public void updateGraphic(GameTime gameTime)
        {

            sceneManager.TerrainManager.Draw(spriteRender, sceneManager);
            sceneManager.GameObjectManager.Draw(spriteRender, gameTime);
        }
    }
}
