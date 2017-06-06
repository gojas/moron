namespace Texture.GameObjectTextureDefinition
{
    public class OrangeTileStanding : TextureDefinition
    {
        protected override string contentFile
        {
            get
            {
                return "orange_tile_2_1";
            }
        }

        protected override string[] spriteList
        {
            get
            {
                string[] a = {
                    "orange_tile_2_1_0_0"
                };

                return a;
            }
        }
    }
}
