namespace Texture.GameObjectTextureDefinition
{
    public class OrangeWallHalfCornerStanding : TextureDefinition
    {
        protected override string contentFile
        {
            get
            {
                return "orange_wall_halfcorner";
            }
        }

        protected override string[] spriteList
        {
            get
            {
                string[] a = {
                    "orange_wall_halfcorner_0_0"
                };

                return a;
            }
        }
    }
}
