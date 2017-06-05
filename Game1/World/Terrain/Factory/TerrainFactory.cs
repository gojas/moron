using System;
using System.Collections.Generic;

namespace World.Terrain.Factory
{
    public class TerrainFactory
    {
        private readonly IDictionary<int, Tile> TilePool;

        public TerrainFactory()
        {
            this.TilePool = new Dictionary<int, Tile>();
        }

        public Tile Get(int id)
        {
            if (TilePool.ContainsKey(id))
                return TilePool[id];
            
            object gameObjectConfiguration = Terrains.GetById(id);

            Type type = gameObjectConfiguration.GetType();

            string spriteSheetName = type.GetProperty("spriteSheetName").GetValue(gameObjectConfiguration, null).ToString();
            string spriteSheetMappingX = type.GetProperty("spriteSheetMappingX").GetValue(gameObjectConfiguration, null).ToString();
            string spriteSheetMappingY = type.GetProperty("spriteSheetMappingY").GetValue(gameObjectConfiguration, null).ToString();

            return new Tile(spriteSheetName, Int32.Parse(spriteSheetMappingX), Int32.Parse(spriteSheetMappingY));
        }

    }
}
