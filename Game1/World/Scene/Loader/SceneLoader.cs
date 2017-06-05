using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace World.Scene.Loader
{
    using World.Terrain;
    using World.GameObject;
    using Texture;

    public class SceneLoader
    {
        public SpriteManager SpriteManager;
        GameObjectManager GameObjectManager;
        TerrainManager TerrainManager;

        Scene Scene;

        public SceneLoader(
            SpriteManager SpriteManager,
            GameObjectManager GameObjectManager,
            TerrainManager TerrainManager,
            Scene Scene)
        {
            this.SpriteManager = SpriteManager;
            this.GameObjectManager = GameObjectManager;
            this.TerrainManager = TerrainManager;
            this.Scene = Scene;
        }

        public void Load()
        {
            LoadContent();
            LoadTerrain();
            LoadObjects();
        }

        private void LoadContent()
        {
            LoadTextures();
        }

        private void LoadTerrain()
        {
            int[] terrains = Scene.GetTerrainObjects();

            foreach (int terrainId in terrains)
                TerrainManager.Load(terrainId);
        }

        private void LoadTextures()
        {
            string[] textures = Scene.GetTextures();

            foreach (string texture in textures)
                SpriteManager.Load(texture);
        }

        private void LoadObjects()
        {
            int[] objects = Scene.GetGameObjects();

            foreach (int objectId in objects)
                GameObjectManager.Load(objectId);
        }
    }
}
