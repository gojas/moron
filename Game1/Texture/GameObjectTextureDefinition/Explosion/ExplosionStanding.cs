namespace Texture.GameObjectTextureDefinition
{
    public class ExplosionStanding : TextureDefinition
    {
        protected override string contentFile
        {
            get
            {
                return "explosion";
            }
        }

        protected override string[] spriteList
        {
            get
            {
                string[] a = {
                    "explosion_0_0",
                    "explosion_1_0",
                    "explosion_2_0",
                    "explosion_3_0"
                };

                return a;
            }
        }
    }
}
