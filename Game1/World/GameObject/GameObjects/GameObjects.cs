namespace World.GameObject.GameObjects
{

    class GameObjects
    {
        public static object GetById(int id)
        {
            var list = new[]
            {
                new {
                    velocity = 50,
                    type = "dynamic",
                    name = "Cowboy",
                    items = new string[] { "Pistol" },
                    textureAtlases = new string[] { "cowboy_walking_pistol" },
                    components = new string[] { "MoronInputComponent", "MoronPhysicsComponent", "MoronGraphicComponent" }
                },
                new {
                    velocity = 0,
                    type = "fixed",
                    name = "OrangeTile",
                    items = new string[] { },
                    textureAtlases = new string[] { "orange_tile_flat" },
                    components = new string[] { "FixedGraphicComponent" }
                },
                new {
                    velocity = 0,
                    type = "static",
                    name = "OrangeWallHalfCorner",
                    items = new string[] { },
                    textureAtlases = new string[] { "orange_wall_halfcorner" },
                    components = new string[] { "PhysicsComponent", "FixedGraphicComponent" }
                }
            };

            return list[id];
        }

    }
}