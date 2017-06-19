namespace World.Scene.Scenes
{
    using World.GameObject.GameObjects;
    using World.Scene;

    public class Scene_1 : Scene
    {
        public override int[] GetGameObjects()
        {
            int[] a = { 0, 1, 2, 3, 6, 7};

            return a;
        }

        public override int[] GetTerrainObjects()
        {
            int[] a = { 0 };

            return a;
        }

        public override int[,] GetTerrainMatrix()
        {
            int[,] a = {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},


            };

            return a;
        }

        public override int[,] GetGameObjectMatrix()
        {
            int[,] a = {
                {0, 1, 7, 1},
                {7, 7, 7, 1},
                {7, 7, 6, 2},
                {7, 7, 6, 1},
                {7, 7, 6, 2},
                {8, 1, 8, GameObjects.SNOW_SCRIPT_COMPONENT}
            };

            return a;
        }

        public override object[] GetSpriteSheets()
        {
            var list = new[]
            {
                new {
                    spriteSheetName = "cowboy_walking_pistol",
                    spriteWidth = 128,
                    spriteHeight = 128
                },
                new {
                    spriteSheetName = "orange_tile_2_1",
                    spriteWidth = 128,
                    spriteHeight = 64
                },
                new {
                    spriteSheetName = "orange_wall_halfcorner_2_1",
                    spriteWidth = 128,
                    spriteHeight = 64
                },
                new {
                    spriteSheetName = "arrow_2_2",
                    spriteWidth = 128,
                    spriteHeight = 128
                },
                new {
                    spriteSheetName = "grass_flowers",
                    spriteWidth = 128,
                    spriteHeight = 88
                },
                new {
                    spriteSheetName = "grass",
                    spriteWidth = 128,
                    spriteHeight = 88
                },
                new {
                    spriteSheetName = "barrel",
                    spriteWidth = 64,
                    spriteHeight = 80
                },
                new {
                    spriteSheetName = "explosion",
                    spriteWidth = 250,
                    spriteHeight = 188
                },
                new {
                    spriteSheetName = "ember",
                    spriteWidth = 4,
                    spriteHeight = 4
                }
            };

            return list;
        }
    }
    
}
