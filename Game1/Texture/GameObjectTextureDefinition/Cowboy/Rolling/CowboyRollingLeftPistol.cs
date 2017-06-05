namespace Texture.GameObjectTextureDefinition
{

    public class CowboyRollingLeftPistol : TextureDefinition
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
                    "cowboy_walking_pistol_0_0",
                    "cowboy_walking_pistol_1_0",
                    "cowboy_walking_pistol_2_0",
                    "cowboy_walking_pistol_3_0",
                    "cowboy_walking_pistol_4_0",
                    "cowboy_walking_pistol_5_0",
                    "cowboy_walking_pistol_6_0",
                    "cowboy_walking_pistol_7_0",
                    "cowboy_walking_pistol_8_0",
                    "cowboy_walking_pistol_9_0"
                };

                return a;
            }
        }
    }
}
