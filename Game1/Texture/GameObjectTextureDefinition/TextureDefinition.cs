using System.Collections.Generic;

namespace Texture.GameObjectTextureDefinition
{
    public class TextureDefinition
    {
        protected virtual string contentFile
        {
            get { return ""; }
        }

        protected virtual string[] spriteList
        {
            get {
                string[] a = { };

                return a;
            }
        }

        public string GetContentFile()
        {
            return contentFile;
        }

        public string GetSpriteIndex(int id)
        {
            return spriteList[id];
        }

        public int GetSriteTotal()
        {
            return spriteList.Length - 1;
        }
    }
}
