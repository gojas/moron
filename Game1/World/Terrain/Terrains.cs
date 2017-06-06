using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Terrain
{
    public class Terrains
    {
        public Terrains()
        {
            
        }

        public static object GetById(int id)
        {

            var list = new[]
                {
                new {
                    customClass = "",
                    name = "OrangeTile",
                    spriteSheetMappingX = 0,
                    spriteSheetMappingY = 0,
                    spriteSheetName = "orange_tile_2_1"
                }
            };

            return list[id];
        }

    }
}
