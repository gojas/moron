using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace World.Scene
{
    using World.Scene.Factory;
    using World.Scene.Loader;
    using World.GameObject;
    using Texture;
    using Core.Service;
    using Terrain;
    using System;

    public class SceneManager
    {
        GraphicsDevice graphicsDevice;
        ContentManager contentManager;
        SpriteManager spriteManager;
        public GameObjectManager GameObjectManager;
        SceneLoader sceneLoader;
        public SceneObjectContainer SceneObjectContainer;

        public Scene Scene;

        public SceneManager(GraphicsDevice graphicsDevice, ContentManager contentManager)
        {
            this.graphicsDevice = graphicsDevice;
            this.contentManager = contentManager;
            this.spriteManager = new SpriteManager(contentManager);
            this.GameObjectManager = new GameObjectManager(contentManager, spriteManager);
            this.SceneObjectContainer = new SceneObjectContainer();
        }

        public SceneManager FirstGet(int id)
        {
            Scene = SceneFactory.Get(id);

            return this;
        }

        public SceneManager ThenLoadScene()
        {
            sceneLoader = new SceneLoader(spriteManager, GameObjectManager, Scene);

            sceneLoader.Load();

            return this;
        }

        public Scene FinallyGetScene()
        {
            return Scene;
        }

        public SceneObjectContainer GetSceneObjectsContainer(int cammeraOffsetX, int cammeraOffsetY)
        {
            int screenHeight = graphicsDevice.Viewport.Height;
            int screenWidth = graphicsDevice.Viewport.Width;
            int[,] matrix = Scene.GameObjectMatrix;


            // For each tile position 
            // for (int row = cammeraOffsetY - screenHeight / 2; row < cammeraOffsetY + Math.Ceiling((float)screenHeight / 2); row++)
            // {
            // for (int column = cammeraOffsetX - screenWidth / 2; column < cammeraOffsetX + Math.Ceiling((float)screenWidth / 2); column++)
            // {
            //
            //}
            // }

            // not optimised at all, grrrr...
            // do something like TerainObjects, GameObjects?



            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int offset_x = 0;
                if (isOdd(row)) {
                    offset_x = Sprite.TILE_TEXTURE_WIDTH / 2;
                }

                for (int column = 0; column < matrix.GetLength(1); column++) {
                    int gameObjectId = matrix[row, column];

                    GameObject gameObject = GameObjectManager.Get(gameObjectId);
                    
                    gameObject.position.X = column * Sprite.TILE_TEXTURE_WIDTH + offset_x;
                    gameObject.position.Y = row * Sprite.TEXTURE_HEIGHT / 2;
                    gameObject.depth = 0;

                    SceneObjectContainer.Add(gameObject);
                }
                
            }

            return SceneObjectContainer;
        }

        public void InitScene()
        {
            
        }

        public void DestroyScene()
        {

        }

        // not here!
        private bool isOdd(int value)
        {
            return value % 2 != 0;
        }

    }
}
