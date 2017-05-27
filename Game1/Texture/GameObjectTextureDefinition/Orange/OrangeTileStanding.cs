namespace Texture.GameObjectTextureDefinition
{
    public class OrangeTileStanding : TextureDefinition
    {
        protected override string contentFile
        {
            get
            {
                return "orange_tile_flat";
            }
        }

        protected override string[] spriteList
        {
            get
            {
                string[] a = {
                    "orange_tile_flat_0_0"
                };

                return a;
            }
        }
    }
}
