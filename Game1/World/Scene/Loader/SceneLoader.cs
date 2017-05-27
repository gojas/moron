using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace World.Scene.Loader
{
    using World.GameObject;
    using Texture;

    public class SceneLoader
    {
        SpriteManager spriteManager;
        GameObjectManager gameObjectManager;

        Scene scene;

        public SceneLoader(
            SpriteManager spriteManager,
            GameObjectManager gameObjectManager,
            Scene scene)
        {
            this.spriteManager = spriteManager;
            this.gameObjectManager = gameObjectManager;
            this.scene = scene;
        }

        public void Load()
        {
            loadContent();
            loadObjects();
        }

        private void loadContent()
        {
            loadTextures();
        }

        private void loadTextures()
        {
            string[] textures = scene.GetTextures();

            foreach (string texture in textures)
                spriteManager.Load(texture);
        }

        private void loadObjects()
        {
            int[] objects = scene.GetGameObjects();

            foreach (int objectId in objects) {
                //gameObjectManager.Load(objectId);
            }
        }
    }
}
