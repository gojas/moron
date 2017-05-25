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
                    textureAtlases = new string[] { "cowboy" },
                    components = new string[] { "MoronInputComponent", "MoronPhysicsComponent", "MoronGraphicComponent" }
                },
                new {
                    velocity = 50,
                    textureAtlases = new string[] { "cowboy" },
                    components = new string[] { "InputComponent", "PhysicsComponent", "GraphicComponent" }
                },
                new {
                    velocity = 50,
                    textureAtlases = new string[] { "cowboy" },
                    components = new string[] { "InputComponent", "PhysicsComponent", "GraphicComponent" }
                }
            };

            return list[id];
        }

    }
}