using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texture.GameObjectTextureDefinition
{
    public class TextureDefinitionFactory
    {
        public static TextureDefinition Get(string name)
        {
             return Activator.CreateInstance(Type.GetType("Texture.GameObjectTextureDefinition." + name)) as TextureDefinition;
        }

    }
}
