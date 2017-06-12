namespace Texture.GameObjectTextureDefinition
{
    public class GrassStanding : TextureDefinition
    {
        protected override string contentFile
        {
            get
            {
                return "grass";
            }
        }

        protected override string[] spriteList
        {
            get
            {
                string[] a = {
                    "grass_0_0"
                };

                return a;
            }
        }
    }
}
