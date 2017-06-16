namespace Texture.GameObjectTextureDefinition
{
    public class EmberStanding : TextureDefinition
    {
        protected override string contentFile
        {
            get
            {
                return "ember";
            }
        }

        protected override string[] spriteList
        {
            get
            {
                string[] a = {
                    "ember_0_0"
                };

                return a;
            }
        }
    }
}
