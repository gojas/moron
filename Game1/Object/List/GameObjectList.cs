using System;
using System.Linq;

namespace Object.List
{

    public static class GameObjectList
    {
        // pusi kurac
        public static object getByIndex(int index)
        {
            var list = new[]
            {
                new {
                    velocity = 50,
                    positionX = 40,
                    positionY = 40
                },
                new {
                    velocity = 0,
                    positionX = 300,
                    positionY = 300
                }
            };

            return list[index];
        }

        public static Array getComponentsByIndex(int index)
        {

            string[] moron = { "MoronInputComponent", "PhysicsComponent", "MoronGraphicComponent" };
            string[] brick = { "GraphicComponent" };

            string[][] list = { moron, brick };

            return list[index];
        }

    }
}
