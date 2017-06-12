namespace Texture.GameObjectTextureDefinition
{
    public class GrassWaving : TextureDefinition
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
