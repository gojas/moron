namespace World.Terrain
{
    public class Tile
    {
        public string SpriteSheetName;
        public int SpriteSheetContainerMappingX;
        public int SpriteSheetContainerMappingY;

        public Tile(string SpriteSheetName, int SpriteSheetContainerMappingX, int SpriteSheetContainerMappingY)
        {
            this.SpriteSheetName = SpriteSheetName;
            this.SpriteSheetContainerMappingX = SpriteSheetContainerMappingX;
            this.SpriteSheetContainerMappingY = SpriteSheetContainerMappingY;
        }

        public string GetSpriteNameBasedOnMapping()
        {
            return SpriteSheetName + '_' + SpriteSheetContainerMappingX + '_' + SpriteSheetContainerMappingY;
        }

    }
}
