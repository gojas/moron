using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace World.Scene.Loader
{
    using World.Terrain;
    using World.GameObject;
    using Texture;
    using System;

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
            object[] textures = Scene.GetSpriteSheets();

            foreach (object texture in textures) {
                object gameObjectConfiguration = texture;

                Type type = gameObjectConfiguration.GetType();

                string spriteSheetName = type.GetProperty("spriteSheetName").GetValue(gameObjectConfiguration, null).ToString(); ;
                string spriteWidth = type.GetProperty("spriteWidth").GetValue(gameObjectConfiguration, null).ToString();
                string spriteHeight = type.GetProperty("spriteHeight").GetValue(gameObjectConfiguration, null).ToString(); ;

                SpriteManager.LoadSpriteSheet(spriteSheetName, Int32.Parse(spriteWidth), Int32.Parse(spriteHeight));
            }
                
        }

        private void LoadObjects()
        {
            int[] objects = Scene.GetGameObjects();

            foreach (int objectId in objects)
                GameObjectManager.Load(objectId);
        }
    }
}
