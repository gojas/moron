namespace Texture.GameObjectTextureDefinition
{

    public class CowboyWalkingDownPistol : TextureDefinition
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
                    "cowboy_walking_pistol_0_9",
                    "cowboy_walking_pistol_1_9",
                    "cowboy_walking_pistol_2_9",
                    "cowboy_walking_pistol_3_9",
                    "cowboy_walking_pistol_4_9",
                    "cowboy_walking_pistol_5_9",
                    "cowboy_walking_pistol_6_9",
                    "cowboy_walking_pistol_7_9",
                    "cowboy_walking_pistol_8_9",
                    "cowboy_walking_pistol_9_9"
                };

                return a;
            }
        }
    }
}
