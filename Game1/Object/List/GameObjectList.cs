namespace GameObject.List
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
                    positionX = 1000,
                    positionY = 800,
                    texture = "player",
                    components = new string[] { "MoronInputComponent", "MoronPhysicsComponent", "MoronGraphicComponent" }
                },
                new {
                    velocity = 0,
                    positionX = 300,
                    positionY = 300,
                    texture = "player",
                    components = new string[] { "RectanglePhysicsComponent", "GraphicComponent" }
                },
                new {
                    velocity = 0,
                    positionX = 100,
                    positionY = 100,
                    texture = "background",
                    components = new string[] { "RectanglePhysicsComponent", "GraphicComponent" }
                },
                new {
                    velocity = 0,
                    positionX = 1000,
                    positionY = 400,
                    texture = "background",
                    components = new string[] { "RectanglePhysicsComponent", "GraphicComponent" }
                },
                new {
                    velocity = 0,
                    positionX = 1000,
                    positionY = 378,
                    texture = "background",
                    components = new string[] { "RectanglePhysicsComponent", "GraphicComponent" }
                },
                new {
                    velocity = 0,
                    positionX = 300,
                    positionY = 1200,
                    texture = "background",
                    components = new string[] { "RectanglePhysicsComponent", "GraphicComponent" }
                }
            };

            return list[id];
        }

    }
}
