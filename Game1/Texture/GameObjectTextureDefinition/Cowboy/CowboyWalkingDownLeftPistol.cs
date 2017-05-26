namespace Texture.GameObjectTextureDefinition
{
    class CowboyWalkingDownLeftPistol : TextureDefinition
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
                    "cowboy_walking_pistol_0_8",
                    "cowboy_walking_pistol_1_8",
                    "cowboy_walking_pistol_2_8",
                    "cowboy_walking_pistol_3_8",
                    "cowboy_walking_pistol_4_8",
                    "cowboy_walking_pistol_5_8",
                    "cowboy_walking_pistol_6_8",
                    "cowboy_walking_pistol_7_8",
                    "cowboy_walking_pistol_8_8",
                    "cowboy_walking_pistol_9_8"
                };

                return a;
            }
        }
    }
}
