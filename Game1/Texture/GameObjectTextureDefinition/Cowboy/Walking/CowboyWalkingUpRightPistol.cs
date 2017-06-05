namespace Texture.GameObjectTextureDefinition
{
    class CowboyWalkingUpRightPistol : TextureDefinition
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
                    "cowboy_walking_pistol_0_4",
                    "cowboy_walking_pistol_1_4",
                    "cowboy_walking_pistol_2_4",
                    "cowboy_walking_pistol_3_4",
                    "cowboy_walking_pistol_4_4",
                    "cowboy_walking_pistol_5_4",
                    "cowboy_walking_pistol_6_4",
                    "cowboy_walking_pistol_7_4",
                    "cowboy_walking_pistol_8_4",
                    "cowboy_walking_pistol_9_4"
                };

                return a;
            }
        }
    }
}
