namespace World.GameObject.GameObjects
{

    class GameObjects
    {
        public static object getById(int id)
        {
            var list = new[]
            {
                new {
                    velocity = 50,
                    name = "Cowboy",
                    items = new string[] { "Pistol" },
                    textureAtlases = new string[] { "cowboy_walking_pistol" },
                    components = new string[] { "MoronInputComponent", "MoronPhysicsComponent", "MoronGraphicComponent" }
                },
                new {
                    velocity = 50,
                    name = "Cowboy",
                    items = new string[] { },
                    textureAtlases = new string[] { "cowboy_walking_pistol" },
                    components = new string[] { "InputComponent", "PhysicsComponent", "GraphicComponent" }
                },
                new {
                    velocity = 50,
                    name = "Cowboy",
                    items = new string[] { },
                    textureAtlases = new string[] { "cowboy_walking_pistol" },
                    components = new string[] { "InputComponent", "PhysicsComponent", "GraphicComponent" }
                }
            };

            return list[id];
        }

    }
}