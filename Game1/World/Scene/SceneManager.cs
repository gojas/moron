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

        public TerrainManager TerrainManager;
        public GameObjectManager GameObjectManager;
        public SceneLoader sceneLoader; // loader, but also provider!!!, change name do something smart!

        public Scene Scene;

        public SceneManager(GraphicsDevice graphicsDevice, ContentManager contentManager)
        {
            this.graphicsDevice = graphicsDevice;
            this.contentManager = contentManager;
            this.spriteManager = new SpriteManager(contentManager);
            this.GameObjectManager = new GameObjectManager(contentManager, spriteManager);
            this.TerrainManager = new TerrainManager(contentManager);
        }

        public SceneManager FirstGet(int id)
        {
            Scene = SceneFactory.Get(id);

            return this;
        }

        public SceneManager ThenLoadScene()
        {
            sceneLoader = new SceneLoader(spriteManager, GameObjectManager, TerrainManager, Scene);

            sceneLoader.Load();

            return this;
        }

        public Scene FinallyGetScene()
        {
            return Scene;
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
