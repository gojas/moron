using System;
using System.Linq;

namespace Object.List
{

    public static class GameObjectList
    {
        // pusi kurac
        public static object getById(int id)
        {
            var list = new[]
            {
                new {
                    velocity = 50,
                    positionX = 40,
                    positionY = 40,
                    texture = "player",
                    components = new string[] { "MoronInputComponent", "MoronPhysicsComponent", "MoronGraphicComponent" }
                },
                new {
                    velocity = 0,
                    positionX = 300,
                    positionY = 300,
                    texture = "player",
                    components = new string[] { "RectanglePhysicsComponent", "GraphicComponent" }
                }
            };

            return list[id];
        }

    }
}
