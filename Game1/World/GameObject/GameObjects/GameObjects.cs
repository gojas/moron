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
                    customClass = "MoronGameObject",
                    name = "Cowboy",
                    spriteHeight = 128,
                    spriteWidth = 128,
                    items = new string[] { "Bow" },
                    textureAtlases = new string[] { "cowboy_walking_pistol" },
                    components = new string[] { "MoronInputComponent", "MoronPhysicsComponent", "MoronGraphicComponent" }
                },
                new {
                    velocity = 0,
                    customClass = "",
                    name = "OrangeTile",
                    spriteHeight = 64,
                    spriteWidth = 128,
                    items = new string[] { },
                    textureAtlases = new string[] { "orange_tile_2_1" },
                    components = new string[] { "FixedGraphicComponent" }
                },
                new {
                    velocity = 0,
                    customClass = "",
                    name = "OrangeWallHalfCorner",
                    spriteHeight = 64,
                    spriteWidth = 128,
                    items = new string[] { },
                    textureAtlases = new string[] { "orange_wall_halfcorner_2_1" },
                    components = new string[] { "PhysicsComponent", "FixedGraphicComponent", "HealthComponent" }
                },
                new {
                    velocity = 0,
                    customClass = "",
                    name = "RespawnScript",
                    spriteHeight = 0,
                    spriteWidth = 0,
                    items = new string[] { },
                    textureAtlases = new string[] { },
                    components = new string[] { "MoronSpawnScriptComponent", "PhysicsComponent" }
                },
                new {
                    velocity = 100,
                    customClass = "",
                    name = "Bow",
                    spriteHeight = 0,
                    spriteWidth = 0,
                    items = new string[] { },
                    textureAtlases = new string[] { },
                    components = new string[] { "ArrowSpawnScriptComponent", "ArrowPhysicsComponent", "ArrowGraphicComponent" }
                },
                new {
                    velocity = 100,
                    customClass = "DamageGameObject",
                    name = "Arrow",
                    spriteHeight = 0,
                    spriteWidth = 0,
                    items = new string[] { },
                    textureAtlases = new string[] { "arrow_2_2" },
                    components = new string[] { "ArrowPhysicsComponent", "ArrowGraphicComponent" }
                },
                new {
                    velocity = 0,
                    customClass = "",
                    name = "GrassFlowers",
                    spriteHeight = 0,
                    spriteWidth = 0,
                    items = new string[] { },
                    textureAtlases = new string[] { "grass_flowers" },
                    components = new string[] { "FixedGraphicComponent" }
                },
                new {
                    velocity = 0,
                    customClass = "",
                    name = "Grass",
                    spriteHeight = 0,
                    spriteWidth = 0,
                    items = new string[] { },
                    textureAtlases = new string[] { "grass" },
                    components = new string[] { "GrassPhysicsComponent", "GrassGraphicComponent" }
                },
                new {
                    velocity = 0,
                    customClass = "",
                    name = "Barrel",
                    spriteHeight = 0,
                    spriteWidth = 0,
                    items = new string[] { },
                    textureAtlases = new string[] { "barrel" },
                    components = new string[] { "PhysicsComponent", "FixedGraphicComponent", "HealthComponent", "ExplosionSpawnScriptComponent" }
                },
                new {
                    velocity = 0,
                    customClass = "",
                    name = "Explosion",
                    spriteHeight = 0,
                    spriteWidth = 0,
                    items = new string[] { },
                    textureAtlases = new string[] { "explosion" },
                    components = new string[] { "ExplosionGraphicComponent" }
                }
            };

            return list[id];
        }

    }
}