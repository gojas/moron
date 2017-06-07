using System.Collections.Generic;

namespace Texture.GameObjectTextureDefinition
{
    public class ArrowStanding : TextureDefinition
    {
        protected override string contentFile
        {
            get
            {
                return "arrow_2_2";
            }
        }

        protected override string[] spriteList
        {
            get
            {
                string[] a = {
                    "arrow_2_2_0_0"
                };

                return a;
            }
        }
    }
}
