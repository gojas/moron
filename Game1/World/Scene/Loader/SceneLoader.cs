using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace World.Scene.Loader
{
    using World.GameObject;

    public class SceneLoader
    {
        ContentManager contentManager;
        GameObjectManager gameObjectManager;

        Scene scene;

        public SceneLoader(
            ContentManager contentManager,
            GameObjectManager gameObjectManager,
            Scene scene)
        {
            this.contentManager = contentManager;
            this.gameObjectManager = gameObjectManager;
            this.scene = scene;
        }

        public void Load()
        {
            LoadContent();
            LoadObjects();
        }

        private void LoadContent()
        {
            loadTextures();
        }

        private void loadTextures()
        {
            string[] textures = scene.GetTextures();

            foreach (string texture in textures)
                contentManager.Load<Texture2D>(texture);
        }

        private void LoadObjects()
        {
            int[] objects = scene.GetGameObjects();

            foreach (int objectId in objects) {
                gameObjectManager.Load(objectId);
            }
        }
    }
}
