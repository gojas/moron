namespace Texture.GameObjectTextureDefinition
{
    public class BarrelStanding : TextureDefinition
    {
        protected override string contentFile
        {
            get
            {
                return "barrel";
            }
        }

        protected override string[] spriteList
        {
            get
            {
                string[] a = {
                    "barrel_0_0"
                };

                return a;
            }
        }
    }
}
