namespace Texture.GameObjectTextureDefinition
{
    class CowboyRollingUpLeftPistol : TextureDefinition
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
                    "cowboy_walking_pistol_0_6",
                    "cowboy_walking_pistol_1_6",
                    "cowboy_walking_pistol_2_6",
                    "cowboy_walking_pistol_3_6",
                    "cowboy_walking_pistol_4_6",
                    "cowboy_walking_pistol_5_6",
                    "cowboy_walking_pistol_6_6",
                    "cowboy_walking_pistol_7_6",
                    "cowboy_walking_pistol_8_6",
                    "cowboy_walking_pistol_9_6"
                };

                return a;
            }
        }
    }
}
