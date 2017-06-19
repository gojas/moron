namespace Texture.GameObjectTextureDefinition
{
    class CowboyFiringRangePistol : TextureDefinition
    {
        protected override string contentFile
        {
            get
            {
                return "cowboy_walking_pistol";
            }
        }

        protected override string[] spriteList
        {
            get
            {
                string[] a = {
                    "cowboy_walking_pistol_0_8"
                };

                return a;
            }
        }
    }
}
