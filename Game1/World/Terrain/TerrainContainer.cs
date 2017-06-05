using System.Collections.Generic;

namespace World.Terrain
{
    public class TerrainContainer
    {
        public IDictionary<int, Tile> TileList;

        public TerrainContainer()
        {
            TileList = new Dictionary<int, Tile>();
        }

        public void Add(int id, Tile tile)
        {
            if (!Exists(id))
                TileList.Add(id, tile);
        }

        public Tile Get(int id)
        {

            return TileList[id];
        }

        public void Remove(int id)
        {
            TileList.Remove(id);
        }

        public IDictionary<int, Tile> GetAll()
        {
            return TileList;
        }

        public void Clear()
        {
            TileList.Clear();
        }

        public bool Exists(int id)
        {
            return TileList.ContainsKey(id);
        }
    }
}
