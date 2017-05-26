namespace Texture.GameObjectTextureDefinition
{

    public class CowboyWalkingLeftPistol : TextureDefinition
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
                    "cowboy_walking_pistol_0_1",
                    "cowboy_walking_pistol_1_1",
                    "cowboy_walking_pistol_2_1",
                    "cowboy_walking_pistol_3_1",
                    "cowboy_walking_pistol_4_1",
                    "cowboy_walking_pistol_5_1",
                    "cowboy_walking_pistol_6_1",
                    "cowboy_walking_pistol_7_1",
                    "cowboy_walking_pistol_8_1",
                    "cowboy_walking_pistol_9_1"
                };

                return a;
            }
        }
    }
}
