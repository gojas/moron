namespace Texture.GameObjectTextureDefinition
{
    public class GrassFlowersStanding : TextureDefinition
    {
        protected override string contentFile
        {
            get
            {
                return "grass_flowers";
            }
        }

        protected override string[] spriteList
        {
            get
            {
                string[] a = {
                    "grass_flowers_0_0"
                };

                return a;
            }
        }
    }
}
