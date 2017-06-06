namespace Texture.GameObjectTextureDefinition
{
    public class GreenTreeLeftStanding : TextureDefinition
    {
        protected override string contentFile
        {
            get
            {
                return "green_tree";
            }
        }

        protected override string[] spriteList
        {
            get
            {
                string[] a = {
                    "green_tree_1_0"
                };

                return a;
            }
        }
    }

    public class GreenTreeRightStanding : TextureDefinition
    {
        protected override string contentFile
        {
            get
            {
                return "green_tree";
            }
        }

        protected override string[] spriteList
        {
            get
            {
                string[] a = {
                    "green_tree_2_0"
                };

                return a;
            }
        }
    }
}
