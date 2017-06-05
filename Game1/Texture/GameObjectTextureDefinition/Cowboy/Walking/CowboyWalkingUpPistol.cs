namespace Texture.GameObjectTextureDefinition
{
    class CowboyWalkingUpPistol : TextureDefinition
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
                    "cowboy_walking_pistol_0_5",
                    "cowboy_walking_pistol_1_5",
                    "cowboy_walking_pistol_2_5",
                    "cowboy_walking_pistol_3_5",
                    "cowboy_walking_pistol_4_5",
                    "cowboy_walking_pistol_5_5",
                    "cowboy_walking_pistol_6_5",
                    "cowboy_walking_pistol_7_5",
                    "cowboy_walking_pistol_8_5",
                    "cowboy_walking_pistol_9_5"
                };

                return a;
            }
        }
    }
}
